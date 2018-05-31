function solve(input) {
    let tMatrixLength = input.shift();
    let templateMatrix = [];
    let matrix = [];
    let result = "";

    for (let i = 0; i < tMatrixLength; i++) {
        templateMatrix.push(input[i].split(' ').map(Number));
    }

    for (let i = tMatrixLength; i < input.length; i++) {
        matrix.push(input[i].split(' ').map(Number));
    }

    for (let i = 0; i < matrix.length; i++) {
        let rowIndex = i % templateMatrix.length;

        for (let j = 0; j < matrix[i].length; j++) {
            let colIndex = j % templateMatrix[0].length;

            matrix[i][j] += templateMatrix[rowIndex][colIndex];

            result += String.fromCharCode((matrix[i][j] % 27) + 64);
        }
    }

    result = result.replace(/@/g, ' ');
    console.log(result);
}

solve(
    [ '2',
        '59 36',
        '82 52',
        '4 18 25 19 8',
        '4 2 8 2 18',
        '23 14 22 0 22',
        '2 17 13 19 20',
        '0 9 0 22 22' ]
);