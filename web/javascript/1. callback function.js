const startTime = new Date();
const message = function() {  
    const endTime = new Date();
    const duration = endTime - startTime;
    console.log(`This message is shown after ${duration} milliseconds`);
}

setTimeout(message, 3000);

// Callback as an anonymous function
setTimeout(function() {  
    console.log("This message is shown after 3 seconds");
}, 3000);


// Callback as an Arrow Function
setTimeout(() => { 
    console.log("This message is shown after 3 seconds");
}, 3000);