# Practica Airflow
![Logo udg](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/009d2f0c-5082-45bd-abcc-84a0ec1edf02)
## Introduccion
Para esta actividad debiamos usar Airflow, podia ser para adaptar nuestro trabajo de la actividad pasada o uno nuevo, en mi caso yo solo adapte la activdad anterior. Airflow es una herramienta que permite gestionar, monitorizar y planificar flujos de trabajo, usada como orquestador de servicios. Se usa para automatizar trabajos, dividiéndolos en subtareas. Permite su planificación y monitorización desde una herramienta centralizada. Los casos de uso más comunes son la automatización de ingestas de datos, acciones de mantenimiento periódicas y tareas de administración.
## Desarrollo
La documentación de Airflow explica como hacer la instalación en Linux mas no en Windows, para utilizarlo es necesario tener un subsistema que corra sobre un sistema operativo, para esto se puede utilizar Docker o el Windows Subsystem for Linux, en mi caso eso fue lo que use, la documentacion y video que use estan en mi bibliografia. 

![Ubuntu](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/daf89261-229d-4e05-bce4-d51096a4cae2)

El susbsistema que corro sobre mi windows es Ubuntu.
Una vez hecha toda la instalación y configuracion que se necesita para el subsistema de Linux, se puede invocar desde la consola de windows o buscar directamente la terminal de la distribucion que instalaste en mi caso Ubuntu.

![wsl](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c76c52ab-cacb-416c-bad8-260eeb699e4b)

Siguiendo la documentación de Airflow una vez instalado sobre mi subsistema de Linux puedo usar el comando *airflow standalone* para levantar un localhost donde puedo ver mis dags.

![ConsolaUbuntu](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/2cdc0c2f-9aa8-41a3-ad4d-5729702527b9)

En este caso el comando te genera varios por defecto, el que vamos a probar es que yo cree con el código que esta en esta misma carpeta (test.py). Mi dag se llama **test** igual que el y basicamente es el mismo código de la clase pasada pero adaptado con Airflow.

![dag](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/847f34aa-ffa5-4369-a4ca-bad1eada919c)

Pasando al código que se puede revisar dentro de la carpeta aunque el servidor de Airflow te permite ver el código en el, realemente mi ejemplo es muy similar al que se muestra en la documentación de Airflow, la unica diferencia es que en lugar de usar *BashOperator* utilice *PythonOperator* para poder utlizar las funciones de Python que ya tenia.

![codigo1](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/3fe09fd7-68f8-44ff-af92-b0cd660dc804)

La definición de mi dag, como se puede ver realmente es practicamente el mismo de la documentación.

![codigo2](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/26f5a207-8544-4598-a27d-8a0008275de4)
![codigo3](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/222709e7-7ab0-4f19-babd-d8d35f034fbb)

Aqui se aprecia mejor como funciona el operador, tiene su id, como se puede ver uso el mismo nombre que tiene la función de Python y tiene la función de Python la cual llama. Y al final se puede ver como Tarea1 llama o dispara a Tarea2.

![graph](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c5166043-dedc-4f7e-9c24-be4bb0ee1320)

Este es el grafo de las tareas de este dag, es muy sencillo porque solo son 2 tareas pero sirve como ejemplo de un dag.

![running](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/2cc88240-73eb-4318-b7a7-3cb8a81e3bf1)

Aqui se pude ver las veces que este dag fue ejecutado y su tiempo y si fue una ejecuccion existosa y en caso de error en que tarea termino.
## Conclusiones
Sin duda es una herramienta muy poderosa y si sabe usar bastante util, pues te da bastante informacion del funcionamiento y flujo que tiene tu programa a traves de su ejecucción puediendo revisar si cada función se ejecuto de manera correcta o si hubo algun fallo, me gusto es una herramienta muy util pero la primera vez que la use fue muy complicada de entender, instalar y de hacer funcionar por lo que si es una gran herramienta de la cual aun no saco su maximo provecho pero si es algo que se puede tener en cuenta como un mejor monitoreo sobre el desarrollo de algun software.
## Bibliografia
* SiJo [@LadyPuffingtonDewesbury]. (2023, agosto 3). Installing Airflow on Windows 10 without Docker. Youtube. https://www.youtube.com/watch?v=M2LNxxKPo3s
* Quick Start — Airflow Documentation. (s/f). Apache.org. Recuperado el 16 de octubre de 2023, de https://airflow.apache.org/docs/apache-airflow/stable/start.html
