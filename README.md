Introduction:

One of the most stunning and well-known mathematical images of all time is the Mandelbrot set, named after mathematician Benoit Mandelbrot, who contributed greatly to its study. 
 
Mandelbrot set:

Mandelbrot set is a property of complex numbers through which multiple iterations of a seed complex number(Z0), provided with a constant(C) generates fractal patterns on an argand diagram.

Julia set:

Julia set is an extension of Mandelbrot set, such that instead of keeping the seed complex number Z0  (0,0) , we can vary it generating a number of different fractal patterns, the colour of which represents the degree of instability of the formed patterns within a given boundary. Julia set gives a boundary for a given constant complex number C in which the iterations give a converging output, while assigning colour based on the degree of divergence.

Algorithm:

The mandelbrot set is defined by the set of complex numbers C for which the complex numbers of the sequence Zn remain bounded in absolute value. The sequence Zn is defined by:
These complex converge when in the boundary of Mandelbrot set, while diverge indefinitely when the complex number C leaves exits the boundary, the degree of divergence is plotted in terms of the hue

•	Z0=0
•	Zn+1=Zn2 + C

The colours are assigned to pixels in the application based on the complexity of the terations, if it is too divergent it is darker, while if it convergent it bright( white ). The colour assigned on divergence on the basis of iterations gives us different beautiful patterns.

Instructions:

The application is ready to use, just change the path of the database and path of saving the image according to your own personal drive where the repository is cloned.
zoom in and out to see the patterns, save the desired patterns as images or coordinates for future exploration. 
increasing the number of iterations gives a clearer image.

