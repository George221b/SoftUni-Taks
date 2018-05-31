function solve(input) {
    return input.split(" ")
        .map(x => x.toLowerCase())
        .map(x => `${x[0].toUpperCase()}${x.substring(1)}`)
        .join(" ");
}

console.log(solve("Was that Easy? tRY thIs onE for SiZe!"));