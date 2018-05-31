function toStringExtension() {
    class Person {
        constructor(name, email) {
            this.name = name;
            this.email = email;
        }

        toString() {
            let className = this.constructor.name;
            return `${className} (name: ${this.name}, email: ${this.email})`;
        }
    }

    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email);
            this.subject = subject;
        }

        toString() {
            let parentStr = super.toString().slice(0, -1);
            return parentStr + `, subject: ${this.subject})`;
        }
    }

    class Student extends Person {
        constructor(name, email, course) {
            super(name, email);
            this.course = course;
        }

        toString() {
            let parentStr = super.toString().slice(0, -1);
            return parentStr + `, course: ${this.course})`;
        }
    }

    return { Person, Teacher, Student }
}

let obj = toStringExtension();

let Person = obj.Person;
let Teacher = obj.Teacher;
let Student = obj.Student;

let person = new Person('Pesho', 'pesho@abv.bg');
let teacher = new Teacher('George', 'ss@abv.bg', 'Mein K.');
let student = new Student('Quentin', 'sss@abv.bg', 'Something');

console.log(person.toString());
console.log(teacher.toString());
console.log(student.toString());

module.exports = {Person};