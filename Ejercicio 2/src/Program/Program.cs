using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string Appointment1 = AppointmentService.CreateAppointment(DateTime.Now, "Queen Street");
            string Doctor1 = DatosDoctor.crearDoctor("Pablo Chacon", "Mata Crakens");
            string Persona1 = DatosPersona.CreateAppointment("Queen", "53787372","098123123","24");

            Console.WriteLine(Appointment1);
            Console.WriteLine(Doctor1);
            Console.WriteLine(Persona1);

            coordinaciónConsultas consulta1 = new coordinaciónConsultas(Appointment1,Doctor1,Persona1);
            Console.WriteLine(consulta1);
            Console.WriteLine(consulta1.DatosDoctor);
            Console.WriteLine(consulta1.DatosPersona);
            Console.WriteLine(consulta1.AppointmentService);
            Console.WriteLine(consulta1.obtenerContador);
            coordinaciónConsultas consulta2 = new coordinaciónConsultas(Appointment1,Doctor1,Persona1);
            Console.WriteLine(consulta2.obtenerContador);
        }
    }
}
