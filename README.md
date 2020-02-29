# Greatest_Common_Divisor
Finding the Greatest Common Divisor (GCD) of two integers, as explored by Euclid:  
https://en.wikipedia.org/wiki/Euclidean_algorithm  

Quoting from Wikipedia:  
_"It can be used to reduce fractions to their simplest form, and is a part of many other number-theoretic and cryptographic calculations. The Euclidean algorithm is based on the principle that the greatest common divisor of two numbers does not change if the larger number is replaced by its difference with the smaller number."_  

So note the recursive structure here, upon which this algorithm relies. Note that if the two numbers 'a' and 'b' are large, and very different, then it could lead to too many steps of recursion, and so it might 'smash the stack' during the programme run, and lead to a stack exception. If you have this problem, then you probably need to investigate more efficient GCD algorithms, which do exist.

Note that this algorithm was tested for a few cases against the existing algorithm in the Python math library, which is used like this, for example:  
```
>>> import math
>>> math.gcd(35, 21)
7
```

A typical output from our own C# (.NET) implementation of Euclid's algorithm looks something like this:
```
Euclid's algorithm for calculating the Greatest Common Divisor (GCD) of two integers
====================================================================================
Enter first integer:
35
The first integer you chose was: 35

Enter second integer:
21
The second integer you chose was: 21

We will now execute the recursive steps of Euclid's GCD algorithm...
a = 35, b = 21
a = 14, b = 21
a = 7, b = 14
a = 7, b = 7
a and b are now equal, with a value of 7

The Greatest Common Divisor of 35 and 21 is 7

Press any key to exit...
```
