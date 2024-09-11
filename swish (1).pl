 
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

fibonacci(0,1).
fibonacci(1,1).
fibonacci(N,R):-
    N1 is N-1,
    N2 is N-2,
    fibonacci(N1,R1),
    fibonacci(N2,R2),
    R is R1 + R2.

mcd(X,0,X).
mcd(X,Y,M):-
    X1 is X mod Y,
    mcd(Y,X1,M).

poblacion('Francia',60000000).
poblacion('España', 45000000).
area('Francia', 640000).
area('España',505000).
densidad(Pais,D):-
    poblacion(Pais,P),
    area(Pais,A),
    D is P / A.

/***
 * par(10),
tiene(juan,X),tiene(ana,X),
cuadrado(2,R),
media(2,3,M),
factorial(3,R),
fibonacci(5,R),
mcd(12,18,R),
mcd(18,12,R),
densidad('Francia',D),
densidad('España',D).
 * */