 
par(x) :- x mod 2 == 0.

tiene('juan','bicicleta').
tiene('juan', 'coche').
tiene('ana','libro').
tiene('ana', 'coche').

cuadrado(X,R):- R is X*X.
   
media(A,B,M):- M is (A+B)/2.
factorial(0,1).
factorial(N,R):-
    N1 is N -1,
    factorial(N1,R1),
    R is N* R1.

/**
 par(10),
tiene(juan,X),tiene(ana,X),
cuadrado(2,R),
media(2,3,M),
factorial(3,R).
 * /