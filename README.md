# Buffer Overflow

### este ataque se centra en la memoria
la memoria es un componente crucial para el procesamineto de datos, en una computadora la memoria esta almacenada de muchas maneras como ssd, hdd ,ram , entre otros.

![alt text](image.png)

### La Ram
Enfocandonos en la ram es un tipo de almacenamineto de datos a corto plazo, este tipo de memoria es perfecta para alojar instrucciones de programas que se estan ejecutando, los punteros que definen los espacios de memorio puede variar dependiendo de la arquitectura del circuito y el lenguaje de bajo nivel que controle esta arquitectura 

![alt text](image-1.png)

### Diseño de la memoria 

El diseño de la memoria se divide en  5 segementos 

#### Segmento de texto 

Aqui se borra el codigo ejecutable del programa por lo que es del tipo de solo lectura 

![alt text](image-2.png)

#### Segmento de Datos 
 
 Aqui estan las variables globales que son inicializadas por el programa 

 ![alt text](image-3.png)

 #### Segmento de datos no inicializados 
 Aqui estan las variables declaradas pero no inicializadas en el programa 

 ![alt text](image-4.png)


 #### Segemento del heap 

Este segemtno provee un espacio para la asignacion dinamica de la memoria (asigna espacio a la memoria )

![alt text](image-5.png)

#### Segmento de pila 

Este segmento contiene variables locales dentro de las funciones , principalmente usado para la asignacion estatica de variables 

![alt text](image-6.png)

### Funcionamiento del Ataque 

Es importante notar que el segmento de heap y de pila , pueden crecer dependiendo de las necesidades que tenga el programa 

![alt text](image-7.png)

El ataque puede ocurrir en estos dos segmentos de la memoria 

![alt text](image-8.png)


### Funcionamiento en el segmento de pila 

Sigue la metodologia de el ultimo que entra el primero que sale , definiendolo como una estructura de datos  va de direccion alta a baja 

![alt text](image-9.png)

Cuando un programa se ejecuta el programa hace varios llamados a las funciones(subrutinas), cuando la funcion es invocada se asigna un marco en pila de la memoria 

![alt text](image-10.png)

### Almacenamiento de argumentos 

![alt text](image-11.png)

### Direccion de Retorno 
Cuando la funcion termina de ejececutarse debe volver al flujo normal en esta parte se almacena la dirección de memoria donde debe de regresar la función cuando termine de ejecutarse 

![alt text](image-12.png)

### Variables Locales 

guarda la informacion de todas las variables declarables 

![alt text](image-13.png)

### Direccion de marco anterior 

 Esta región es la que nos permite saber en que direccion de la memoria estan los argumentos y variables locales, para saber esto tenemos un registro especial , llamado puntero de marco, este apunta a una ubicacion fija del marco , asi sumando  a la direccion fija obtenemos las direcciones de funciones y variables locales, tambien puede ser una ubicación al procesador de la pc a la que se puede acceder rapidamente 

![alt text](image-14.png)

![alt text](image-15.png)

### Funciones anidadas 
El proceso cada vez que se ejecute una funcion guardara este puntero a un posicion especifica (marco/procesador) , mientras que para cada marco de cada llamada se llamara en el puntero del marco anterior, para que en todo momento sepa donde esta ubicado el anterior y actual proceso ejecutandose 

![alt text](image-16.png)


### Ejemplos de asignacion de memoria 
Cada Variable, declaracion , funcion entre otros ocupa un determinado espacio en memoria 

![alt text](image-17.png)


### Formando Arreglos de Caracteres 

Tendriamos que multiplicas la cadena por el tamaño de tipo de dato 

![alt text](image-18.png)


### Vulnerabilidad a explotar 

Hay un proceso común el cual es copiar datos de un segmento a otro , antes de realizar esta operacion el programa debe de realizar espacio al segmento destino 


![alt text](image-19.png)


### Consecuencias 

#### Que el programa muera 

#### Que el programa ejecute otra funcion 

La forma clasica seria confeccionar un archivo malicioso el cual tendria un estructura determinada el cual tendremos que mandar al programa, y cuando el programa lo lee este sobreescribira los llamados a la pila , haciendo  que la retornar al flujo de dirección del programa este retorne a nuestras funciones del archivo malicioso 

![alt text](image-20.png)


### Metodos de prevencion 

#### Funciones más seguras 

#### Analizador estatico de programa 

#### Lenguajes de programacion (que verifiquen este tipo de ataques )

#### Sistema Operativo (con aleatoriedad de memoria)

#### Stack guard

![alt text](pic2_0_0.png.webp)


#### Más Contenido 
Aprende a Explotar un BUFFER OVERFLOW Paso a Paso

https://www.youtube.com/watch?v=C06r6DfCxpA

BUFFER OVERFLOW EXPLOIT // Ejemplo práctico

https://www.youtube.com/watch?v=0KE4Yy6loxY