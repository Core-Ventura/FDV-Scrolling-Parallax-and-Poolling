# FDV-Scrolling-Parallax-and-Poolling

Desarrollar ejemplos que implementen los siguientes casos:

1) Scroll con movimiento del fondo. El personaje salta sobre objetos que aparecen en la escena.
2) Scroll con movimiento del personaje. El fondo se repite hasta que pare el juego.
3) Fondo con efecto parallax. El efecto empieza cuando el jugador empieza a moverse, esto se debe comunicar mediante eventos.
4) Utilizar la técnica de pool de objetos para ir creando elementos en el juego sobre los que debe saltar el jugador evitándolos o para adquirir puntos si salta sobre ellos.

Para realizar la actividad he realizado dos pequeñas escenas recreando el flappy bird. 
1) En la primera, el canguro no se moverá y se le irán acercando los correspondientes Tiles junto a un fondo que se moverá mediante offset de coordenadas de Textura. 
![](Gif-FDVTiles1.gif)
2) En la segunda, el canguro será el que se mueva, utilizando la técnica de scrolling parallax. En este caso los tiles no se moverán, sino que será el canguro el que los vaya superando con su movimiento.
