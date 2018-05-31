class Rat {
    constructor(name) {
        this.name = name;
        this.uniteRats = [];
    }

    unite(otherRat) {
        if (otherRat instanceof Rat) {
            this.uniteRats.push(otherRat);
        }
    }

    getRats() {
        return this.uniteRats
    }

    toString() {
        let result = `${this.name}\n`;
        for (let rat of this.uniteRats) {
            result += '##' + rat.name + '\n';
        }

        return result.trim();
    }
}

let test = new Rat("Pesho");
console.log(test.toString());

console.log(test.getRats());

test.unite(new Rat("Gosho"));
test.unite(new Rat("Sasho"));
console.log(test.getRats());

console.log(test.toString());
