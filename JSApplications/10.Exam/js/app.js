$(() => {
    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs');

        this.get('#/home', getWelcomePage);
        this.get('index.html', getWelcomePage);
        this.get('#/register', getWelcomePage);
        this.get('#/login', getWelcomePage);

        this.post('#/register', (ctx) => {
            let username = ctx.params['username-register'];
            let password = ctx.params['password-register'];
            let repeatPass = ctx.params['password-register-check'];

            if (username.length < 5) {
                notify.showError('Username must be at least 5 characters long');
            } else if (password.length < 1 || password === '') {
                notify.showError('The password field is empty!');
            } else if (repeatPass !== password) {
                notify.showError("Passwords don't match!");
            } else {
                auth.register(username, password)
                    .then((userData) => {
                        auth.saveSession(userData);
                        notify.showInfo('User registration successful.');
                        ctx.redirect('#/editor');
                    })
                    .catch(notify.handleError);
            }
        });
        this.post('#/login', (ctx) => {
            let username = ctx.params['username-login'];
            let password = ctx.params['password-login'];

            if (username.length < 5) {
                notify.showError('Username must be at least 5 characters long');
            } else if (password.length < 1 || password === '') {
                notify.showError('The password field is empty!');
            } else {
                auth.login(username, password)
                    .then((userData) => {
                        auth.saveSession(userData);
                        notify.showInfo('Login successful.');
                        ctx.redirect('#/editor');
                    })
                    .catch(notify.handleError);
            }
        });
        this.get('#/logout', (ctx) => {
            auth.logout()
                .then(() => {
                    sessionStorage.clear();
                    notify.showInfo('Logout successful.');
                    ctx.redirect('#/register');
                })
                .catch(notify.handleError);
        });

        this.get('#/editor', async (ctx) => {
            if (!auth.isAuth()) {
                ctx.redirect('#/login');
                return;
            }

            let userId = sessionStorage.getItem('userId');

            let activeReceipt;
            activeReceipt = await receipts.getActiveReceipt(userId);

            if (activeReceipt.length === 0) {
                activeReceipt = await receipts.createReceipt();
            } else {
                activeReceipt = activeReceipt[0];
            }

            let entries = await entriesService.getEntriesByReceiptId(activeReceipt['_id']);

            let total = 0;

            entries.forEach((e, i) => {
                e.subTotal = Number(e.qty) * Number(e.price);
                total += e.subTotal;
                e.subTotal = Number(e.subTotal).toFixed(2);
                e.price = Number(e.price).toFixed(2);
            });

            let receiptId = activeReceipt['_id'];
            console.log(receiptId);
            let productCount = entries.length;

            sessionStorage.setItem('receipt', receiptId);

            ctx.receiptId = receiptId;
            ctx.entries = entries;
            ctx.username = sessionStorage.getItem('username'); // header
            ctx.total = total.toFixed(2);
            ctx.productCount = productCount;


            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                entry: './templates/entries/entry.hbs'
            }).then(function () {
                this.partial('./templates/views/editor.hbs');
            });
        });

        this.post('#/entry/create', (ctx) => {
            if (!auth.isAuth()) {
                ctx.redirect('#/register');
                return;
            }

            let type = ctx.params.type;
            let qty = ctx.params.qty;
            let price = ctx.params.price;


            if (type === '') {
                notify.showError('Product name must be a non-empty string');
            } else if (!isNumeric(qty)) {
                notify.showError('Quantity must be a number');
            } else if (!isNumeric(price)) {
                notify.showError('Price must be a number');
            } else {
                qty = Number(qty);
                price = Number(price);
                let receiptId = sessionStorage.getItem('receipt');

                entriesService.addEntry(receiptId, price, qty, type)
                    .then(() => {
                        notify.showInfo('Entry added');
                        ctx.redirect('#/editor');
                    })
                    .catch(notify.handleError);
            }
        });

        this.post('#/receipt/commit', (ctx) => {
            let receiptId = ctx.params.receiptId;
            let productCount = ctx.params.productCount;
            let total = ctx.params.total;

            if (productCount < 1) {
                notify.showError('You cannot checkout empty receipt!');
            } else {
                receipts.commitReceipt(receiptId, total, productCount)
                    .then(() => {
                        notify.showInfo(`Receipt checked out`);
                        ctx.redirect('#/editor');
                    })
                    .catch(notify.showError);
            }
        });

        this.get('#/entry/delete/:entryId', (ctx) => {
            if (!auth.isAuth()) {
                ctx.redirect('#/register');
                return;
            }

            let entryId = ctx.params.entryId;

            entriesService.deleteEntry(entryId)
                .then(() => {
                    notify.showInfo('Entry removed');
                    ctx.redirect('#/editor');
                })
                .catch(notify.handleError);
        });

        this.get('#/overview', async (ctx) => {
            if (!auth.isAuth()) {
                ctx.redirect('#/register');
                return;
            }

            let myReceipts = await receipts.getMyReceipts(sessionStorage.getItem('userId'));
            let sumTotal = 0;

            if(myReceipts.length > 0) {
                myReceipts.forEach((r, i) => {
                    let date = new Date((r._kmd.ect)).toISOString().slice(0,16);
                    date = date.toString().split('T').join(' ');

                    r.date = date;
                    sumTotal += Number(r.total);
                    r.total = Number(r.total).toFixed(2)
                });
            }

            ctx.myReceipts = myReceipts;
            ctx.username = sessionStorage.getItem('username'); // header
            ctx.sumTotal = Number(sumTotal).toFixed(2);

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                receipt: './templates/receipts/receipt.hbs',
            }).then(function () {
                this.partial('./templates/views/overview.hbs');
            })
        });

        this.get('#/receipt/details/:receiptId', async (ctx) => {
            if (!auth.isAuth()) {
                ctx.redirect('#/register');
                return;
            }

            let receiptId = ctx.params.receiptId;
            let entriesForReceipt;
            let receipt;

            try {
                receipt = await receipts.receiptDetails(receiptId);
            } catch(e) {
                notify.showError(e.message);
            }

            try {
                entriesForReceipt = await entriesService.getEntriesByReceiptId(receipt['_id']);
            } catch(e) {
                notify.showError(e.message);
            }

            entriesForReceipt.forEach((e, i) => {
                e.price = Number(e.price).toFixed(2);
                e.subTotal = (Number(e.qty) * Number(e.price)).toFixed(2);
            });

            ctx.entriesForReceipt = entriesForReceipt;
            ctx.username = sessionStorage.getItem('username'); // header

            ctx.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
                entryDetailsList: './templates/entries/entryDetailsList.hbs',
            }).then(function () {
                this.partial('./templates/views/receiptDetails.hbs');
            })
        });

        function getWelcomePage(ctx) {
            if (!auth.isAuth()) {
                ctx.loadPartials({
                    footer: './templates/common/footer.hbs'
                }).then(function () {
                    this.partial('./templates/views/anonymous.hbs');
                })
            } else {
                ctx.redirect('#/editor');
            }
        }
        function isNumeric(n) {
            return !isNaN(parseFloat(n)) && isFinite(n);
        }
    });

    app.run();
});