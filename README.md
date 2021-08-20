# Respuestas - LuxMG

### Problema 1
En el primer problema ocurre una excepción del tipo *IndexOutOfRangeException*. Esta ocurre al iterar sobre un arreglo, cuando nos pasamos del rango de índices. En este caso la excepción salta cuando intentamos mostrar la posición 5 del arreglo "list", posición que no existe.
    
### Problema 2
En el segundo problema ocurre una excepción del tipo *OverflowException*. Esta ocurre cuando intenta asignarse en una variable un valor que sobrepasa los límites del tipo. En este caso la excepción salta cuando se intenta asignar en la variable "result" que es de tipo byte un valor distinto de 1 o 0 (en este caso se intenta asignar 1800).
    
### Problema 3
En el tercer problema ocurre una excepción del tipo *NullReferenceException*. Esta ocurre cuando intentamos mostrar o usar valores que no son nulos. En este caso la excepción salta cuando intentamos mostrar el "Auto2", ya que este está inicializado en *null* y no posee los datos que se buscan mostrar.
    
### Problema 4
En el cuarto problema ocurre una excepción del tipo *FormatException*. Esta ocurre cuando el formato de una cadena compuesta es erróneo o el formato de un argumento no es válido. En este caso la excepción salta cuando intentamos mostrar por pantalla el contenido de las variables, ya que se declara que se van a mostrar 3 variables y por parámetro solo se pasan 2 variables.
