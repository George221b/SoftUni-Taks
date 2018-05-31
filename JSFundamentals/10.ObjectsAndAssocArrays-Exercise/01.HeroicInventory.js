function solve(input) {
    let heroData = [];

    for (let i = 0; i < input.length; i++) {
        let inputTokens = input[i].split(' / ').filter(x => x !== "");
        let heroItems = inputTokens[2] == undefined ? [] : inputTokens[2].split(', ');
        let currentHero = {
            name: inputTokens[0],
            level: Number(inputTokens[1]),
            items: heroItems
        };

        heroData.push(currentHero);
    }

    return JSON.stringify(heroData);
}

console.log(solve([
    "Isacc / 25 / ",
    "Derek / 12 / BarrelVest, DestructionSword",
    "Hes / 1 / Desolator, Sentinel, Antara"
]));