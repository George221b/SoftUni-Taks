let Person = require('./02.InhertingToString').Person;

function extendClass(classToExtend) {
    classToExtend.prototype.species = 'Human';
    classToExtend.prototype.toSpeciesString = function () {
        return `I am a ${this.species}. ${this.toString()}`;
    }
}

extendClass(Person);
let newObjPerson = new Person('me', 'email');
console.log(newObjPerson.toSpeciesString());