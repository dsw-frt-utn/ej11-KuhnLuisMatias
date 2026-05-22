using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    public static void EjemploList()
    {
        var lista = new CasoList();
        lista.Add(new Alumno(1, "Luis", 8.5));
        lista.Add(new Alumno(2, "Ana", 9.0));
        lista.Add(new Alumno(3, "Pedro", 7.5));

        Console.WriteLine("Lista de alumnos:");
        foreach (var a in lista.GetAll())
            Console.WriteLine(a);

        var encontrado = lista.FindByName("Ana");
        Console.WriteLine($"\nBuscando 'Ana': {(encontrado != null ? encontrado.ToString() : "No existe")}");

        var noEncontrado = lista.FindByName("Carlos");
        Console.WriteLine($"Buscando 'Carlos': {(noEncontrado != null ? noEncontrado.ToString() : "No existe")}");

        lista.Remove(encontrado!);
        Console.WriteLine("\nLista después de eliminar a Ana:");
        foreach (var a in lista.GetAll())
            Console.WriteLine(a);

        lista.RemoveAt(0);
        Console.WriteLine("\nLista después de eliminar el primer elemento:");
        foreach (var a in lista.GetAll())
            Console.WriteLine(a);
    }

    public static void EjemploDictionary()
    {
        var dicc = new CasoDictionary();
        dicc.Add(new Alumno(10, "María", 8.0));
        dicc.Add(new Alumno(20, "Juan", 6.5));
        dicc.Add(new Alumno(30, "Sofía", 9.5));

        Console.WriteLine("Diccionario de alumnos:");
        foreach (var kvp in dicc.GetAll())
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");

        var encontrado = dicc.Find(20);
        Console.WriteLine($"\nBuscando legajo 20: {(encontrado != null ? encontrado.ToString() : "No existe")}");

        var noEncontrado = dicc.Find(99);
        Console.WriteLine($"Buscando legajo 99: {(noEncontrado != null ? noEncontrado.ToString() : "No existe")}");

        dicc.Remove(20);
        Console.WriteLine("\nDiccionario después de eliminar legajo 20:");
        foreach (var kvp in dicc.GetAll())
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }

    public static void EjemploLinq()
    {
        var linq = new CasoLinq();

        Console.WriteLine("1. Primer libro: " + linq.GetPrimero()?.Titulo);
        Console.WriteLine("2. Último libro: " + linq.GetUltimo()?.Titulo);
        Console.WriteLine("3. Suma de precios: " + linq.GetTotalPrecios());
        Console.WriteLine("4. Promedio de precios: " + linq.GetPromedioPrecios());

        Console.WriteLine("5. Libros con Id > 15:");
        foreach (var l in linq.GetListById())
            Console.WriteLine($"   {l.Id} - {l.Titulo}");

        Console.WriteLine("6. Libros con formato moneda:");
        foreach (var s in linq.GetLibros())
            Console.WriteLine("   " + s);

        Console.WriteLine("7. Mayor precio: " + linq.GetMayorPrecio()?.Titulo);
        Console.WriteLine("8. Menor precio: " + linq.GetMenorPrecio()?.Titulo);

        Console.WriteLine("9. Libros con precio mayor al promedio:");
        foreach (var l in linq.GetMayorPromedio())
            Console.WriteLine($"   {l.Titulo} - {l.Precio:C}");

        Console.WriteLine("10. Libros ordenados por título descendente:");
        foreach (var l in linq.GetOrdenadosPorTituloDesc())
            Console.WriteLine("   " + l.Titulo);
    }
}
