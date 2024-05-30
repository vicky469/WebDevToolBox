# Computer Hardware

The physical elements of a computer.

### circuit board vs computer

- Circuit Board
    - Fixed purpose device  
      The circuits with logic gates have a set of features hard-wired into the design.  
      If we want to add or modify the feature, we have to change the physical design of our circuit.
- Computer  
  A computer must be able to perform new tasks without changing hardware. It needs to add programmability. To accomplish this, a computer must be able to accept a set of instructions (a program) and perform the actions specified in those instructions.

Most processors today are microprocessors, CPUs are on a single integrated circuit.


### Three parts of a computer

1. Main Memory / RAM (random access memory)
2. CPU (central processing unit) / processor  
   carries instructions specified in software  
   have direct access to RAM
3. input/output (I/O) devices
<img src="https://i.gyazo.com/aff8f85c72496e98cb86509a7bad2863.png"/>

#### 1. Main Memory / RAM (random access memory)
<img src="https://i.gyazo.com/0e35f2d4e3e1659fe60ee36b88a80c5d.png"/>

- Stores instructions/programs and related data.
    - For example, when a computer runs a word processor for editing documents, the computer needs a place to hold the program itself, the contents of the document, and the state of editing—what part of the document is visible, the location of the cursor, and so forth.
    - All of this data is ultimately a series of bits that the CPU needs to be able to access. 
    - Main memory handles the task of storing these 1s and 0s.
- Think of RAM as a large apartment building with many mailboxes.
    - Each mailbox represents a memory cell which can hold a single byte of data.
      - Each memory cell has a unique address (apartment number).
    - The CPU can read or write to any mailbox by specifying the number of that mailbox.
- Memory Address
    - Each byte in memory has a unique address.
    - The CPU can read or write to any byte in memory by specifying the address of that byte.
<img src="https://i.gyazo.com/522e3c855cb809630136b8d474325c48.png"/>





#### References:
- [How Computers Really Work](https://learning.oreilly.com/library/view/how-computers-really/9781098128227/xhtml/ch07.xhtml#lev1_45) by Matthew Justice