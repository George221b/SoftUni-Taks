function solve(arr) {
    let sum = arr.reduce((a, b) => a + b);
    let min = Math.min(...arr);
    let max = Math.max(...arr);
    let prod = arr.reduce((a, b) => a * b);
    let join = [...arr].join('');
    console.log(`Sum = ${sum}`);
    console.log(`Min = ${min}`);
    console.log(`Max = ${max}`);
    console.log(`Product = ${prod}`);
    console.log(`Join = ${join}`);
}

function aggregates(params) {
    let arr = params.map(Number);
    let result = `Sum = ${arr.reduce((a, b) => a + b)}\n` +
        `Min = ${Math.min.apply(null, arr)}\n` +
        `Max = ${Math.max.apply(null, arr)}\n` +
        `Product = ${arr.reduce((a, b) => a * b)}\n` +
        `Join = ${arr.reduce((a, b) => a + '' + b)}`;

    console.log(result);
}

solve([2, 3, 10, 5]);