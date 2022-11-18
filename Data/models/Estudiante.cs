using System.ComponentModel.DataAnnotations.Schema;

namespace Estudiantes_2019_1485.Data.models;

public class Estudiante
{
    public int EstudianteID  {get; set;}
    public string Nombres  {get; set;}= null!;
    public string Apellidos  {get; set;}= null!;
    public DateTime FechaNacimiento   {get; set;}
    public string Matricula {get; set;}= null!;
    public int CarreraId {get; set;}
    public virtual Carrera? Carrera { get; set; }
    [NotMapped]
    public string NombreCompleto => Nombres + " " + Apellidos;
}