# Simulación de multipliprogramación por hilos
![Captura de Pantalla 2023-09-11 a la(s) 14 02 26](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c7851aec-4e64-4c49-b335-728c9ba33243)

## Introducción
En esta actividad debíamos crear un programa que utilizará hilos, el profesor no específico en que usarlos, simplemente menciono que debíamos usar hilos.

Nuevamente utilice **C#** con **Windows forms** para hacer una aplicación de escritorio, aunque por recomendación de compañeros que ya cursaron está materia estoy pensado en usar **php** para hacer una página web para próximas actividades.

Pasando a mi actividad use una actividad de otra clase, es una aplicación de escritorio que simula un sistema operativo de multipliprogramacion, dónde cada proceso son operaciones simples con números positivos (+, -, \*, \/). Para simular el proceso el usuario agrega el tiempo estimado que tomara el realizarse y al comenzar los procesos, gráficamente se muestra como una *ProgressBar* se llena en el tiempo elegido, una vez completa se muestra el resultado, aquí es donde están los hilos que utilice, pues cada hilo controla una *ProgressBar*.

## Desarrollo 
Esta es la interfaz de la aplicacion, esta conformado de tres *NumericUpDown* el cual es un componente de Windows Forms que solo perimite ingresar numeros enteros, en este caso el rango que agregue es de numeros mayores a 0, uno para el primer valor que deseas operar, uno para el segundo valor a operar y el tercero el cual es el tiempo que tomara dicha operacion en segundos, un *ComboBox* el cual contine las opciones de operaciones a realizar y 6 *ProgressBar* las cuales son las que muestran los procesos graficamente.

![Captura de Pantalla 2023-09-11 a la(s) 14 04 50](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/1c7b996d-45e8-4cfd-8ff7-8175e16c5f1b)

A continuación agregue un solo proceso como ejemplo el cual es **23 + 5** y va a tomar 1 segundo en completarse, agregare mas para mostrar la interfaz completa.

![Captura de Pantalla 2023-09-11 a la(s) 14 14 07](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c9a0e56b-95ab-44e6-b074-a2e3ffdcecde)

Una vez agregado los 6 procesos siendo el ultimo **22 * 12** con un tiempo de 3 segundos puedo presionar el botón de Ejecutar procesos.

![Captura de Pantalla 2023-09-11 a la(s) 14 14 48](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/d4a6bc37-441a-497d-a1b0-e72a1d7293d5)

Al presionar el *Ejecutar Procesos* empiezan todos los procesos a la vez y como se puede ver nuestro primer proceso que solo dura 1 segundo es el que más porcentaje muestra
en su barra de progreso, mientras que los otros hilos con tiempos diferentes van a diferente velocidad.

![Captura de Pantalla 2023-09-11 a la(s) 14 16 35](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/e400dfde-3eff-49ea-8bb8-eb5c7de3a977)

Lógicamente el primer proceso es decir nuestro primer hilo de 1 segundo también es el primer proceso en terminar y mostrar su resultado.

![Captura de Pantalla 2023-09-11 a la(s) 14 17 18](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/3d13d504-ef30-4c25-86a1-6f59374c8af7)

Finalmente, una vez todos los procesos terminan muestran sus resultados.

![Captura de Pantalla 2023-09-11 a la(s) 14 16 54](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c4952fd6-2c4b-4aa1-90a1-613bbbbcab81)

Pasando al código lo primero a resaltar es que se manda a llamar la librería **System.Threading** en donde encontraremos la clase **Thread** para hacer los hilos.

![Captura de Pantalla 2023-09-11 a la(s) 14 21 37](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/ae1072a4-f3a4-4162-8cbe-63eeeed6c63a)

El boton *Ejecutar Procesos* creo que aún tiene muchos aspectos por mejorar, pero básicamente se encarga de crear los hilos para cada barra de progreso y en base a los procesos agregados por el usuario será la cantidad de hilos que iniciara, es decir si el usuario solo agrego 3 proceso significa que count es 3 por ende solo lanzara 3 hilos, encargados de las 3 primeras barras de progreso.

![Captura de Pantalla 2023-09-11 a la(s) 14 21 48](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/500034c2-a34f-4c8d-9f1e-1a77e4dc6ae7)

Finalmente, como se podrá ver los métodos de los hilos, los llamados **cargarProcesoN**, realmente son prácticamente iguales todos, cargar la barra en base al tiempo dado por el usuario usando el mismo método que use la actividad pasada y una vez terminan escriben el resultado en su Label correspondiente, lo único que cambia de un método a otro es la barra, label, resultado y tiempo que utilizan.

![Captura de Pantalla 2023-09-11 a la(s) 14 26 25](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/04702971-8266-456d-b2e7-008ba8dde00d)

## Conclusiones
Trabajar con hilos fue algo bastante interesante y divertido aunque complicado en
momentos, el tener mas de un proceso corriendo a la vez es sin duda alguna algo
bastante curioso de programar y de ver en ejecución, sin duda los hilos son muy
útiles para la multiprogramación, sin embargo creo que aun tengo que seguir
practicando con los hilos, pues creo que existen formas mas eficientes de llegar al
mismo resultado que yo llegue, pero los hilos son mas complejos de lo que pensaba,
por ejemplo un problema que tuve es que no podía modificar las barras de progreso
ni los labels desde mis hilos pues estos elementos fueron creados en el hilo principal
y para modificar o utilizarlos desde un subproceso es decir un hilo debía usar un
método llamado Invoke por lo que si me emociona que mas puedo lograr con esta
herramienta.
## Bibliografía
• Multiprogramación. (s/f). Ecured.cu. Recuperado el 31 de agosto de 2023, de https://www.ecured.cu/Multiprogramaci%C3%B3n

• MULTIPROGRAMACION. (s/f). Blogspot.com. Recuperado el 31 de agosto de 2023, de http://soperativosos.blogspot.com/2015/04/multiprogramacion.html

• Barrios, E. (2020, diciembre 20). Píldoras de C#: Task Parallel Library (TPL) Procesamiento Multihilo y asíncrono. DEV Community.https://dev.to/ebarrioscode/pildoras-de-c-task-parallel-library-tpl-procesamiento-multihilo-y-asincrono-18mp
