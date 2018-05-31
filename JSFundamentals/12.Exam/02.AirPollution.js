function solve(sofiaMap, forces) {
    let matrix = [];
    for(let row of sofiaMap) {
        let parsedRow = [];
        parsedRow = row.split(' ').map(Number);
        matrix.push(parsedRow);
    }

    for(let forceToParse of forces) {
        let [force, indexOrValue] = forceToParse.split(' ');
        indexOrValue = Number(indexOrValue);

        if(force === 'breeze') {
            breeze(matrix, indexOrValue);
        } else if(force === 'gale') {
            gale(matrix, indexOrValue);
        } else {
            smog(matrix, indexOrValue);
        }
    }

    let result = [];

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            if(matrix[i][j] >= 50) {
                result.push(`[${i}-${j}]`);
            }
        }
    }

    if(result.length > 0) {
        console.log(`Polluted areas: ${result.join(', ')}`);
    } else {
        console.log(`No polluted areas`);
    }

    //console.log(matrix);

    function breeze(matrix, index) {
        for (let i = 0; i < matrix[index].length; i++) {
            let currentValue = matrix[index][i];

            currentValue -= 15;
            if(currentValue < 0) {
                currentValue = 0;
            }

            matrix[index][i] = currentValue;
        }
    }

    function gale(matrix, index) {
        for (let i = 0; i < matrix.length; i++) {
            let currentValue = matrix[i][index];

            currentValue -= 20;
            if(currentValue < 0) {
                currentValue = 0;
            }

            matrix[i][index] = currentValue;

        }
    }

    function smog(matrx, value) {
        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix[i].length; j++) {
                matrix[i][j] += value;
            }
        }
    }
}

solve(
    [
        "5 7 3 28 32",
        "41 12 49 30 33",
        "3 16 20 42 12",
        "2 20 10 39 14",
        "7 34 4 27 24",
    ],
    [
        "smog 11", "gale 3",
        "breeze 1", "smog 2"
    ]
);