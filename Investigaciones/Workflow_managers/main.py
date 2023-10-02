from prefect import Flow

@Flow
def validarPassword(password):
    if 6 >= len(password):
        print("Constraseña Invalida: Tu contrsaeña debe tener mas de 6 caracteres")
        return False

    numeros = 0
    mayusculas = 0
    minusculas = 0
    caracEspecial = 0
    especiales = ['@','#','.','*','_','/']

    for carac in password:
        if carac.isspace():
            print("Constraseña Invalida: Tu contrsaeña no debe tener espacio")
            return False
        elif carac.isdigit():   #Cuenta cuantos numeros tiene la contraseña
            numeros += 1
        elif carac.isupper():   #Cuenta cuantas minusculas tiene la contraseña
            mayusculas += 1
        elif carac.islower():   #Cuenta cuantas mayusculas tiene la contraseña
            minusculas += 1
        elif carac in especiales:   #Cuenta cuantos caracteres especiales tiene la contraseña
            caracEspecial += 1
        else:
            print("Constraseña Invalida: Tu contrsaeña tiene un caracter invalido")
            return False
    
    print("Contraseña Valida:" + str(password) + "\nNumeros:" + str(numeros) + "\nMinusculas:" + str(minusculas) + 
          "\nMaysculas:" + str(mayusculas) + "\nCaracteres especiales:" + str(caracEspecial) )

def run():
    passwords = ["Hola123", "Hol@123", "Hola 123", "H014_123", "Hol@_#123", "Hola=123"]
    for password in passwords:
        validarPassword(password)
    
run()
