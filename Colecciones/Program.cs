using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> Descrip = new List<Alumno>();
            Descrip.Add(new Alumno());
            Descrip[0].Nombre = "Jose Jose";
            Descrip.Add(new Alumno());
            Descrip[1].Nombre = "Martin";
            Descrip.Add(new Alumno());
            Descrip[2].Nombre = "Manny";
            Descrip.Add(new Alumno());
            Descrip[3].Nombre = "Yisus Crais";

            Alumno alumno = new Alumno();
            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT12358";

            alumno.lista.Add(new Materia());
            alumno.lista.Add(matematicas);

            alumno.lista[0].Nombre = "Historia";
            alumno.lista[0].Identificador = "HT96465";

            alumno.lista.Add(new Materia());
            alumno.lista[2].Nombre = "Español";
            alumno.lista[2].Identificador = "ES852";
            
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.Clear();
            Console.WriteLine("Alumno: " + alumno.Nombre);
            Console.WriteLine("Numero de materias: " + alumno.lista.Count);

            foreach (Alumno Nombre in Descrip)
            {

                Console.WriteLine("Nombre: " + Nombre.Nombre);
                foreach (Materia materia in alumno.lista)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }
            Console.ReadLine();
            
        }
    }
}
