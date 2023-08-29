<!DOCTYPE html>
<html lang="en">
<head>
    <title>Excepciones</title>
</head>
<body>
    <h3>Divisiones</h3>
    <h4>Elige 2 numeros para dividirlos y tener la respuesta</h4>
    <form method="post" name="division" id="division">
        <label for="divisor">Elige un divisor</label>
        <input id="divisor" name="divisor" type="number"/> <!--Con type number-->
        <label for="dividendo">Elige un dividendo</label>
        <input id="dividendo" name="dividendo" type="number"/> <!--Con type number-->
        <input type="submit" name="boton" id="boton" value="Calcular"/> 
    </form>
    <br>

    <?php
        if (isset($_POST["boton"])) {
            try {
                $num1 = $_POST["divisor"];
                $num2 = $_POST["dividendo"];

                echo "El resultado es: " . ($num2 / $num1);
            } catch (\Throwable $th) {
                echo "No es posible la division entre 0";
            }
        }
    ?>
</body>
</html>