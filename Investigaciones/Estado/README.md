# Estado
![Udg](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/721d6519-28ad-40ef-bf5d-d09a89b54e72)
## Introducción
Para esta actividad debíamos crear un programa que fuera capaz de analizar el estado de una aplicacion, aunque no pude asistir a la clase gracias a ayuda de mis compañeros tambien vi que se mencionaba que nuestro programa debia funcionar como un servicio.

En esta ocacion utilice Python esto porque el ejemplo de la documentacion proporcionada por el profesor esta realizado en python y por motivos practicos no cambie de lenguaje pues la documentacion ya demostraba como crear un servicio a partir de un codigo de python que utiliza una libreria para ver los procesos activos del computador simulando asi el análisis de estado de una aplicación.

Hice una version simple del ejemplo proporcionado por el profesor, mi código solo busca procesos activos de *Visual Studio Code* (code.exe) y registra en un archivo de texto la cantidad de procesos que encontro y su fecha de creacion, por añadir algo mas agregue que si el servicio detectaba mas de 10 procesos de VS activos agregara un mensaje en el .txt.
## Desarrollo
A continuación el código.
![Codigo](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/82b38a37-bf69-48f4-8931-14c025892207)
Como se puede ver el código es muy simple, basicamente cada 2 minutos revisa todos los procesos activos de la computadora y cuando encuentra un proceso de Visual Studio Code escribe en un archivo la fecha de creacion, una vez revisado todos los procesos fueron revisados si encontro mas de 10 procesos de Visual escribe un mensaje en el archivo, ahora mostrare ambos ejemplos.

Las librerias que utilice fueron:
* **psutil:** Esta es la librería que permite ver los procesos activos de la computadora, la use para los metodos de *process_iter()* para revisar los procesos activos, *.name()* para ver el nombre del proceso y *.create_time()* para ver la feche de creación del proceso. Para esta librería fue necesario un **python -m pip install psutil**.

*  **datetime:** Esta librería la utilizo para poner el formato correcto de la fecha en el archiv pues el método *.create_time()* regresa la fecha como un **float**.
*  **time:** Esta librería solamente la uso para hacer un *.sleep(120)*

Este es el archivo llamado *Registro.txt* si encuentra mas de 10 procesos de Visual.

![Registro](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c5de5661-9da3-4ffa-8a06-24e34dfbc4b2)

Aqui se muestra si no encontrase ningun proceso de Visual Studio.

![Captura de pantalla 2023-09-17 184026](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/3ec32cf7-1c42-45f5-ab81-be094a718a00)

Para que mi programa funcionara como un servicio basto con seguir los pasos de la pagina que el profesor proprciono y que esta en mi bibliografía, descargar nssm y ponerlo en la misma carpeta del programa y usar un comando para instalarlo como servicio.

![Comando install](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/3d9b27a3-e3ef-4019-aaf5-1b451c83e519)

Llenar el siguiente formulario.

![Instalar servicio](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/52b6da01-2d3f-4832-ba6c-46cd13e7d09e)

Y finalmente inciar el servicio y reiniciar la computadora.

![start](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/46f174e8-0f68-49fe-ac70-ee61ec79cd87)

## Conclusiones
Realmente es interesante el poder crear tus programas como servicios para tu computadora, inclusive durante mi investigación para esta tarea encontre otra manera de crearlo como servicio, aunque mas que como servicio era como una aplicacion de arranque, necestabas crear un *.bat* de tu código pero realmente se me ocurrieron bastantes ideas curiosas con esto, esta aplicacion es sencilla pero se podria crear un monitoreo de tus aplicaciones IDEs como Visual Studio y si llevas bastante tiempo en ellos que se lance un mensaje de que llevas mucho tiempo forzando la vista y que debes descansar un poco, esa podria ser una posible evolución para este programa, aunque esta versión simple tambien fue interesante de crear.
## Bibliografía
* tecnobillo. (s/f). Crear Servicios para Windows con Python. Tecnobillo.com. Recuperado el 17 de septiembre de 2023, de https://tecnobillo.com/sections/python-en-windows/servicios-windows-python/servicios-windows-python.html
* Python, R. (2013, octubre 6). psutil - Utilidades multiplataforma para procesos. Recursos Python. https://recursospython.com/guias-y-manuales/psutil-utilidades-multiplataforma-para-procesos/
