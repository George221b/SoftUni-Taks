const PaymentPackage = require('../02.PaymentPackage').PaymentPackage;
const expect = require('chai').expect;

// Not a lot of time so full spaghetti

describe("PaymentPackage tests", function () {
    it('Shoud throw with empty constructor', function () {
        expect(() => {
            let sot = new PaymentPackage()
        }).to.throw(Error)
    });

    it("Test if class properties exists", function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(Object.getPrototypeOf(sot).hasOwnProperty('name')).to.be.equal(true);
        expect(Object.getPrototypeOf(sot).hasOwnProperty('value')).to.be.equal(true);
        expect(Object.getPrototypeOf(sot).hasOwnProperty('VAT')).to.be.equal(true);
        expect(Object.getPrototypeOf(sot).hasOwnProperty('active')).to.be.equal(true);
        expect(Object.getPrototypeOf(sot).hasOwnProperty('toString')).to.be.equal(true);
        expect(Object.getPrototypeOf(sot).hasOwnProperty('constructor')).to.be.equal(true);
        expect(typeof PaymentPackage).to.be.equal('function');
    });

    it('Test name with correct params', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        sot.name = 'Correct';

        expect(sot.name).to.be.equal('Correct')
    });

    it('Name to throw with num', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.name = 10
        }).to.throw(Error)
    });

    it('Name to throw with obj', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.name = {Name: 'Not right'}
        }).to.throw(Error)
    });

    it('Name to throw with empty string', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.name = ''
        }).to.throw(Error)

        expect(() => {
            sot.name = null
        }).to.throw(Error)
    });

    it('Test get name', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(sot._name).to.be.equal('HR Services')
    });

    it('Value', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(sot.value).to.be.equal(1500)
    })

    it('value', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        sot.value = 101.1;

        expect(sot._value).to.be.equal(101.1)
    })

    it('Value', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.value = 'not a num'
        }).to.throw(Error)
    })

    it('negative value', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.value = -10
        }).to.throw(Error)

        expect(() => {
            sot.value = null
        }).to.throw(Error)
    })

    it('VAT', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        sot.VAT = 100;

        expect(sot._VAT).to.be.equal(100)
    })

    it('vat', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        sot.VAT = 101.11;

        expect(sot._VAT).to.be.equal(101.11)
    })

    it('Vat with string', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.VAT = 'not a num'
        }).to.throw(Error)
    })

    it('negative VAT', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.VAT = -10
        }).to.throw(Error)

        expect(() => {
            sot.VAT = {VAT: 100}
        }).to.throw(Error)

        expect(() => {
            sot.VAT = null
        }).to.throw(Error)
    })

    it('Active set to true', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        sot.active = true;

        expect(sot._active).to.be.true
    })

    it('Active set to false', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        sot.active = false;

        expect(sot._active).to.be.false
    })

    it('Active to throw', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(() => {
            sot.active = 10;
        }).to.throw(Error)
        expect(() => {
            sot.active = {active: true};
        }).to.throw(Error)
        expect(() => {
            sot.active = 'hello world';
        }).to.throw(Error)
        expect(() => {
            sot.active = null;
        }).to.throw(Error)
    })

    it('tostring', function () {
        let sot = new PaymentPackage('HR Services', 1500);
        sot.value = 1000;
        sot.VAT = 20;


        const output = [
            `Package: HR Services` + '',
            `- Value (excl. VAT): 1000`,
            `- Value (VAT 20%): 1200`
        ];

        expect(sot.toString()).to.be.equal(output.join('\n'))
    })

    it('tostring inactive', function () {
        let sot = new PaymentPackage('HR Services', 1500);
        sot.value = 1000;
        sot.VAT = 20;
        sot.active = false;


        const output = [
            `Package: HR Services` + ' (inactive)',
            `- Value (excl. VAT): 1000`,
            `- Value (VAT 20%): 1200`
        ];

        expect(sot.toString()).to.be.equal(output.join('\n'))
    })

    it('tostring inactive', function () {
        let sot = new PaymentPackage('HR Services', 1500);
        sot.value = 1000;


        const output = [
            `Package: HR Services` + '',
            `- Value (excl. VAT): 1000`,
            `- Value (VAT 20%): 1200`
        ];

        expect(sot.toString()).to.be.equal(output.join('\n'))
    })

    it('test default values', function () {
        let sot = new PaymentPackage('HR Services', 1500);

        expect(sot.VAT).to.be.equal(20);
        expect(sot.active).to.be.true;
    })
})