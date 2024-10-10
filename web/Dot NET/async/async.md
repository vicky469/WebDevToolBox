### Asynchronous
Can have asynchrony without concurrency.

Asynchrony allows tasks to be paused and resumed.
<img src="https://i.gyazo.com/a4748bd9497eb9700eb9abcd0e948fb7.png" alt="Description of the image">  
queueing up tasks to run back on the very place they were called from. It is asynchronous invocation but not necessarily concurrency.

---
### Concurrency
Can't have concurrency without asynchrony.

Concurrency involves multiple tasks making progress simultaneously, which inherently requires asynchrony to manage the execution of these tasks without blocking each other.
<img src="https://i.gyazo.com/1bd5a4d7ee3865521bb5e1d6e8a7c4d8.png" alt="Description of the image">  
Line 5 and 7 are running at the same time.

