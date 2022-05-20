/*JOSE RODRIGO ALEJANDRO TAPIA  9875528*/
abuelo(X,Y):- padre(X,K), padre(K,Y).
nieto(X,Y):- padre(K,X), padre(Y,K).
hermano(X,Y):-padre(K,X),padre(K,Y).
primo(X,Y):-padre(K,X),padre(J,Y),hermano(K,J),X\==Y.