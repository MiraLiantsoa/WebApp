# WebApp
1- Theorie 
Chaine XPath qui retourne :

1- tous les éléments book : 
/library/book

2- tous les éléments title ayant comme parent un élément book avec un attribut type égal à roman
//book[@type='roman']/title

3- le nombre d'éléments book ayant un attribut type égal à bd
//book[count(@type='bd')]

4- /library/library/ancestor-or-self::library 
retourne tous les parents de la librairie courante 
