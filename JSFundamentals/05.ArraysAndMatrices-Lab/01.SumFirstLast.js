function sumFirstLast(arr) {
    let arrAsNums = arr.map(s => Number(s));
    return arrAsNums[0] + arrAsNums[arrAsNums.length - 1];
}

console.log(sumFirstLast(['20', '30', '40']));