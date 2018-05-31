function solve(strArr) {
    let rx = /\d+/g;
    let result=strArr.join(' ');
    let resArr = result.match(rx).join(' ');
    console.log(resArr);
}

solve([
    'The300',
    'What is that?',
    'I think it’s the 3rd movie.',
    'Lets watch it at 22:45'
]);