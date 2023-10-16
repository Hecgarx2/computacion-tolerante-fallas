from datetime import datetime, timedelta

# The DAG object; we'll need this to instantiate a DAG
from airflow import DAG

# Operators; we need this to operate!
from airflow.operators.python import PythonOperator

with DAG(
    "test",
    # These args will get passed on to each operator
    # You can override them on a per-task basis during operator initialization
    default_args={
        "depends_on_past": False,
        "email": ["airflow@example.com"],
        "email_on_failure": False,
        "email_on_retry": False,
        "retries": 1,
        "retry_delay": timedelta(minutes=5),
        # 'queue': 'bash_queue',
        # 'pool': 'backfill',
        # 'priority_weight': 10,
        # 'end_date': datetime(2016, 1, 1),
        # 'wait_for_downstream': False,
        # 'sla': timedelta(hours=2),
        # 'execution_timeout': timedelta(seconds=300),
        # 'on_failure_callback': some_function, # or list of functions
        # 'on_success_callback': some_other_function, # or list of functions
        # 'on_retry_callback': another_function, # or list of functions
        # 'sla_miss_callback': yet_another_function, # or list of functions
        # 'trigger_rule': 'all_success'
    },
    description="A simple tutorial DAG",
    schedule=timedelta(days=1),
    start_date=datetime(2021, 1, 1),
    catchup=False,
    tags=["example"],
) as dag:

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

	tarea2 = PythonOperator(
		task_id="validaar",
		python_callable=validarPassword,
		dag=dag
	)

	def run():
		passwords = ["Hola123", "Hol@123", "Hola 123", "H014_123", "Hol@_#123", "Hola=123"]
		for password in passwords:
			validarPassword(password)

	tarea1 = PythonOperator(
		task_id="run",
		python_callable=run,
		dag=dag
	)

	tarea1 >> [tarea2]