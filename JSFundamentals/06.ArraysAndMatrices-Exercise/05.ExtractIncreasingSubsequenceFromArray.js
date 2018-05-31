function solution(numArr) {
    let resArr = [];
    let biggest = Number.NEGATIVE_INFINITY;
    for (let i = 0; i < numArr.length; i++) {
        if (numArr[i] >= biggest) {
            biggest = numArr[i];
            resArr.push(biggest);
        }
    }
    console.log(resArr.join("\n"));
}