# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

### Sistema de consultas médicas

Como desarrolladores de software, se nos pide hacer el mantenimiento de un sistema de gestión médica, especifícamente se nos pide que hagamos mantenimiento de la funcionalidad de coordinación de consultas. Para ello debemos tener en cuenta que:
1. Se podrían agregar otros datos del paciente como por ejemplo su edad.
2. Se podrían agregar otros datos al Doctor como por ejemplo su especialidad.
3. La consulta debe tener un identificador único
4. Cada dato que se ingrese al sistema debe ser válidado.

Para el ejercicio se pide

#### ✍ Parte 1
**Criticar el código dado en base a patrónes y principios**
Para mi esta mal que esten los datos de la ubicacion y hora junto con los datos de la persona y los datos del doctor ya que si las pones juntas como al principio, la clase tendra demaciadas responsabilidades y esto esta mal segun el principio srp. 

#### 🧐 Parte 2
**Realizar las CRC correspondientes.**
Nombre: DatosDoctor
Responsabilidad: Conocer datos doctor, Valida datos ingresados

Nombre: DatosPersona
Responsabilidad: Conocer datos persona, Valida datos ingresados

Nombre: AppointmentService
Responsabilidad: Conocer datos del lugar y fecha, Valida datos ingresados

Nombre: Hospital
Responsabilidad: Generar una consulta
Colaboraciones: DatosDoctor,DatosPersona,AppointmentService

#### 👩‍💻 Parte 3
**Aplique patrónes/principios según su crítica.**

