Use prefix and postfix

- prefix (from left to right, [1, nums.length-1])  
  prefix[i] = prefix[i-1] * nums[i-1]
- suffix (from right to left, [0, nums.length-2])
  suffix[i] = suffix[i+1] * nums[i+1]

So we have the result before the element and after the element,
then prefix[i] * postfix[i] = result

<img height="500" src="https://i.gyazo.com/878fb92cea3f57f614be429c50d9ccdc.png" width="300"/>
