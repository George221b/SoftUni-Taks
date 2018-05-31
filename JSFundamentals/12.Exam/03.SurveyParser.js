function solve(input) {
    const svgRegex = /.*<svg>(.*)<\/svg>.*/g;

    let m;
    m = svgRegex.exec(input);

    if(m == null) {
        console.log("No survey found");
        return;
    }

    let str = m[1];

    const labelAndCatRegex = /<cat><text>.*?\[(.*)\]<\/text><\/cat>\s*<cat>((?:(?:.*?))+)<\/cat>/g;
    let m2 = labelAndCatRegex.exec(str);

    if(m2 == null) {
        console.log("Invalid format");
        return;
    }

    let label = m2[1];
    let catStr = m2[2];

    //console.log(label);
    //console.log(catStr);

    const catRegex = /<g><val>([1-9]|10)<\/val>([0-9]+)<\/g>/g;

    let m3;
    let sum = 0;
    let voteCount = 0;

    while ((m3 = catRegex.exec(catStr)) !== null) {
        if (m3.index === catRegex.lastIndex) {
            catRegex.lastIndex++;
        }

        let vote = Number(m3[2]);
        let value = Number(m3[1]);

        sum += vote * value;
        voteCount += vote;
    }

    let result = parseFloat((sum / voteCount).toFixed(2));

    console.log(`${label}: ${result}`);

}



let test1 = "<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>";
let test2 = "<svg><cat><text>How do you rate the special menu? [Food - Special]</text></cat> <cat><g><val>1</val>5</g><g><val>5</val>13</g><g><val>10</val>22</g></cat></svg>";
let test3 = "<svg><cat><text>Which is your favourite meal from our selection?</text></cat><cat><g><val>Fish</val>15</g><g><val>Prawns</val>31</g><g><val>Crab Langoon</val>12</g><g><val>Calamari</val>17</g></cat></svg>";

solve(test2);
