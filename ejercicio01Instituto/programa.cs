
using System.Globalization;
public class programa
{
/// <summary>
/// Clase principal del programa.
/// Permite ingresar un curso de pregrado por consola y mostrar su información.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
    public static void Main()
    {
        pregrado cursoMatematicas = new pregrado();

        Console.Write("Código: ");
        cursoMatematicas.codigoCurso = Convert.ToInt32(Console.ReadLine());

        Console.Write("Materia: ");
        cursoMatematicas.nombreCurso = Console.ReadLine();

        Console.Write("Horario (dd HH:mm - HHmm) : ");
        cursoMatematicas.horarioCurso = Console.ReadLine();

        Console.Write("Créditos Académicos: ");
        cursoMatematicas.creditosAcademicos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Intensidad Horaria Semanal: ");
        cursoMatematicas.intensidadHorariaSemanal = Convert.ToDouble(Console.ReadLine());

       
    try
    {
        Console.Write("Nota Aprobatoria: ");
        string entrada = Console.ReadLine();

        // Reemplaza punto por coma para que funcione en es-CO
        entrada = entrada.Replace(".", ",");

        cursoMatematicas.notaMinimaAprobatoria = Convert.ToDouble(entrada, new CultureInfo("es-CO"));
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Debe ingresar un número decimal válido (ejemplo: 4,5).");
    }
        
        Console.WriteLine(cursoMatematicas.InformacionCurso());
        Console.WriteLine(cursoMatematicas.informacionPregrado());
    }
}
                        