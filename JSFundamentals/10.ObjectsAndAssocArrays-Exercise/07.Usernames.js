function solve(input) {
    let users = new Set();

    for(user of input) {
        users.add(user);
    }

    console.log([...users].sort(function (a, b) {
        if(a.length > b.length) return 1;
        if(a.length < b.length) return -1;
        if(a < b) return -1;
        if(a > b) return 1;
        return 0;
    }).join("\n"));
}

solve([
    'Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
]);