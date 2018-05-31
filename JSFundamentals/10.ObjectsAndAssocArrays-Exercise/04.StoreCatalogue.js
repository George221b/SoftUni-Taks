function solve(input) {
    let catalogue = new Map();

    for(let i = 0; i < input.length; i++) {
        let [name, price] = input[i].split(" : ").filter(x => x != "");
        price = Number(price);
        let firstLetter = name.substring(0, 1);

        if(!catalogue.has(firstLetter)) {
            catalogue.set(firstLetter, new Map());
        }
        if(!catalogue.get(firstLetter).has(name)) {
            catalogue.get(firstLetter).set(name, 0);
        }

        let oldPrice = catalogue.get(firstLetter).get(name);

        catalogue.get(firstLetter).set(name, oldPrice + price);
    }

    for (let [entryLetter, products] of [...catalogue].sort()) {
        console.log(entryLetter)
        for(let [name, price] of [...products].sort()){
            console.log(`  ${name}: ${price}`)
        }
    }
}

solve([
"Appricot : 20.4",
"Fridge : 1500",
"TV : 1499",
"Deodorant : 10",
"Boiler : 300",
"Apple : 1.25",
"Anti-Bug Spray : 15",
"T-Shirt : 10"
]);