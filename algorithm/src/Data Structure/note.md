# Stack
### Use Cases
1. Control Z - Undo  
   Control Y - Redo
2. Backtracking algorithms
3. Syntax parsing
4. Check proper nesting of parenthesis

### Design Data Structure
Stack ADT
 
Push(element) => add an element to the top of the stack  
Pop() => remove the top element from the stack  
Peek() => return the top element from the stack
IsEmpty() => return true if the stack is empty  

A stack can be created using any collection. 
<img src="https://i.gyazo.com/5188862e58fb9f40e715066708037125.jpg" height="200" width="400"/>  

---
# Queue
### Use Cases
Task queue

### Design Data Structure
Queue ADT

Enqueue(element)     => add an element to the top of the stack  
Dequeue()            => remove the top element from the stack  
Peek()               => return the top element from the stack
IsEmpty()            => return true if the stack is empty 

### What is Abstract Data Type (ADT)?  
An Abstract Data Type (ADT) is a high-level description of a collection of data and the operations that can be performed on that data. It describes what a data type does, but not how it does it.  
ADTs are defined by their behavior, such as how they are created, manipulated, and used. For example, a stack ADT might define operations such as push, pop, and peek, but it doesn't specify how these operations are implemented. The implementation could be done using an array, a linked list, or any other data structure.  
Examples include `stacks`, `queues`, `linked lists`, `trees`, `graphs`, and `hash tables`.  
Alternative to ADTs are Data Structures.

|                                                                          | Data Structures                  | ADTs                                                    |
|--------------------------------------------------------------------------|----------------------------------|---------------------------------------------------------|
| Collection contains:                                                     |                                  | defined by its behavior from the view of the user       |
|                                                                          | - data values                    | describe only what needs to be done, not how it is done |
|                                                                          | - relationships among the data   |                                                         |
|                                                                          | - operations applied to the data | -  what operations must it have?                        |
| describes exactly how the data are organized and how tasks are performed |                                  |                                                         |
| Example:                                                                 | Array List                       | List                                                    |

<img height="150" src="https://i.gyazo.com/d130f433807eebb0f64dcdbff274542f.png" title="https://stepik.org/lesson/28870/step/4?unit=9957" width="400"/>

----
## Deque 
(Double-Ended Queue, pronounced "deck")   
A deque (double-ended queue) is a data structure that allows elements to be added or removed from both the front and the back. It is similar to a queue, but with the added flexibility of being able to add or remove elements from both ends.

<img height="120" src="https://media.geeksforgeeks.org/wp-content/uploads/20220817115055/doubleended-660x180.jpg" width="400"/>



References  
[1] https://stepik.org/lesson/28872/step/3?unit=9909  
[2] https://www.geeksforgeeks.org/difference-between-queue-and-deque-queue-vs-deque/   





