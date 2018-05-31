function solve(string, ending) {
    return string.substring(string.length - ending.length, string.length)
    === ending ? "true" : "false";
}

console.log(solve("This sentence ends with fun?", "fun?"));