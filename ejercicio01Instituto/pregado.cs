/// <summary>
/// Clase que representa un curso de pregrado.
/// Hereda de Curso y añade créditos académicos, intensidad horaria y nota mínima aprobatoria.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
public class pregrado : curso
{
   
    public int creditosAcademicos { get; set; }
    public double intensidadHorariaSemanal { get; set; }
    public double notaMinimaAprobatoria { get; set; }

    /// <summary>
    /// Devuelve la información detallada del curso de pregrado.
    /// </summary>
    /// <returns>Cadena con créditos académicos e información de nota aprobatoria.</returns>
    public string informacionPregrado()
    {
        var info = string.Format(
            "Informacion Pregrado:\n\tCréditos Académicos: {0}\n\tIntensidad Horaria: {1}\n\tNota Aprobatoria: {2}",
            creditosAcademicos, intensidadHorariaSemanal, notaMinimaAprobatoria
        );
        return info;
    }
}
