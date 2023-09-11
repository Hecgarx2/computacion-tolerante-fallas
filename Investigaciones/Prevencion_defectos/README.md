# Autoguardado
En esta actividad la idea era crear un programa capaz de recuperar su estado de ejecucion, en este caso realize una interfaz muy sencilla que te permite hacer click en un rectangulo para dibujar circulos de colores, uno para cambiar el color de los circulos y otro para cargar si ya habia circulos dibujados.

![](https://github.com/Hecgarx2/Imagenes/assets/71054677/ff7b11e3-3331-47b8-b96b-b3b355ef9f01)

Aqui se puede ver que ya agregue unos cuantos cirulos cada uno de un color diferente.

![Archivo](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/8f08eaef-a73d-4298-adfd-32977e7aebf4)

Este es el archivo donde se guardan los datos del cirulo, los 2 primeros valores representan su posicion en (x, y), el tercer valor es su radio y el cuarto valor es su color, es decir el primer circulo esta en (366, 120), con un radio de 30 de color negro.

![](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/e9d8c1e0-52a2-4c07-ab4c-d67d79294dc8)

Si vuelvo a ejecutar el programa entoces se muestra vacio, a menos que precione el boton de cargar el cual manda a llamar una funcion que recarga lo guardado en el archivo.

![Cargar](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/65fb34d8-79cd-4fdf-a837-95398fe0b264)

La funcion encargada de esto es **ButtonCargarClick** esta funcion se activa al hacer click sobre el boton de cargar y basicamente lee el archivo y dependiendo del caso es el valor que guarda en las variables definidas antes del while, los casos empiezan por 1 y una vez recibo el color el cual es el ultimo dato que necesito para dibujar un circulo lo pinto en **pictureBoxGraph** el cual es el recuado de los circulos y vuelo al caso 1, asi hasta terminar de leer el archivo.

![Funcion](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/f4b6e0c5-002e-4398-bab7-29eb549d8b47)
