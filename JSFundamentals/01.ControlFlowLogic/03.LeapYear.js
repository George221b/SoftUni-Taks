function isLeapYear(year) {
    let result = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    return result ? "yes" : "no";
}

console.log(isLeapYear(2000));