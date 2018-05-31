function solve(string, delimeter) {
    return string.split(delimeter).join("\n");
}

console.log(solve('http://platform.softuni.bg', '.'));