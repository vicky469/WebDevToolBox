// schedule a function to be called repeatedly at a specified interval.
let count = 0;
const intervalId = setInterval(() => {
    count += 1;
    console.log(`This is interval count: ${count}`);
    if (count >= 5) {
        clearInterval(intervalId);
    }
}, 1000);