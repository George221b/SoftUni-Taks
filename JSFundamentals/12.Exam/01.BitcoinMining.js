function solve(input) {
    let gramsPerDay = input.map(Number);
    let money = 0;
    let bitcoins = 0;
    let isBought = false;
    let dayOfFirstPurchase = 0;

    const moneyForBitcoin = 11949.16;
    const moneyPerGramGold = 67.51;


    for (let i = 0; i < gramsPerDay.length; i++) {
        if((i + 1) % 3 == 0) {
            let gold = gramsPerDay[i] * 0.7;
            money += gold * moneyPerGramGold;
        }
        else {
            money += gramsPerDay[i] * moneyPerGramGold;
        }

        if(money >= moneyForBitcoin) {
            if (isBought == false) {
                isBought = true;
                dayOfFirstPurchase = i + 1;
            }
            while(money >= moneyForBitcoin) {
                money -= moneyForBitcoin;
                bitcoins += 1;
            }
        }
    }

    console.log(`Bought bitcoins: ${bitcoins}`);
    if(isBought == true) {
        console.log(`Day of the first purchased bitcoin: ${dayOfFirstPurchase}`)
    }
    console.log(`Left money: ${money.toFixed(2)} lv.`)
}

solve([
    '3124.15', '504.212', '2511.124'
]);