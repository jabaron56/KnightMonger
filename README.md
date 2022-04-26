# KnightMonger

## Unity platform 2D game

## Requisitos 📋

Escena inicial de introducción al juego.

Escena de juego:

- Recolección de elementos.
- Música de fondo.
- Diferentes efectos de sonido.
- Retos u obstáculos: enemigos.
- Sistemas de partículas.
- HUD.
- Añadir diferentes tipos de powerups para recoger. Cada uno con puntuación diferente. Opcional.
- Añadir vidas al player. Opcional.
- Guardar la puntuación máxima de una partida a otra. Opcional.
- Escena final de juego para mostrar la puntuación total y la oportunidad de volver a jugar.
- Cambiar el icono del juego.
- Cambiar el splash por defecto de Unity. Opcional.

## Funcionalidades extras 📋

- Acción de agacharse que desactiva el collider superior para permitir que pueda pasar por zonas reducidas.
- Animación de muerte y animación de agacharse, además, tendrá otra animación de ataque cuando esté agachado.
- El juego requiere de la activación de un elemento para activar el final del juego.
- Para facilitar al jugador el conocimiento de los objetivos del juego se ha añadido un efecto de movimiento en la cámara que indica cual es el siguiente objetivo.
- Control dinámico de la cámara mediante Cinemachine.
- Limitación de la cámara para que no se salga de la zona de juego.
- Menú de pausa durante el juego, esta opción estará desactivada durante los menús de muerte o fin del juego.
- Botón para reiniciar el score, disponible en los menús de muerte y fin del juego.

## Construido con 🛠️

Unity

## Información del juego ❗

### HUD

Al iniciar el juego el jugador tendrá 2 vidas disponibles indicadas como un corazón, también contará con un indicador de diamantes y otro de puntuación, estos estarán a 0 al principio de la partida.

### Consumibles

Durante el juego se podrán recoger dos tipos de consumibles:

- Poción: esta poción aumentará una vida al contador del jugador, el jugador podrá tener como máximo 3 vidas, y cuando este contador llegue a 0 la partida termina.
- Diamante: cada diamante tendrá un valor de 150 puntos, este valor se irá acumulando en el contador de puntos a medida que se recolecten los diamantes.

### Objetivos

El objetivo final del juego es que el jugador cruce la puerta de salida del nivel que está situada al final del recorrido, evitando caer al vacío o ser atacado por los enemigos.

La puerta no se encuentra abierta al iniciar la partida, para abrirla y poder terminar el nivel hay que acceder a la palanca situada en la parte superior del castillo.

## Despliegue 📦

Ejecutar el archivo KnightMonger de la carpeta Ejecutable.

## Autores ✒️

- Javier Barón Pérez - (https://github.com/jabaron56)
- Ismael De Gregorio López - (https://github.com/Lufram)
- Alberto Lozano Gómez - (https://github.com/Tachenko)
