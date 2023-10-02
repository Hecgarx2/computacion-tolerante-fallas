# Workflow managers

![Logo udg](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/c1b27714-2609-4dac-bf7c-d089a5a2fd6a)

## Introduccion

Para esta actividad debiamos usar Prefect es una biblioteca de Python para la orquestación de flujos de trabajo. Es una herramienta poderosa que permite a los usuarios definir, programar, ejecutar y monitorear flujos de trabajo complejos y de múltiples pasos en Python. Se integra con una amplia variedad de herramientas y sistemas, lo que permite una integración fácil y sin problemas con el resto de su infraestructura.

## Desarrollo

Para utilzar Prefect es necesario instalarlo usando el comando **pip install -U "prefect"**, realmente es muy sencilla de instalar y personalmente no me causo ningun problema.

![pip install prefect](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/8f516894-a123-4a9e-90e9-9ac67159605c)

A continuación el código.

![Codigo prefect](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/146da24c-3116-4985-8e23-bd5d346f6dd3)

El código simula validar si una contraseña es valida o invalida, el codigo consta de 2 funciones, la primera simplemente define un arreglo de posibles contraseñas la cual despues se pasan por una la siguente funcion la cual es mi flow de la biblioteca prefect.

Esta segunda funcion simplemente analiza que la contraseña tenga mas de 6 caracteres y que ningun caracter sea un caracter invalido, en caso de ser una contraseña valida contara cuantos numeros, minusculas, mayusculas o caracteres especiales validos tiene la contraseña.

![Resultado](https://github.com/Hecgarx2/computacion-tolerante-fallas/assets/71054677/70011066-b551-4331-b2b0-4e975181e453)

Como se puede ver al ejecutarse ademas de los prints que estan en mi fucnion de validarPassword, la libreria muestra el estado de finalizado cada vez que se entro la funcion que es nuestro flow y nos muestra que todo funciono correctamente.

## Conclusiones

La librería prefect es bastante util a la hora de querer ver cada cuando inicia y termina la ejecución de cada función o proceso y determina si se ejecuta correctamente, esto nos ayuda para tener un mejor control de nuestro programa y una mejor idea del flujo de nuestra aplicación o código, por lo que veo prefect es una librería con una gran cantidad de opciones las cuales se verán mejor aprovechadas en un programa mucho más grande, me gustaria probarlo en mas ambitos y ver que se pude lograr con ella o que utlidades puede darse con ella, aunque por cuestiones de tiempo este ejemplo es muy simple.

## Bibliografia

* Flows. (s/f). Prefect.io. Recuperado el 1 de octubre de 2023, de https://docs.prefect.io/latest/tutorial/flows/
* Byspel. (2021, septiembre 15). Módulo de VALIDACIÓN contraseñas de usuario en Python 🐍. Byspel Tech. https://byspel.com/modulo-de-validacion-contrasenas-de-usuario-en-python/
