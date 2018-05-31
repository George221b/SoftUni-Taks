class PaymentProcessor {
    constructor() {
        this._payments = [];
        this.options = {
            types: ["service", "product", "other"],
            precision: 2
        };
        if (arguments.length !== 0) {
            this.setOptions(arguments[0]);
        }
    }

    registerPayment(id, name, type, value) {
        if (typeof id !== 'string' || typeof name !== 'string') {
            throw new Error('Name must be a non-empty string');
        }
        if (id.length === 0 || name.length === 0) {
            throw new Error('Name must be a non-empty string');
        }
        if (!Number(value)) {
            throw new Error('Value must a number.');
        }
        if (!this.options.types.includes(type)) {
            throw new Error('Type is not listed in options.types')
        }
        if (this._payments.map(e => e.id).includes(id)) {
            throw new Error('Id exists.')
        }

        this._payments.push({
            id,
            name,
            type,
            value
        });
    }

    deletePayment(id) {
        let isDeleted = false;

        for (let i = 0; i < this._payments.length; i++) {
            if (id === this._payments[i].id) {
                this._payments.splice(i, 1);
                isDeleted = true;
            }
        }

        if (!isDeleted) {
            throw new Error('Delete: No payment with that ID exists.');
        }
    }

    get(id) {
        let element;

        for (let i = 0; i < this._payments.length; i++) {
            if (id === this._payments[i].id) {
                element = this._payments[i];
            }
        }

        if (element === undefined) {
            throw new Error('Get: No payment with that ID exists.');
        }

        return `Details about payment ID: ${element.id}\n` +
            `- Name: ${element.name}\n` +
            `- Type: ${element.type}\n` +
            `- Value: ${element.value.toFixed(this.options.precision)}`;
    }

    setOptions(options) {
        if (options.types !== undefined) {
            this.options.types = options.types;
        }
        if (options.precision !== undefined) {
            this.options.precision = options.precision
        }
    }

    toString() {
        let sum = 0;

        for (let i = 0; i < this._payments.length; i++) {
            sum += this._payments[i].value;
        }

        return `Summary:\n` +
`- Payments: ${this._payments.length}\n` +
`- Balance: ${sum.toFixed(this.options.precision)}`;
    }
}


const generalPayments = new PaymentProcessor();

console.log(generalPayments.toString());

generalPayments.registerPayment('0001', 'Microchips', 'product', 15000.03);
console.log(generalPayments.toString());
console.log(generalPayments.get('0001'));

generalPayments.registerPayment('01A3', 'Biopolymer', 'product', 23000);
generalPayments.registerPayment('01', 'HR Consultation', 'service', 3000);
console.log(generalPayments.toString());

console.log(generalPayments.get('0001'));
