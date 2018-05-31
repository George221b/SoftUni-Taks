function solve(commands) {
    let commandProcessor = (function () {
        let result = '';
        return {
            append: (str) => result += str,
            removeStart: (n) => result = result.slice(Number(n)),
            removeEnd: (n) => result = result.slice(0, result.length - Number(n)),
            print: () => console.log(result)
        }
    })();

    for (let cmd of commands) {
        let [cmdName, arg] = cmd.split(' ');
        commandProcessor[cmdName](arg);
    }
}