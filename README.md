# QuestionsWithCSharpSolutions
The solution file name is the questionName.cs  
The test files names are the solutionFileNmameTest.cs  
The txt files are the input file and output file of Question2 Safest place in the galaxy  

The format is bit strange on git. It looks good on my Mac. Don't know why it changed after the pushing. 

All the files are excuatable. Feel free to run. Enjoy :)  

# Questions
The Safest Place In The Galaxy is the answer of Facebook Hacker Cup 2011 Final's question. The question is below. 

While en route to the 295th annual Galactic Dance Party on Risa, you find yourself unceremoniously yanked out of hyperspace and, according to your sensors, surrounded by N space bombs.  Apparently caught in a trap laid out by some dastardly and unknown enemy, and unable to return to hyperspace, you must find the safest place in the vicinity to weather the detonation of all the space bombs.  Your unseen opponent has constructed a cube-shaped space anomaly that you are unable to leave, so your options are limited to points within that cube.
 
Before the bombs explode (all simultaneously), you have just enough time to travel to any integer point in the cube [0, 0, 0]-[1000, 1000, 1000], both inclusive.  You must find the point with the maximum distance to the nearest bomb, which your captain's intuition tells you will be the safest point.
 
Input
The first line of the input file consists of a single number T, the number of test cases. Each test consists of single number N, the number of bombs, followed by 3*N integers describing the positions of the bombs.
 
Output
Output T integers, one per test case each on its own line, representing the square of distance to the nearest bomb from the safest point in the cube.
 
Constraints
T = 50
1 N 
All bombs coordinates will be in [0, 1000], both inclusive.
