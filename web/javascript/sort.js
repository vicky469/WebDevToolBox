// sort in-place
const arr = [3, 1, 5, 2, 4];
const sortedInPlace = arr.sort((a, b) => a - b);
sortedInPlace;
arr;

// sort return a new array
const sortedArr = arr.slice().sort((a, b) => b - a);
sortedArr;
arr;
