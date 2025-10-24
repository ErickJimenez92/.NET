using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------ARRAY------------------------------------
            //int[] numeros = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Ingrese número: " + (i + 1) + ": ");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n numeros ingresados: ");
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}
            //int suma = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    suma += numeros[i];
            //}
            //Console.WriteLine("La suma de los números es: " + suma);

            //----------------------------------LISTA------------------------------------
            //List<int> numeros = new List<int>();
            //numeros.Add(10);
            //numeros.Add(20);
            //numeros.Add(30);
            //Console.WriteLine("Numeros en la lista: ");
            //foreach (int item in numeros) 
            //{ 
            //    Console.WriteLine(item);
            //}
            ////Acceder a un elemento por su índice
            //int primerNumero = numeros[1];
            //Console.WriteLine($"El numero en la lista es: {primerNumero}" );
            ////Modificar un elemento en la lista
            //numeros[2] = 50;
            //Console.WriteLine($"Numero modificado: {numeros[2]}");
            ////Insertar un elemento en una posición especifica
            //numeros.Insert(2, 15);
            //Console.WriteLine($"Numero insertado: {numeros[2]}");
            ////Eliminar un elemento de la lista especifica
            //numeros.RemoveAt(1);
            ////Eliminar por valor
            //numeros.Remove(10);

            //--------------EJERCICIO 1------------------------
            //List<string> productos = new List<string>();
            //List<double> precios = new List<double>();

            //int opcion = 0;

            //while (opcion != 5)
            //{
            //    Console.WriteLine("====== MENu DE PRODUCTOS ======");
            //    Console.WriteLine("1. Agregar producto");
            //    Console.WriteLine("2. Mostrar productos");
            //    Console.WriteLine("3. Actualizar producto");
            //    Console.WriteLine("4. Eliminar producto");
            //    Console.WriteLine("5. Salir");
            //    Console.Write("Elige una opción: ");
            //    opcion = int.Parse(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.Write("Nombre del producto: ");
            //        string nombre = Console.ReadLine();
            //        Console.Write("Precio: ");
            //        double precio = double.Parse(Console.ReadLine());
            //        productos.Add(nombre);
            //        precios.Add(precio);
            //        Console.WriteLine("Producto agregado ");
            //    }
            //    else if (opcion == 2)
            //    {
            //        Console.WriteLine("=== LISTA DE PRODUCTOS ===");
            //        for (int i = 0; i < productos.Count; i++)
            //        {
            //            Console.WriteLine($"{i + 1}. {productos[i]} - ${precios[i]}");
            //        }
            //    }
            //    else if (opcion == 3)
            //    {
            //        Console.Write("Número del producto a actualizar: ");
            //        int num = int.Parse(Console.ReadLine()) - 1;
            //        if (num >= 0 && num < productos.Count)
            //        {
            //            Console.Write("Nuevo nombre: ");
            //            productos[num] = Console.ReadLine();
            //            Console.Write("Nuevo precio: ");
            //            precios[num] = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Producto actualizado ");
            //        }

            //    }
            //    else if (opcion == 4)
            //    {
            //        Console.Write("Número del producto a eliminar: ");
            //        int num = int.Parse(Console.ReadLine()) - 1;
            //        if (num >= 0 && num < productos.Count)
            //        {
            //            productos.RemoveAt(num);
            //            precios.RemoveAt(num);
            //            Console.WriteLine("Producto eliminado ");
            //        }

            //    }
            //    else if (opcion == 5)
            //    {
            //        Console.WriteLine("Saliendo del programa... ");
            //    }

            //    Console.WriteLine();
            //}


            //------------------------------CREAR OBJETO AUTO-------------------
            //Auto miAuto = new Auto("Toyota", "Corolla", "2020");
            //miAuto.MostrarInfo();

            //Auto camioneta = new Auto("Toyota", "TXL", "2026");
            //camioneta.MostrarInfo();

            //Auto camion = new Auto("FORD", "NPR", "2020");

            ////Editar info
            //camion.Marca = "Chevrolet";
            //camion.MostrarInfo();

            //-----------------------------CREAR OBJETO ESTUDIANTE-------------------
            //Console.WriteLine("Ingrese el nombre del estudiante ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese la edad del estudiante");
            //int edad = int.Parse(Console.ReadLine());

            //Estudiante estudiante1 = new Estudiante(nombre, edad);
            //estudiante1.VerificarEdad();

            //---------------------------PRODUCTOS-----------------------------------
            //Producto.ProductoCrud producto = new Producto.ProductoCrud();
            //bool salir = false;
            //while (!salir)
            //{
            //    Console.WriteLine("\nSeleccione una opción");
            //    Console.WriteLine("1. Agregar producto");
            //    Console.WriteLine("2. Mostrar productos");
            //    Console.WriteLine("3. Actualizar producto");
            //    Console.WriteLine("4. Eliminar producto");
            //    Console.WriteLine("5. Salir");
            //    string opcion = Console.ReadLine();
            //    switch (opcion)
            //    {
            //        case "1":
            //            producto.AgregarProducto();
            //            break;
            //        case "2":
            //            producto.MostrarProductos();
            //            break;
            //        case "3":
            //            producto.ActualizarProducto();
            //            break;
            //        case "4":
            //            producto.EliminarProducto();
            //            break;
            //        case "5":
            //            salir = true;
            //            break;
            //        default:
            //            Console.WriteLine("Opcion no valida. Intenta de nuevo");
            //            break;
            //    }

            //}

            //-------------------------------------PERSONAS-------------------------------------
            //Console.WriteLine("=== PROGRAMA PERSONA ===");
            ////SOLICITAR DATOS
            //Console.WriteLine("Ingrese el nombre: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese la edad: ");
            //int edad = int.Parse(Console.ReadLine());

            //char genero;
            //do
            //{
            //    Console.WriteLine("Ingrese el género (F/M): ");
            //    genero = char.Parse(Console.ReadLine().ToUpper());
            //}
            //while (genero != 'F' && genero != 'M');
            //Console.WriteLine("Ingrese el telefono: ");
            //string telefono = Console.ReadLine();

            ////crear objeto
            //Persona persona = new Persona(nombre, edad, genero, telefono);
            //int opcion;
            //do
            //{
            //    Console.WriteLine("\nSeleccione una opción");
            //    Console.WriteLine("1. Imprimir detalles de la persona ");
            //    Console.WriteLine("2. Calcular edad en dias");
            //    Console.WriteLine("3. Salir");
            //    Console.WriteLine("Opción: ");
            //    opcion = int.Parse(Console.ReadLine());
            //    switch (opcion)
            //    {
            //        case 1:
            //            persona.ImprimirDetalles();
            //            break;
            //        case 2:
            //            persona.CalcularEdadEnDias();
            //            break;
            //        case 3:
            //            Console.WriteLine("Saliendo del programa...");
            //            break;
            //        default:
            //            Console.WriteLine("Opcion no valida, intente nuevamente.");
            //            break;
            //    }
            //} while (opcion != 3);

        }
    }
}