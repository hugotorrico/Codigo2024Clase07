using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase07
{
    public class Persona
    {
        //Forma Antigua
        private string Nombres;
        public void setNombres(string nombres)
        {
            Nombres = nombres;
        }

        public string getNombres()
        {
            return Nombres;
        }

        //Forma Actual
        public string Nombres2 { get; set; }

        //Forma personalizada
        private string name;
        public string Name
        {
            get
            {
                //retorna mayúsculas
                return name.ToUpper();
            }
            set
            {

                name = value;
            }
        }

        public string Apellidos { get; set; }
        public  int Edad { get; set; }



        //Constructor con  2 parámetros
        public Persona(string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = 0;
        }

        //Constructor con  3 parámetros
        public Persona(string nombres, string apellidos, int edad) 
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
        }

        //Constructor por defecto
        public Persona() {

            Nombres = string.Empty;
            Apellidos = string.Empty;
            Edad=0;
        }
    }
}
