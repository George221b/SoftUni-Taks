function printArrayWithGivenDelimiter(strArr) {
    let delimiter = strArr[strArr.length - 1];
    strArr.pop();
    console.log(strArr.join(delimiter));
}