using System;
using System.Collections;

  public class PruebaArrayList
 {
     private static readonly string[] colores =
     { "MAGENTA", "ROJO", "BLANCO", "AZUL", "CYAN" };
 private static readonly string[] eliminarColores =
 { "ROJO", "BLANCO", "AZUL" };

  // crea un objeto ArrayList, le agrega los colores y lo manipula
 public static void Main(string[] args)
 {
     ArrayList lista = new ArrayList(1); // capacidad inicial de 1
    
  // agrega los elementos del arreglo colores // al objeto ArrayList lista
 foreach (string color in colores)
         lista.Add(color); // agrega el color al objeto ArrayList lista
    
  // agrega los elementos en el arreglo eliminarColores al 
 // objeto ArrayList eliminarLista con el constructor de ArrayList
 ArrayList eliminarLista = new ArrayList(eliminarColores);
    
  Console.WriteLine("ArrayList: ");
     MostrarInformacion(lista); // imprime la lista en pantalla
    
 // elimina del objeto ArrayList lista los colores en eliminarLista
 EliminarColores(lista, eliminarLista);
   
 Console.WriteLine("\nArrayList después de llamar a EliminarColores: ");
     MostrarInformacion(lista); // imprime en pantalla el contenido de lista
    } // fin del método Main

  // muestra información sobre el contenido de un arreglo llamado lista
 private static void MostrarInformacion(ArrayList arregloLista)
 {
     // itera a través del arreglo lista con una instrucción foreach
 foreach (object elemento in arregloLista)
         Console.Write("{0} ", elemento); // invoca a ToString
    
  // muestra el tamaño y la capacidad
 Console.WriteLine("\nTamaño = {0}; Capacidad = {1}",
 arregloLista.Count, arregloLista.Capacity);
    
  int index = arregloLista.IndexOf("AZUL");
    
 if (index != -1)
        Console.WriteLine("El arreglo lista contiene AZUL en el índice {0}.",
         index);
     else
       Console.WriteLine("El arreglo lista no contiene AZUL.");
     } // fin del método MostrarInformacion

  // elimina de primeraLista los colores especificados en segundaLista
 private static void EliminarColores(ArrayList primeraLista,
 ArrayList segundaLista)
    {
        // itera a través del segundo objeto ArrayList como si fuera un arreglo
 for (int cuenta = 0; cuenta < segundaLista.Count; cuenta++)
           primeraLista.Remove(segundaLista[cuenta]);
        } // fin del método EliminarColores
 } // fin de la clase PruebaArrayList