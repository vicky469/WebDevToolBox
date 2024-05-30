// function delayedPrint(number, delay) {
//     setTimeout(() => {
//         console.log(`Delayed print: ${number}`);
//     }, delay);
// }

// function newFunction() {
//     for (let i = 1; i <= 3; i++) {
//         console.log(`Before delayed print: ${i}`);
//         delayedPrint(i, i * 1000);
//         console.log(`Continue to run without blocking`);
//     }
// }

// newFunction();


function delayedPrint(number, delay) {
    return new Promise((resolve) => {
        setTimeout(() => {
            console.log(`Delayed print: ${number}`);
            resolve();
        }, delay);
    });
}

async function newFunction() {
    for (let i = 1; i <= 3; i++) {
        console.log(`Before delayed print: ${i}`);
        await delayedPrint(i, i * 3000);
        console.log(`After delayed print: ${i}`);
    }
}

newFunction();