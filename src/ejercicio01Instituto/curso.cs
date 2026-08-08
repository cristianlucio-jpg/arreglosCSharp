
/// <summary>
/// Clase que representa un curso académico.
/// Contiene código, nombre y horario.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class curso
{
  
    public int codigoCurso { get; set; }

    public string? nombreCurso { get; set; } = string.Empty;

    public string? horarioCurso { get; set; } = string.Empty;

    /// <summary>
    /// Devuelve la información básica del curso en formato de texto.
    /// </summary>
    /// <returns>Cadena con código y nombre del curso.</returns>
    public string informacionCurso()
    {
        return $"InformacionCurso:\n\tCódigo: {codigoCurso}\n\tNombre: {nombreCurso}\n\tHorario: {horarioCurso}";
    }
}