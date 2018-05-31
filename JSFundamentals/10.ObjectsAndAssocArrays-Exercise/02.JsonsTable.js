function solve(input) {
    let result = "<table>\n";
    for (let i = 0; i < input.length; i++) {
        let currentEmployee = JSON.parse(input[i]);
        result += "	<tr>\n";
        result += `		<td>${escapeHTML(currentEmployee.name)}</td>\n`;
        result += `		<td>${escapeHTML(currentEmployee.position)}</td>\n`;
        result += `		<td>${currentEmployee.salary}</td>\n`;
        result += "	<tr>\n";
    }

    result += "</table>\n";

    return result;

    function escapeHTML(text) {
        let map = {
            '"': '&quot;',
            '&': '&amp;',
            "'": '&#39;',
            '<': '&lt;',
            '>': '&gt;',
        };

        return text.replace(/[\\"&'<>]/g, c => map[c]);
    }
}

console.log(solve([
    '{"name":"Pesho","position":"Promenliva","salary":100000}',
    '{"name":"Teo","position":"Lecturer","salary":1000}',
    '{"name":"Georgi","position":"Lecturer","salary":1000}'
]));