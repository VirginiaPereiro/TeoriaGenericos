using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class ColectorObjetos<Tipo> where Tipo:Libro
        //where le digo que sea de tipo libro
        //public class ColectorObjetos<Tipo> where Tipo:class de tipo clase
        //public class ColectorObjetos<Tipo> where Tipo:IEnumerable que sea una clase que implemete una interfaz IENumerable

        //Para hacer un generic, //<Tipo> Podemos poner lo que queramos entre los <>
    {
        private Tipo[] datos;
        
        //constructor y para contar el número de elementos
        public ColectorObjetos(int elementos)
        {
            datos=new Tipo[elementos];
        }

        //es una propiedad con índices de posicionamiento
        public Tipo this[int i]
        {
            get { return datos[i]; }
            set { datos[i] = value; }
        }

        //método borrar
        public void Borrar(Tipo t)
        {
            for (int i=0;i<datos.Length;i++)
            {
                if (datos[i]!=null && datos[i].Equals(t))
                {
                    datos[i] = default(Tipo);//null por defetoy va a ver el tipo
                }
            }
        }
    }

    

}
