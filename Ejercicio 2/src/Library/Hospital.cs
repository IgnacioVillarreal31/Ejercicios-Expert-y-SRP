using System;
using System.Text;

namespace Library
{
    public class coordinaciĆ³nConsultas
    {
        public string DatosDoctor {get;} 
        public string DatosPersona {get;} 
        public string AppointmentService {get;} 
        public static int contador = 0;
        

        public coordinaciĆ³nConsultas(string appointmentService, string doctor, string datosPersona)
        {
            this.DatosDoctor = doctor;
            this.DatosPersona = datosPersona;
            this.AppointmentService = appointmentService;
            incrementarContador();
            this.obtenerContador = contador;
        }
        public static void incrementarContador() 
        {
        contador++;
        }
        public int obtenerContador{get;} 
        
    }
}