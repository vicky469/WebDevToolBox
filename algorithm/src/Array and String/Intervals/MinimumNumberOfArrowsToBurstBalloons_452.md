0. Corner case check, if len(points) == 0, return 0
1. Sort by end point
<img src="https://i.gyazo.com/9ee44aaffbc5d07b7801ac433b60a583.png"/>
2. Initialize the arrow count to 1, and the end point of the arrow to the end point of the first balloon
3. If the current balloon can be burst by the current arrow shot, continue  
    else, arrows += 1, and update the end point of the arrow
<img src="https://i.gyazo.com/842b00a5e47e0ec03a03720efa6360e7.png"/>
