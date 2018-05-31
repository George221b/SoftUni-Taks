function cook(input) {
    let operations = {
        chop: (num => num / 2),
        dice: (num => Math.sqrt(num)),
        spice: (num => num + 1),
        bake: (num => num * 3),
        fillet: (num => num * 0.8)
    }

    let number = input[0];

    for (let i = 1; i < input.length; i++) {
        if (operations[input[i]] != undefined) {
            number = operations[input[i]](number);
            console.log(number);
        }
    }
}

cook([9, 'dice', 'spice', 'chop', 'bake', 'fillet']);