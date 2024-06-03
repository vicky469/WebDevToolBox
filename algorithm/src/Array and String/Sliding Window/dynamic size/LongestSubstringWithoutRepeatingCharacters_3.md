At high level, we want to maintain the window to contain unique elements only, when we add element in the set, update the maxLen.

1. If the set does not contain s[end], it means the character is unique within the current window.
   - add it to the set
   - update the maxLen if the current window size (end - start + 1) is larger
   - end++

2. If the set contains s[end]
   - shrink the window from the left until the duplicate character is removed.
   - start ++

![](https://i.gyazo.com/337c36a9719883053098e4b8b0f528ad.png)