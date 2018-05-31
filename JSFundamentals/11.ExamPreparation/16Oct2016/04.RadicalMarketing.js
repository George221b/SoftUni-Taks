function solve(arr) {

    let record = new Map();

    for (let i = 0; i < arr.length; i++) {

        let tokens = arr[i].split('-');

        if (tokens.length === 1) {
            let toRegister = tokens[0];
            if (!record.has(toRegister)) {
                record.set(toRegister, {subscriberOf: [], subscribers: []});
            }
        } else if (tokens.length === 2) {
            let [subscriberOf, someone] = tokens;

            if (record.has(subscriberOf) && record.has(someone)){
                record.get(someone).subscribers.push(subscriberOf);
                record.get(subscriberOf).subscriberOf.push(someone);
            }
        }
    }

    record = [...record].sort((a, b) => {
        if (b[1].subscribers.length < a[1].subscribers.length) return -1;
        if (b[1].subscribers.length > a[1].subscribers.length) return 1;
        if (b[1].subscriberOf.length < a[1].subscriberOf.length) return -1;
        if (b[1].subscriberOf.length > a[1].subscriberOf.length) return 1;
    });

    for (let [person, data] of record) {
        console.log(person);

        let count = 1;
        for (let subs of data.subscribers) {
            console.log(`${count}. ${subs}`);
            count++;
        }
        return;
    }
}

solve([
    'J',
    'G',
    'P',
    'R',
    'C',
    'J-G',
    'G-J',
    'P-R',
    'R-P',
    'C-J',
    'C-P',
    'J-R'
]);