materia(matematicas, 5).

materia(fisica, 4).

materia(quimica, 3).

materia(literatura, 2).

materia(biologia, 4).

estudiante(maria, [matematicas, fisica, quimica]).

estudiante(juan, [matematicas, literatura]).

estudiante(ana, [fisica, quimica, biologia]).

materias_por_estudiante(Estudiante, Materias) :-

    estudiante(Estudiante, Materias).



