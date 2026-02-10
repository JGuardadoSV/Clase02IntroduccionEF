
using Clase02IntroduccionEF;

using var db = new Contexto();

// Crea la base de datos si no existe
db.Database.EnsureCreated();


var nuevoAlumno = new Alumno
{
    Nombre = "Josue",
    Apellido = "Guardado",
    Correo = "josue.perez@email.com",
    FechaInscripcion = DateTime.Now
};

db.Alumnos.Add(nuevoAlumno);
db.SaveChanges();

Console.WriteLine("Alumno guardado con éxito.");


// 2. Leer (Consultar)
Console.WriteLine("\nLista de alumnos en la base de datos:");
var lista = db.Alumnos.ToList();

foreach (var a in lista)
{
    Console.WriteLine($"ID: {a.Id} | Nombre: {a.Nombre} {a.Apellido} | Email: {a.Correo}");
}
