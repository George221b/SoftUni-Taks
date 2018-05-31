class PaymentManager {
    constructor(title) {
        this.title = title;
        this.element = this.createElement();
    }

    render(id) {

        $(`#${id}`).append(this.element)
    }

    _add() {
        let inputs = this.element.find($('.input-data input'));

        let name = $(inputs[0]);
        let category = $(inputs[1]);
        let price = $(inputs[2]);

        if (name.val() === '' || category.val() === '' || price.val() === '') {
            return;
        }


        let tr = $('<tr></tr>');
        tr.append(`<td>${name.val()}</td>`);
        tr.append(`<td>${category.val()}</td>`);
        tr.append(`<td>${Number(price.val())}</td>`);

        let tdForButton = $('<td>');
        let button = $('<button>Delete</button>');
        button.on('click', this._delete);

        tdForButton.append(button);
        tr.append(tdForButton);

        this.element.find($('.payments')).append(tr);

        name.val('');
        category.val('');
        price.val('');
    }

    _delete() {
        $(this).parent().parent().remove();
    }

    createElement() {
        let table = $('<table>');
        let caption = $(`<caption>${this.title} Payment Manager</caption>`);
        let thead = $(`<thead><tr><th class="name">Name</th><th class="category">Category</th><th class="price">Price</th><th>Actions</th></tr></thead>`);
        let tbody = $('<tbody class="payments"></tbody>');

        let tfoot = $('<tfoot class="input-data"></tfoot>');

        let tableRowFoot = $('<tr>');


        tableRowFoot.append('<td><input name="name" type="text"></td>');
        tableRowFoot.append('<td><input name="category" type="text"></td>');
        tableRowFoot.append('<td><input name="price" type="number"></td>');

        let tdForButton = $('<td></td>');
        let button = $('<button>Add</button>');
        button.on('click', this._add.bind(this));

        tdForButton.append(button);
        tableRowFoot.append(tdForButton);
        tfoot.append(tableRowFoot)

        table.append(caption);
        table.append(thead);
        table.append(tbody);
        table.append(tfoot);

        return table;
    }
}