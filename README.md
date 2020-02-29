# Greatest_Common_Divisor
Finding the Greatest Common Divisor (GCD) of two integers, as explored by Euclid:  
https://en.wikipedia.org/wiki/Euclidean_algorithm  

Quoting from Wikipedia:  
_"It can be used to reduce fractions to their simplest form, and is a part of many other number-theoretic and cryptographic calculations. The Euclidean algorithm is based on the principle that the greatest common divisor of two numbers does not change if the larger number is replaced by its difference with the smaller number."_  

So note the recursive structure here, upon which this algorithm relies. Note that if a and b are large and very different then it can lead to too many steps of recursion, and so it will 'smash the stack' during the programme run, and lead to a stack exception. If you have this problem, then you probably need to investigate more efficient GCD algorithms, which do exist.

Note that this algorithm was tested for a few cases against the existing algorithm in the Python math library, which is used like this, for example:  
```
>>> import math
>>> math.gcd(24654, 7868)
14
```
