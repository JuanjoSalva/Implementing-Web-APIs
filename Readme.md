
## Laboratorio M�dulo 13

Fichero de Instrucciones: Instructions\20486D_MOD013_LAK.md

Entregar el url de GitHub con la soluci�n y un readme con las siguiente informaci�n:

1. **Nombres y apellidos:** Juan Jos� Salvador Rom�n
2. **Fecha:** 17/12/2020
3. **Resumen del Ejercicio:** 

Se le ha pedido que cree una aplicaci�n de restaurante basada en la web para los clientes de su organizaci�n. Para hacer esto, necesita crear una p�gina que muestre todas las sucursales de restaurantes, permitir a los usuarios solicitar una reserva para una sucursal de restaurante seleccionada, agregar una p�gina de anuncios deseados y permitir enviar una solicitud para un trabajo seleccionado.

Crear� una aplicaci�n de API web del lado del servidor y una aplicaci�n ASP.NET Core MVC del lado del cliente. 
En la aplicaci�n del lado del cliente llamar� a las acciones de la API web mediante HttpClient y jQuery.


**Objetivos**
Despu�s de completar esta pr�ctica de laboratorio, podr�:

- Agregar acciones a una aplicaci�n de API web.

- Llamar a las acciones de la API web mediante HttpClient.

- Llamar a las acciones de la API web mediante jQuer


**Ejercicio 1:**
Agregar acciones y llamarlas mediante Microsoft Edge

En este ejercicio, primero agregar� un controlador y una acci�n a una aplicaci�n API web. Luego, ejecutar� la aplicaci�n y ver� el resultado con Microsoft Edge. Despu�s de eso, agregar� un controlador y una acci�n que obtiene un par�metro. Luego, ejecutar� la aplicaci�n y ver� el resultado con Microsoft Edge. Finalmente, agregar� una acci�n Publicar a la aplicaci�n Web API.

Las principales tareas de este ejercicio son las siguientes:

1.Agregar un controlador y una acci�n a una aplicaci�n API web

2.Ejecutar la aplicaci�n

3.Agrega un controlador y una acci�n que obtiene un par�metro

4.Ejecutar la aplicaci�n

5.Agregar una acci�n Publicar a una aplicaci�n API web


**Ejercicio 2:** 
Llamar a una API web mediante c�digo del lado del servidor

En este ejercicio, llamar� a la API web que desarroll� en el ejercicio anterior utilizando la clase HttpClient. Para hacer esto, primero registrar� el servicio IHttpClientFactory en el archivo Startup.cs. Luego, crear� un controlador MVC y usar� la clase HttpClient para llamar a una acci�n Get en la API web. Despu�s de eso, crear� otro controlador MVC y usar� la clase HttpClient para llamar a una acci�n de publicaci�n en la API web. Finalmente, agregar� una acci�n al controlador MVC en la que usar� la clase HttpClient para llamar a una acci�n Get en la API web que obtiene un par�metro.

Las principales tareas de este ejercicio son las siguientes:

1.Llamar a un m�todo Get de API web

2.Ejecutar la aplicaci�n

3.Llamar a un m�todo de publicaci�n de API web

4.Llamar a un m�todo Get de API web que obtiene un par�metro

5.Ejecutar la aplicaci�n


**Ejercicio 3:**
llamar a una API web mediante jQuery

En este ejercicio, llamar� a una API web mediante jQuery. Primero crear� un controlador MVC y usar� jQuery para llamar a una acci�n Get en la API web. Despu�s de eso, crear� otro controlador MVC y usar� jQuery para llamar a una acci�n Publicar en la API web.

Las principales tareas de este ejercicio son las siguientes:

1.Llamar a un m�todo Get de API web mediante jQuery

2.Ejecutar la aplicaci�n

3.Llamar a un m�todo Get de API web mediante HttpClient

4.Llamar a un m�todo de publicaci�n de API web mediante jQuery

5.Ejecutar la aplicaci�n


Iniciamo la aplicaci�n y nos lleva a Home para mostrar las sucursales:

![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\Inicio.PNG)



Introducimos un trabajo:
![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\PuestoTrabajo.PNG)
![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\PuestoTrabajoIn.PNG)
![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\PuestoTrabajoOut.PNG)

Hacemos una reserav:
![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\Reservation.PNG)
![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\ReservationIn.PNG)
![Inicio](E:\JUANJO\CURSO2020\MODULO3_NET\20486D\Allfiles\Mod13\Labfiles\01_Restaurant_begin\Client\img\ReservationOut.PNG)


4. **Dificultad o problemas presentados y como se resolvieron:** Ninguno