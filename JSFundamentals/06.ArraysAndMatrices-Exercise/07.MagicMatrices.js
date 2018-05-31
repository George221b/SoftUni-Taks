function solve(matrix) {
    
    let initialSum = matrix[0].reduce((a, b) => a + b, 0);

    for (let row = 1; row < matrix.length; row++) {
        let rowSum = matrix[row].reduce((a, b) => a + b, 0);

        if (rowSum !== initialSum) {
            return false;
        }
    }

    for (let el = 0; el < matrix[0].length; el++) {
        let colSum = 0;

        for (let col = 0; col < matrix.length; col++) {
            colSum += matrix[col][el];
        }

        if (colSum !== initialSum) {
            return false;
        }
    }

    return true;
}