%tiempos verbales
tiempo(presente).
tiempo(pasado).
tiempo(futuro).
%personas gramaticales
persona(primera).
persona(segunda).
persona(tercera).
%números gramaticales
numero(singular).
numero(plural).
% deficinicion de la conjugacion del verbo to be
ser(presente, primera, singular, "am").
ser(presente, segunda, singular, "are").
ser(presente, tercer, singular, "is").
ser(presente, primera, plural, "are").
ser(presente, segunda, plural, "are").
ser(presente, tercera, plural, "are").

ser(pasado, primera, singular, "was").
ser(pasado, segunda, singular, "were").
ser(pasado, tercer, singular, "was").
ser(pasado, primera, plural, "were").
ser(pasado, segunda, plural, "were").
ser(pasado, tercera, plural, "were").

ser(futuro, primera, singular, "will be").
ser(futuro, segunda, singular, "will be").
ser(futuro, tercer, singular, "will be").
ser(futuro, primera, plural, "will be").
ser(futuro, segunda, plural, "will be").
ser(futuro, tercera, plural, "will be").

% deficinicion de la conjugacion del verbo comer
comer(presente, primera, singular, "eat").
comer(presente, segunda, singular, "eat").
comer(presente, tercer, singular, "eat").
comer(presente, primera, plural, "eat").
comer(presente, segunda, plural, "eat").
comer(presente, tercera, plural, "eat").

comer(pasado, primera, singular, "ate").
comer(pasado, segunda, singular, "ate").
comer(pasado, tercer, singular, "ate").
comer(pasado, primera, plural, "ate").
comer(pasado, segunda, plural, "ate").
comer(pasado, tercera, plural, "ate").

comer(futuro, primera, singular, "will eat").
comer(futuro, segunda, singular, "will eat").
comer(futuro, tercer, singular, "will eat").
comer(futuro, primera, plural, "will eat").
comer(futuro, segunda, plural, "will eat").
comer(futuro, tercera, plural, "will eat").

%conjuacion del verbo to be
conjugar_verbo(Verbo, Tiempo, Persona,Numero,Conjugacion):-
    tiempo(Tiempo), persona(Persona),numero(Numero),
    (   Verbo = "to be"->  
    ser(Tiempo,Persona,Numero,R),
        Conjugacion = R ;
    Verbo = "eat"->
    comer(Tiempo, Persona, Numero, R),
        Conjugacion = R ;
    Conjugacion = Verbo).

/** <examples>

?- conjugar_verbo("eat",presente,primera,singular,R).
?- conjugar_verbo("eat",presente,segunda,singular,R).
?- conjugar_verbo("eat",presente,primera,plural,R).
?- conjugar_verbo("eat",pasado,primera,singular,R).
?- conjugar_verbo("eat",pasado,segunda,singular,R).
?- conjugar_verbo("eat",pasado,primera,plural,R).
?- conjugar_verbo("eat",futuro,primera,singular,R).
?- conjugar_verbo("eat",futuro,segunda,singular,R).
?- conjugar_verbo("eat",futuro,primera,plural,R).

?- conjugar_verbo("to be",presente,primera,singular,R).
?- conjugar_verbo("to be",presente,segunda,singular,R).
?- conjugar_verbo("to be",presente,primera,plural,R).
?- conjugar_verbo("to be",pasado,primera,singular,R).
?- conjugar_verbo("to be",pasado,segunda,singular,R).
?- conjugar_verbo("to be",pasado,primera,plural,R).
?- conjugar_verbo("to be",futuro,primera,singular,R).
?- conjugar_verbo("to be",futuro,segunda,singular,R).
?- conjugar_verbo("to be",futuro,primera,plural,R).

*/
