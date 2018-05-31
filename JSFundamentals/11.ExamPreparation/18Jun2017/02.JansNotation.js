function solve(input) {

    let result = [];

    for (let element of input) {
        if (Number.isInteger(element)) {
            result.push(element)
        } else if (result.length < 2) {
            console.log(`Error: not enough operands!`);
            return;
        } else {
            doOperation(element);
        }
    }

    if (result.length >= 2){
        console.log(`Error: too many operands!`);
        return;
    }

    console.log(result[0]);

    function doOperation(operator) {
        switch (operator) {
            case '-':
                result[result.length - 2] = result[result.length - 2] - result[result.length - 1];
                result.pop();
                break;
            case '+':
                result[result.length - 2] = result[result.length - 2] + result[result.length - 1];
                result.pop();
                break;
            case '*':
                result[result.length - 2] = result[result.length - 2] * result[result.length - 1];
                result.pop();
                break;
            case '/':
                result[result.length - 2] = result[result.length - 2] / result[result.length - 1];
                result.pop();
                break;
            default: break;
        }
    }
}

solve([-1,
    1,
    '+',
    101,
    '*',
    18,
    '+',
    3,
    '/']);