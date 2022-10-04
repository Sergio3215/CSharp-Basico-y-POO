// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num = 0;

            //num = 123;

            //bool myBool = false;

            //decimal decim = 0;

            //float flot = 0.2f;

            //int[] arrayNumeros = { 2, 3, 4 };
            //Console.WriteLine("------Arrays-----");
            //foreach (int numeros  in arrayNumeros)
            //{
            //    Console.WriteLine(numeros);
            //}

            //List<string> strArr = new List<string>();
            //strArr.Add("hola");
            //strArr.Add("adios");
            //strArr.Add("Hi");
            //strArr.Add("Bye");


            //Console.WriteLine("------Lista de strings-----");
            //foreach (string str in strArr)
            //{
            //    Console.WriteLine(str);
            //}


            //Console.WriteLine("-----Mostrando Numeros--------");
            //num++;
            //Console.WriteLine(num);

            //Dictionary<int, string> usuario = new Dictionary<int, string>();
            //// [id,usuario]
            //usuario.Add(1, "jose");
            //usuario.Add(2, "Martas");
            //usuario.Add(3, "Javier");

            //foreach(var obj in usuario)
            //{
            //    if (obj.Key == 1)
            //    {
            //        Console.WriteLine(obj);
            //    }
            //}


            Animales animal = new Animales();
            animal.acciones();
            string frases = animal.str;

            Gato _gato =  new Gato();
            _gato.acciones();

            myInterface name = new myInterface()
            {
               nombre = "Jhon",
               apellido = "Smith"
            };

            myInterface name2 = new myInterface()
            {
                nombre = "Marta",
                apellido = "MAla"
            };
        }

    }
    class Gato : Animales
    {

    }

    class Animales
    {
        public string str = "hola";
        public Animales()
        {

        }
       private void caminar()
        {
            Console.WriteLine("el animal esta caminando");
        }

       private void rugir()
        {
            Console.WriteLine("El animal esta rugiendo");
        }

        public void acciones()
        {
            caminar();
            rugir();
        }
    }
}

class myInterface
{
   public string nombre { get; set; }
    public string apellido { get; set; }
}