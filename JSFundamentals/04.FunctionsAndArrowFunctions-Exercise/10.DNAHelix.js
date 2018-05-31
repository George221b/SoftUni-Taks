function dnaHelix(length) {
    const dnaSequence = "ATCGTTAGGG";

    let currentDna = 0;

    let structure = [
            "**{{{x}}}{{{y}}}**",
            "*{{{x}}}--{{{y}}}*",
            "{{{x}}}----{{{y}}}",
            "*{{{x}}}--{{{y}}}*"
        ];

    for (let i = 0; i < length; i++) {
        let currentLine = structure[i % structure.length];
        let letterX = dnaSequence[currentDna % dnaSequence.length];
        currentDna++;
        let letterY = dnaSequence[currentDna % dnaSequence.length];
        currentDna++;
        
        currentLine = currentLine.replace("{{{x}}}", letterX);
        currentLine = currentLine.replace("{{{y}}}", letterY);

        console.log(currentLine);
    }
}

dnaHelix(10);