function solve(text, tokens) {
    for (let i = 0; i < tokens.length; i++) {
        let currentWord = tokens[i];
        let index = text.indexOf(currentWord, 0);

        while (index !== -1) {
            text = text.replace(currentWord, '-'.repeat(currentWord.length));
            index = text.indexOf(currentWord, index + currentWord.length);
        }
    }
    console.log(text);
}