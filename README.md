# Laboratorio-2
## Preguntas
## ¿Para qué crees que se usan los operadores lógicos en programación?
Los operadores lógicos se usan para comparar valores y tomar decisiones en un programa.  
Por ejemplo, si quiero saber si una persona puede entrar a un lugar solo si tiene más de 18 años y tiene un ticket, puedo usar el operador `&&` (AND) para que ambas condiciones se cumplan.  

También hay operadores como `||` (OR), que sirven para cuando basta con que se cumpla una de varias condiciones.  
En resumen, ayudan a que el programa tome decisiones según lo que queremos hacer.

## ¿Por qué es importante declarar correctamente el tipo de dato de una variable?
Es importante porque cada tipo de dato tiene su propio propósito.  
Si quiero guardar un número entero, debo usar `int`, pero si necesito decimales, uso `double` o `float`.  

Si elijo mal el tipo de dato, el programa puede dar errores o usar más memoria de la necesaria.  
Por eso, declarar bien el tipo de dato ayuda a que el programa funcione sin problemas y sea más rápido. 

# Enunciado 1: Clasificación de edad
## ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Yo usaría `if-else` porque se trata de rangos de edad y con `if` puedo comparar si una edad está dentro de un rango específico.  
`switch` funciona mejor cuando hay valores exactos, como elegir una opción de un menú, pero en este caso tenemos edades en rangos, así que `if-else` es más adecuado.

# Enunciado 2: Día de la semana
## ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Yo usaría `switch` porque tenemos opciones exactas (del 1 al 7) y cada número corresponde a un día específico.  
`switch` es mejor en este caso porque hace que el código sea más ordenado y fácil de leer en comparación con `if-else`, que sería más largo y menos claro.

# Enunciado 3: Verificación de acceso
## ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
Yo usaría `if-else` porque necesito comparar dos valores: el nombre de usuario y la contraseña.  
Con `if-else`, puedo verificar si ambos son correctos, si solo el usuario es correcto pero la contraseña está mal, o si el usuario no existe.  
`switch` no es ideal aquí porque funciona mejor con valores fijos e individuales, pero aquí estamos comparando dos condiciones al mismo tiempo.






