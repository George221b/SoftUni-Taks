function solution(strArr) {
    let sortedArr = strArr
        .sort()
        .sort((s1, s2) => s1.length > s2.length);
    console.log(sortedArr.join("\n"));
}