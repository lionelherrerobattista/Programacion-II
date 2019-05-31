using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Title = "Ejercicio Nro 59";

      string encabezado;

      // Mi central
      Centralita c = new Centralita("Fede Center");

      // Mis 4 llamadas
      Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
      Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
      Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
      Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
      Provincial l5;
      Local l6;
      encabezado = String.Format("{0, 3} {1, 15} {2, 15} {3, 15}\n", "Duracion", "Destino", "Origen", "Costo");
      //Llamadas a Serializar
      Console.WriteLine("Llamada a guardar: ");
      Console.WriteLine(encabezado);
      Console.WriteLine(l2.ToString());
      Console.WriteLine(l1.ToString());

      l2.Guardar();
      l1.Guardar();
      l5 = l2.Leer();
      l6 = l1.Leer();

      Console.WriteLine("Copia de la llamada");
      
      Console.WriteLine(encabezado);
      Console.WriteLine(l5.ToString());
      Console.WriteLine(l6.ToString());

      /*
      // Las llamadas se irán registrando en la Centralita.
      // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
      try
      {
        c = c + l1;

        c = c + l1;//lanza excepción

        System.Threading.Thread.Sleep(2000);



      }
      catch (Exception e1)
      {
        Console.WriteLine(e1.Message);
      }
      finally
      {
        try
        {
          c = c + l2;

          System.Threading.Thread.Sleep(2000);

          c = c + l3;

          System.Threading.Thread.Sleep(2000);

          c = c + l4;//lanza excepción
        }
        catch (Exception e2)
        {
          Console.WriteLine(e2.Message);
        }

      }

      c.OrdenarLlamadas();

      Console.WriteLine("");
      Console.WriteLine(c.ToString());
      */



      //Muestro el contenido del Log
      Console.WriteLine(c.Leer());

      Console.ReadKey();
    }
  }
}
