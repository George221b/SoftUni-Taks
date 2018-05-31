function boxesNeeded(bottles, boxCapacity) {
    return Math.ceil(bottles / boxCapacity);
}

console.log(boxesNeeded(5, 10));