function solve(base, increment) {
    base = Number(base);
    increment = Number(increment);

    let step = 0;
    let stone = 0;
    let marble = 0;
    let lapis = 0;
    let gold = 0;

    for(let i = base; i >= 1; i-=2) {
        step++;
        if (i <= 2) {
            gold += (i ** 2) * increment;

            continue;
        }

        stone += (i - 2) * (i - 2) * increment;

        if (step % 5 == 0) {
            lapis += ((4 * i) - 4) * increment;
            continue;
        }

        marble += ((4 * i) - 4) * increment;
    }

    console.log(`
Stone required: ${Math.ceil(stone)}
Marble required: ${Math.ceil(marble)}
Lapis Lazuli required: ${Math.ceil(lapis)}
Gold required: ${Math.ceil(gold)}
Final pyramid height: ${Math.floor(step * increment)}
`);
}

solve(12, 1);