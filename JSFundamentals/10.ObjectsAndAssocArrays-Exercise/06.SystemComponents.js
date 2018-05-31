function solve(input) {
    let dict = new Map();

    for(let row of input) {
        let [system, component, subcomponent] = row.split(" | ").filter(x => x !== "");

        if(!dict.has(system)) {
            dict.set(system, new Map());
        }
        if(!dict.get(system).has(component)) {
            dict.get(system).set(component, []);
        }

        let olds = dict.get(system).get(component);
        olds.push(subcomponent);

        dict.get(system).set(component, olds);
    }

    for(let [system, componentTokens] of [...dict]
        .sort(function (a, b) {
            if (a[1].size > b[1].size) return -1;
            if (a[1].size < b[1].size) return 1;
            if(a[0].toLowerCase() < b[0].toLowerCase()) return -1;
            if(a[0].toLowerCase() > b[0].toLowerCase()) return 1;
            return 0;
        })) {
        console.log(system);

        for(let [component, subcomponents] of [...componentTokens]
            .sort(function (a, b) {
                if(a[1].length > b[1].length) return -1;
                if(a[1].length < b[1].length) return 1;
                return 0
            })) {
            console.log(`|||${component}`);
            console.log(`${subcomponents.map(sc => `||||||${sc}`).join("\n")}`);
        }
    }
}

solve([
    "SULS | Main Site | Home Page",
    "SULS | Main Site | Login Page",
    "SULS | Main Site | Register Page",
    "SULS | Judge Site | Login Page",
    "SULS | Judge Site | Submittion Page",
    "Lambda | CoreA | A23",
    "SULS | Digital Site | Login Page",
    "Lambda | CoreB | B24",
    "Lambda | CoreA | A24",
    "Lambda | CoreA | A25",
    "Lambda | CoreC | C4",
    "Indice | Session | Default Storage",
    "Indice | Session | Default Security"
]);