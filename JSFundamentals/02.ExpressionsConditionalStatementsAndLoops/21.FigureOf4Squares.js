function figureOfSquares(n) {
    let output = "";

    function drawStartOrEnd(n) {
        let cols = n - 3 + 1;
        output += '+';

        for (let i = 0; i < 2; i++) {
            output += '-'.repeat(cols);
            output += '+';
        }

        output += "\n";
    }

    function drawMiddleLine(n) {
        let cols = n - 3 + 1;
        output += '|';

        for (let i = 0; i < 2; i++) {
            output += ' '.repeat(cols);
            output += '|';
        }

        output += "\n";
    }

    drawStartOrEnd(n);
    let innerPartLines = n % 2 == 0 ? n - 4 : n - 3;

    if (innerPartLines > 0) {
        for (let i = 0; i < innerPartLines / 2; i++) {
            drawMiddleLine(n);
        }
        drawStartOrEnd(n);
        for (let i = 0; i < innerPartLines / 2; i++) {
            drawMiddleLine(n);
        }
    }
    else {
        drawStartOrEnd(n);
    }

    drawStartOrEnd(n);

    return output;
}

console.log(figureOfSquares(7));