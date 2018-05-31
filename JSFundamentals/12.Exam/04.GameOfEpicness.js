function solve(all, battles) {
    let kingdoms = new Map();
    let winners = new Map();

    for (let row of all) {
        let kingdom = row.kingdom;
        let general = row.general;
        let army = Number(row.army);

        if (!kingdoms.has(kingdom)) {
            kingdoms.set(kingdom, new Map());
            winners.set(kingdom, new Map());
        }
        if (!kingdoms.get(kingdom).has(general)) {
            kingdoms.get(kingdom).set(general, 0);
            winners.get(kingdom).set(general, [0, 0]);
        }

        let currentArmy = kingdoms.get(kingdom).get(general);

        kingdoms.get(kingdom).set(general, currentArmy + army);
    }

    for (let i = 0; i < battles.length; i++) {
        let [attackingKingdom, attackingGeneral, defendingKingdom, defendingGeneral]
            = [battles[i][0], battles[i][1], battles[i][2], battles[i][3]];

        if (attackingKingdom === defendingKingdom) {
            continue;
        }

        let attackerArmy = kingdoms.get(attackingKingdom).get(attackingGeneral);
        let defenderArmy = kingdoms.get(defendingKingdom).get(defendingGeneral);

        if (attackerArmy > defenderArmy) {
            attackerArmy = Math.floor(attackerArmy * 1.1);
            defenderArmy = Math.floor(defenderArmy * 0.9);

            kingdoms.get(attackingKingdom).set(attackingGeneral, attackerArmy);
            kingdoms.get(defendingKingdom).set(defendingGeneral, defenderArmy);

            winners.get(attackingKingdom).get(attackingGeneral)[0]++;
            winners.get(defendingKingdom).get(defendingGeneral)[1]++;
        }
        else if (attackerArmy < defenderArmy) {
            attackerArmy = Math.floor(attackerArmy * 0.9);
            defenderArmy = Math.floor(defenderArmy * 1.1);

            kingdoms.get(attackingKingdom).set(attackingGeneral, attackerArmy);
            kingdoms.get(defendingKingdom).set(defendingGeneral, defenderArmy);

            winners.get(defendingKingdom).get(defendingGeneral)[0]++;
            winners.get(attackingKingdom).get(attackingGeneral)[1]++;
        }
    }

    let win = [...winners]
        .sort(function (a, b) {
            let first = [...a];
            let generalFirst = first[0];
            let winsFirst = [...first[1]][0];
            let wins = winsFirst[1][0];
            let losses = winsFirst[1][1];
            let kingdom = a[0];

            let second = [...b];
            let generalSecond = second[0];
            let winsSecond = [...second[1]][0];
            let winsS = winsSecond[1][0];
            let lossesS = winsSecond[1][1];
            let kingdomS = b[0];

            if(wins === winsS) {
                if(lossesS === losses) {
                    return (kingdom < kingdomS) ? -1 : (kingdom > kingdomS) ? 1 : 0;
                }
                return losses - lossesS;
            }

            return winsS - wins;
        })[0];


    let winnerKingdom = win[0];
    console.log(`Winner: ${winnerKingdom}`);

    let winnersGenerals = new Map();

    for(let [winnerGeneral, winsLosses] of [...win[1]]) {
        let winnerArmy = kingdoms.get(winnerKingdom).get(winnerGeneral);
        winnersGenerals.set(winnerGeneral, [winnerArmy, winsLosses[0], winsLosses[1]]);
    }


    for (let [general, armyWinsLosses] of [...winnersGenerals].sort(
        function (a, b) {
            let armyA = a[1][0];
            let armyB = b[1][0];

            return armyB - armyA;
        }
    )) {
        console.log(`/\\general: ${general}`);
        console.log(`---army: ${armyWinsLosses[0]}`);
        console.log(`---wins: ${armyWinsLosses[1]}`);
        console.log(`---losses: ${armyWinsLosses[2]}`);
    }

}

solve(
    [{kingdom: "Maiden Way", general: "Merek", army: 5000},
        {kingdom: "Stonegate", general: "Ulric", army: 4900},
        {kingdom: "Stonegate", general: "Doran", army: 70000},
        {kingdom: "YorkenShire", general: "Quinn", army: 0},
        {kingdom: "YorkenShire", general: "Quinn", army: 2000},
        {kingdom: "Maiden Way", general: "Berinon", army: 100000}],
    [["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Stonegate", "Ulric", "Stonegate", "Doran"],
        ["Stonegate", "Doran", "Maiden Way", "Merek"],
        ["Stonegate", "Ulric", "Maiden Way", "Merek"],
        ["Maiden Way", "Berinon", "Stonegate", "Ulric"]]
);