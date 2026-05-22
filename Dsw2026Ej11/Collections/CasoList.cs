using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private readonly List<Alumno> _alumnos = new();

    public void Add(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public List<Alumno> GetAll()
    {
        return _alumnos;
    }

    public Alumno? FindByName(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

    public bool Remove(Alumno alumno)
    {
        return _alumnos.Remove(alumno);
    }

    public void RemoveAt(int index)
    {
        _alumnos.RemoveAt(index);
    }
}
