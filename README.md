# MonteCarlo
By generating many random values, you can estimate the result of complicated mathematical equations via a 
technique known as the Monte Carlo method. You can estimate the value of π using a Monte-Carlo method.

Envision a unit circle (radius = 1). 
Specifically, we will work with the top right quadrant where all valid points are between { x = 0, y = 0 } and { x = 1, y = 1 }. 
By randomly generating many x, y pairs and calculating the length of the hypotenuse of a triangle 
with sides of length x, y using the Pythagorean theorem, hypotenuse=√(x^2+y^2 ), 
you can classify the pairs into those that overlap the unit circle (hypotenuse<= 1, blue shaded area) 
and those that fall outside the unit circle (hypotenuse>1, red shaded area). 

The ratio of pairs that overlap the unit circle divided by the total number of pairs generated 
is the area of the unit circle in the top right quadrant.
