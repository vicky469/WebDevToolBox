p = {1,null,2,3};  
q = {1,null,2,null,3};

<img width="500" height="500" src="https://i.gyazo.com/683f4d2e8d3671b60fef868cbc200d4f.png"/>


```
PUSH p: 1, q: 1
POP p: 1, q: 1

PUSH p: 2, q: 2
PUSH p: , q: 
POP p: , q: 
POP p: 2, q: 2

PUSH p: , q: 3
PUSH p: 3, q: 
POP p: 3, q:
```

