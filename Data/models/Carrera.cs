using System.ComponentModel.DataAnnotations.Schema;

namespace Estudiantes_2019_1485.Data.models;

public class Carrera
{
    public Carrera()
    {
        
    }
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
}