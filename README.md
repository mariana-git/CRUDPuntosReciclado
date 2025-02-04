# TECNICATURA ANALISIS DE SISTEMAS -  2do Año
## TP FINAL: CRUD: PUNTOS DE RECICLADO



https://github.com/user-attachments/assets/aaff6f78-8033-4457-bad4-e9d8234acc9f



### REQUERIMIENTOS
Una organizacion dedicada a la venta de residuos sólidos urbanos reciclables tiene diferentes puntos de acopio de materiales para reciclado, y solicita un software donde poder gestionar las entidades que maneja: por un lado, los PUNTOS donde reciben los materiales de la comunidad, por otro lado las PERSONAS que cumplan RESPONSABILIDADES en dichos Puntos.
De las Personas requiere registrar el NOMBRE, APELLIDO, DNI Y TELEFONO; de los PUNTOS solicita registrar el NOMBRE, DIAS Y HORARIOS en que funcionan, el ESPACIO en que está instalado el local (generalmente espacios publicos) y la DIRECCION de los mismos.  Las Responsabilidades que las personas tengan en cada lugar debe quedar consignada.
Requieren poder realizar ABMC de las personas, AMBC de los Puntos y también un ABMC de las Responsabilidades. 

### DIAGRAMA ENTIDAD-RELACION

![image1](https://github.com/user-attachments/assets/a46cbabf-d551-424c-a21f-b08b64ca4c1d)

### DIAGRAMA RELACIONAL

![image2](https://github.com/user-attachments/assets/804461a9-4361-46b6-80f1-7397b8aaf81a)

### RESTRICCIONES EN LAS RELACIONES
Tal como se observa en el Diagrama Relacional, las tablas de Personas y las de Puntos tienen cada una Claves Primarias simples e autoincrementales, y en la tabla de Responsabilidades hay dos claves Foráneas, siendo una tabla puente entre ambas entidades principaler.
Para este sistema se establecio de acuerdo con el cliente que cuando el borrado o modificacion de un registro de las tablas Persona o Punto impacte en algun registro de la tabla Responsabilidades, el sistema debera alertar de esta situación al usuario informando la cantidad de registros afectados y le permita confirmar o bortar dicha operacion (CASCADA).

## STORE PROCEDURES
Algunas de las consultas se han facilitado mediante la creacion de SP, como se ejemplifica a continuacion:

```sql
CREATE PROCEDURE spResponsabilidades_Leer
AS
BEGIN
SELECT pr.idPunto, DENOMINACION, DIASYHORARIOS, ESPACIO, DIRECCION, p.idPersona, NOMBRE, APELLIDO, DNI, TELEFONO,RESPONSABILIDAD 
FROM Responsabilidades r 
INNER JOIN Puntos pr ON pr.idPunto = r.idPunto
INNER JOIN Personas p ON r.idPersona=p.idPersona
END
GO

CREATE PROCEDURE spResponsabilidades_BuscarString
@Parametro varchar(80)
AS
BEGIN
SELECT pr.idPunto,DENOMINACION, DIASYHORARIOS, ESPACIO, DIRECCION, p.idPersona, NOMBRE, APELLIDO, DNI, TELEFONO,RESPONSABILIDAD 
FROM Responsabilidades r 
INNER JOIN Puntos pr ON pr.idPunto = r.idPunto 
INNER JOIN Personas p ON r.idPersona=p.idPersona 
WHERE denominacion LIKE '%@Parametro%' OR ESPACIO LIKE '%@Parametro%' 
OR DIRECCION LIKE '%@Parametro%' OR NOMBRE LIKE '%@Parametro%' OR 
APELLIDO LIKE '%@Parametro%' OR RESPONSABILIDAD LIKE '%@Parametro%'
END
GO
```




