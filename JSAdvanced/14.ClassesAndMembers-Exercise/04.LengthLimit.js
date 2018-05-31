class Stringer {
    constructor(string, length) {
        this.innerString = string;
        this.innerLength = length;
    }

    get innerLength() {
        return this._innerLength;
    }

    set innerLength(length) {
        if (length < 0) {
            length = 0;
        }

        this._innerLength = length;
    }

    increase(length) {
        this.innerLength += length;
    }

    decrease(length) {
        this.innerLength -= length;
    }

    toString() {
        if(this.innerLength > this.innerString.length - 1) {
            return this.innerString
        }

        return this.innerString.substring(0, this.innerLength) + '...';
    }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); //Test

test.decrease(3);
console.log(test.toString()); //Te...

test.decrease(5);
console.log(test.toString()); //...

test.increase(4);
console.log(test.toString()); //Test