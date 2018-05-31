function solution(strArr) {
    let n = strArr[strArr.length - 1] * 1;
    for (let i = 0; i < strArr.length - 1; i += n) {
        console.log(strArr[i]);
    }
}