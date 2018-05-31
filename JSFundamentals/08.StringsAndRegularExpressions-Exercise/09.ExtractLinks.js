function solve(str) {
    const regex = /(www\.)([A-Za-z0-9-]+)(\.[a-z]+)+/g;
    let match = regex.exec(str);

    while (match) {
        console.log(match[0]);

        match = regex.exec(str);
    }
}

solve([
"Join WebStars now for free, at www.web-stars.com",
"You can also support our partners:",
"Internet - www.internet.com",
"WebSpiders - www.webspiders101.com",
"Sentinel - www.sentinel.-ko"
]);