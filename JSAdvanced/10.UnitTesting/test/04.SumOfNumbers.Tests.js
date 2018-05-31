let expect = require('chai').expect;
const sum = require('../04.SumOfNumbers').sum;

describe('Test sumNumbers function', function () {
    it('Should work correctly with given parameters', function () {
        expect(sum([4, 5])).to.be.equal(9);
    });

    it('Should work with array of 1 elements', function () {
        expect(sum([9])).to.be.equal(9);
    });

    it('Should return 0 for empty array', function () {
        expect(sum([])).to.be.equal(0);
    });

    it('Work with floating numbers', function () {
        expect(sum([1.1, 1.1, 1.1])).to.be.closeTo(3.30, 0.01);
    });

    it('should return NaN for "invalid data"', function () {
        expect(sum('invalid data')).to.be.NaN
    });
});