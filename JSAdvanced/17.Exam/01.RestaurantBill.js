function addProduct() {
    let inputs = $('#add-product input');
    let productBox = $(inputs[0]);
    let priceBox = $(inputs[1]);

    console.log(productBox.val());
    console.log(priceBox.val());

    if(productBox.val() === '' || priceBox.val() === '') {
        return;
    }

    let bill = $('#product-list');
    bill.append(`<tr><td>${productBox.val()}</td><td>${priceBox.val()}</td></tr>`);

    let sum = $('#bill tfoot tr td:nth-child(2)');

    sum.text(Number(sum.text()) + Number(priceBox.val()));

    productBox.val('');
    priceBox.val('');
}