#  Practica Docker
![Logo udg](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/891b68bb-5829-442c-8a69-d2179d535c71)
## Introducción
Para esta actividad debíamos utilizar Docker de la manera que fuera para un programa, para entender la practica es necesario entender que es Docker. Docker es una plataforma de software que le permite crear, probar e implementar aplicaciones rápidamente. Docker empaqueta software en unidades estandarizadas llamadas contenedores que incluyen todo lo necesario para que el software se ejecute, incluidas bibliotecas, herramientas de sistema, código y tiempo de ejecución.

Basicamente docker tiene algo llamado imagenes las cuales son un empaquetado de dependencias, librerias entre otras variables para correr un código y que se puede compartir por ejemplo puedes tener una imagen de python con todas las dependencias necesarias para correr algun programa y solo se necesita instalar la imagen y no es necesario instalar todas las dependecias de una en una. En este caso como practica cree un codigo muy sencillo en python solo para poder crear una imagen y entender el funcionamiento basico de Docker.

## Desarrollo
Cómo mencione anteriormente mi código es muy sencillo solo consta de una función que recibe dos numeros, hace operaciones simples con ellos e imprime el resultado en consola.

![Codigo](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/344de078-edb0-42f8-816e-2a1e5a93d91d)

Ahora algo importante a mostrar es el **Dockerfile** el cual me permite crear una imagen para usar, en este caso algo importante a mencionar es que todas las imagenes deben tener una imagen raiz o una imagen base esta se asigna con el comando **FROM**.

![dockfile](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c7754025-b775-450d-a473-bfa53d57731e)

Ahora en una consola, dentro de la carpeta de mi Dockerfile y mi código reviso las imagenes que tengo, como se puede ver no existe ninguna.

![comando build](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/124cca52-f03e-4b57-b92f-e87050091c0f)

En la misma captura se puede ver el comando para crear una imagen el cual es *docker build* el *-t* solamente es para agregarle un nombre, en este caso se ve que agregue el nombre de test, pero la imagen que use para la practica se llama test2, pues el test fue mi primer intento de imagen que salio mal.

![comando run](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/b5d0fc9f-f786-4984-9f37-c36f478ec334)

Una vez creada la imagen podemo correrla con *docker run* y el nombre de la imagen. La parte interesante se puede ver cuando entramos a **Docker Desktop** la cual es la herramienta de escritorio donde se pueden ver los contenedores, los cuales son las capas de imagenes que se utilizan para correr nuestra aplicación, en mi caso yo hice la imagen de test2, pero esta imagen tiene de imagen base una imagen de python y esa imagen tiene de imagen otra y asi sucesivamente.

![Docker desktop](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/6abe57e8-d45f-4b53-a02c-44a2c29b8992)

En este caso aparece que tengo 2 contenedores porque yo ejecute mi imagen 2 veces con el comando de run. Dentro de Docker Desktop puedo ver la ejecución y la impresiones en consola. Y como mencione anteriormente estos contenedores podria compartirlos y usarlos desde otra computadora y el programa correria sin problemas dentor de mi contenedor porque contiene todo lo neceario para ejecutarlo.

![consola docker](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/2cff59d1-016a-4814-90e9-5069c2da641a)
## Conclusiones
De las muchas herramientas vistas en clase Docker me parace de las mas interesante y utiles, el poder crear un contendor con todo lo necesario para desplegar una aplicación o software facilita mucho el trabajar en equipo o trabajar en mas de una computadora, sin embargo es una herramienta que es bastante compleja y por ende bastante poderosa, aun no termino de entender todo el funcionamiento de esta y me gustaria haber usado Docker en un programa mas complejo sin embargo aun no logro manejarlo bien y aun no domino los Dockerfile, quisiera aprender agregar en ellos todas las librerias o dependencias necesarias para la ejecución de algun código a mis contenedores pues aun no domino el como hacerlo, solo se crear imagenes en base a las ya establecidas por Docker Hub.
## Bibliografía
* Contenedores de Docker. (s/f). Amazon Web Services, Inc. Recuperado el 29 de octubre de 2023, de https://aws.amazon.com/es/docker/
* Docker Desktop. (2021, octubre 6). Docker. https://www.docker.com/products/docker-desktop/
