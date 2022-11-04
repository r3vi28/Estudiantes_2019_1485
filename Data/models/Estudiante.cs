using System.ComponentModel.DataAnnotations;

namespace Estudiantes_2019_1485.Data.models;

public class Estudiante
{
    [Key]
    public int EstudianteID { get; set; }
    public string Nombres { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public string FechaNacimiento { get; set; } = null!;
    public string Matricula { get; set; } = null!;
    public string Carrera { get; set; } = null!;

    public static Estudiante Crear(string nombres, string apellidos, string fechaNacimiento, string matricula, string carrera){
        return new Estudiante(){
            EstudianteID = 0,
            Nombres= nombres,
            Apellidos = apellidos,
            FechaNacimiento = fechaNacimiento,
            Matricula = matricula,
            Carrera = carrera
            };
    }

    public void Update(string nombres, string apellidos, string fechaNacimiento, string matricula, string carrera)
    {
        Nombres= nombres;
        Apellidos = apellidos;
        FechaNacimiento = fechaNacimiento;
        Matricula = matricula;
        Carrera = carrera;
    }
}