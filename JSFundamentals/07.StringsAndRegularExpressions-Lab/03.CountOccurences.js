function solve(searchStr, text) {
    let count = 0;
    let index = text.indexOf(searchStr, 0);

    while (index !== -1){
        count++;
        index = text.indexOf(searchStr, index + 1);
    }

    console.log(count);
}

solve('the', 'The quick brown fox jumps over the lay dog.');