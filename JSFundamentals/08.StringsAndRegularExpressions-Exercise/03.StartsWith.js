function solve(input, start) {
    return input.substring(0, start.length) === start ? "true" : "false";
}

console.log(solve("How have you been?", "how"));