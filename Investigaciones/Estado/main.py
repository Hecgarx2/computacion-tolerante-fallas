import psutil
from datetime import datetime
import time

NOMBRE_ARCHIVO="Registro.txt"

def lock():
    contador = 0
    for proc in psutil.process_iter():
        if proc.name().lower() == 'code.exe':               #Busco procesos de Visual Studio Code
            linea = str('Visual Studio Code ' + (datetime.fromtimestamp(proc.create_time()).strftime(
            "creado el %Y-%m-%d a las %H:%M:%S")))  #Linea que se escribe en el archivo con fecha de creacion del proceso
            archivo = open(NOMBRE_ARCHIVO, "a")
            archivo.write(linea+'\n')               #Escritura en el archivo
            archivo.close()
            contador+=1

    if contador > 10:
        archivo = open(NOMBRE_ARCHIVO, "a")
        archivo.write("Demasiada programacion por hoy, descansa un poco \n")
        archivo.close()
    else:
        archivo = open(NOMBRE_ARCHIVO, "a")
        archivo.write("Aun tenemos muchas tareas, animo \n")
        archivo.close()


if __name__ == '__main__':
    while True:
        lock()
        time.sleep(120)   