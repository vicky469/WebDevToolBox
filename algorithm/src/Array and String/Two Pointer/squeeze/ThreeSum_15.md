### How can we reduce this problem to a two sum problem?
Target is 0 and input array is sorted.  
For the sum of three numbers to equal zero, the first number must be negative if we want to add two more numbers later.  

### Visual
sum == -nums[i]
![image](https://i.gyazo.com/f773bdb1108152c38c914d6aa39f0daf.png)  
sum < -nums[i]
![image](https://i.gyazo.com/29ff91567eb8195d9b52048fc14d8cee.png)  
sum > -nums[i]
![image](https://i.gyazo.com/def91b710d954f05a47dede0426f74cb.png)  
