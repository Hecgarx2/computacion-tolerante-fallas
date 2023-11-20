# Practica Micorservicios

![Logo udg](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/b3cb8f67-8f6d-4c01-8170-f2a2e733531e)

## Introducción

Para esta actividad debíamos crear un microservicio, esta actividad la realice utilizando Docker, basandome en la documentacion de Docker el cual te muestra como crear una app con microservicios, la documentacion crea una aplicación web con Node.js con MySQL, la app o interfaz seria el primer servicio la consta de una barra de texto tipo input para agregar items, los cuales son cualquier cadena de texto que se agregue y el segundo servicio seria la base de datos la cual almacena estos items agregados, por si paramos el servicio y lo volvemos a levantar los items agregados se conserven.

## Desarrollo

Para crear microservicios con docker constiene basicamente en crear una imagen por cada microservicio que queramos que tenga la aplicación esto mediante un archivo llamado **compose.yaml** a continuación mostrare como seria crear cada servicio como una imagen indivdual de Docker y el resultado de tenerlo todo en un solo contenedor.

Lo primero que hice fue clonar la aplicación que viene en la documentación de docker.

![git clone](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/0709226f-7237-4a83-a417-b8d428482242)

### App
Para crear la app solo necestamos el dockfile con los datos necesarios.

![dokcerfile](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/b844d0b3-3f2b-4862-ba07-5fb57bdb82e2)

Esta seria su imagen

![docker desktop](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/a1d256c8-f8e6-4359-af4c-ecab36a808e6)

### Base de datos
Para una base de datos se debe crear una imagen llamada volume

![db ](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/e0eb913b-9150-4b09-9a7c-6cb80a9f2de8)
![db desktop](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/71d4a8eb-04e3-41dd-98d5-0f02d37669c4)

Y despues correrlo

![Mysql](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/78ab9770-1475-4420-beda-5c772b58aa12)
![db y app](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/ccae273e-e310-4418-896b-573f03052515)

### App con microservicios
Para crear un microservicio basicamente se necesita plasmar en el **compose.yaml** los mismos comandos que se utilizan para crear la imagen de la app y el comando para conectarla con la imagen de la base datos. Es decir los comandos del Dockerfile y el comando de la consola que utilizamos para correr la imagen del app conectada con la imgen de MySQL.

![compose](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/37dad06f-95f6-4a28-9809-478dd5a3e992)

Ahora se usa el comando *docker compose up -d* para levantar la app y utlice el compose.yaml para levantar el microservicio.

![microservicio](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/2eb34818-b632-4701-a6ec-00838e7aac90)
![consola micro](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/89b84548-f7ae-4c11-8b63-98e5d46f0c8c)
![Microservicio run](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/1f7399c4-1e62-428a-b3da-48e4c0096dc1)
![app](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/2d0709c8-a99d-4a9d-a607-7f5c8bd2ed99)

## Conclusión
Como se puede ver en el Docker Desktop, al final ambos servicios que antes eran dos contenedores indivduales funcionan como microservicios de mi app y se pueden observar dentro de un mismo contenedor funcionando. Esta fue una actividad un poco mas complicada pero despues de ver un poco de explicación del profesor pude resolverlo de mejor manera, esta actividad me ayudo a entender de mucho mejor manera los Dockerfile, por ejemplo la parte de **RUN** que me permite correr comandos necesarios para que funcione mi código, por ejemplo correr un pip install desde el para que al correr la imagen se tenga todo lo necesario para su funcionamiento, sin embargo aun hay cosas del **compose.yaml** que aun no acabo de entender.

## Bibliografía
* https://docs.docker.com/get-started/
