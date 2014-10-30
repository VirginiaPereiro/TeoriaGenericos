using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //GENERIC, le digo que le voy a meter libros, sólo eso de ese objeto
            //mientras que un arraylist van a ser objetos
            //coge la clase ColectorObjetos y le digo que sea de libros 
            ColectorObjetos<Libro> co = new ColectorObjetos<Libro>(3);
            
            co[0]=new Libro(){Titulo="El padrino"};
            
            var l = new Libro() { Titulo = "Los pilares de la tierra" };
            co[1] = l;

            co[2]=new Libro();
            co[2].Titulo = "Un mundo sin fin";

            co.Borrar(co[0]);

            //LIST
            var lista = new List<Libro>();

            lista.Add(new Libro(){Titulo="Lo que sea"});
            lista.Add(new Libro() { Titulo = "Lo que sea" });
            lista.Add(new Libro() { Titulo = "bla bla" });
            lista.Add(new Libro() { Titulo = "Programar con C# es fácil" });

            //no hay que hacer castings, como habría que hacer en los arraylist
                    //var al = new ArrayList();
                    //var a = ((Libro) al[0]).Titulo;
            
            //más sencillo, se asegura
            Console.WriteLine(lista[2].Titulo);

            lista.RemoveAt(3);

            Console.WriteLine(lista.Count);

            foreach (var ll in lista)
            {
                Console.WriteLine(ll.Titulo);
            }
            Console.ReadLine();


            var textos = new List<String>()
            {//metemos los detalles de la lista
                "Uno",
                "Dos",
                "Tres",
                "Cuatro"
            };

            var canciones = new List<Cancion>()
            {
                new Cancion(),
                new Cancion(),
                new Cancion()
            };

            //DICTIONARY
                //la clave puede ser un objeto, al igual que el valor
                //la clave suele usarse un dato de tipo simple

            Dictionary<string,Libro>tablaLibros=new Dictionary<string, Libro>();
            
            //guardamos los objetos
            //creas el libro o lo guardas en memoria 
            tablaLibros.Add("A",new Libro(){Titulo="Uno"});
            tablaLibros.Add("B", new Libro() { Titulo = "Dos",
                                               Autor="Yo" });
            tablaLibros.Add("C", new Libro() { Titulo = "Tres" });
            tablaLibros.Add("D", new Libro() { Titulo = "Cuatro" });
            tablaLibros.Add("E", new Libro() { Titulo = "Cinco" });

            Console.WriteLine(tablaLibros["C"].Titulo + " " + tablaLibros["C"].Autor);

            //comprobar si una clave existe, porque sino ecxite la clave dará error
            if(tablaLibros.ContainsKey("Z"))
                Console.WriteLine("Z exsiste");
            
            //para eliminar un elemento
            tablaLibros.Remove("A");

            //para saber el número de elementos que tengo
            Console.WriteLine(tablaLibros.Count);

            //para vaciar el diccionario
            tablaLibros.Clear();

            Console.WriteLine(tablaLibros.Count);

            //Búsquedas en LISTAS
            //o es un objeto temporal
            //puedes hacer que la búsqueda te la ordene
            var lib = lista.Where(o => o.Titulo == "Programar con C# es fácil").OrderBy(o=>o.Titulo);
            
            if(lib.Any())//pregunto si hay alguna
                Console.WriteLine("Lo tengo");
            
            else 
                Console.WriteLine("No lo tengo");

            Console.ReadLine();
        }
    }
}
