// See https://aka.ms/new-console-template for more information

List<Curso> cursos = new List<Curso>();
Console.Write("Ingrese la cantidad de los cursos que desea registrar: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	Curso c = new Curso();
	Console.WriteLine();
	Console.WriteLine($"Curso #{i + 1}");

	Console.Write("Nombre del curso: ");
	c.Nombre = Console.ReadLine();

	Console.Write("Créditos: ");
	c.Creditos = int.Parse(Console.ReadLine());

	Console.Write("Nota promedio del curso: "); 
	c.NotaPromedio = double.Parse(Console.ReadLine());

	cursos.Add(c);
}
Curso mejor = cursos[0];
Console.Clear();
Console.WriteLine("==== CURSOS REGISTRADOS ====");

foreach (Curso c in cursos)
{
	c.MostrarDatos();
	if (c.NotaPromedio > mejor.NotaPromedio)
	{
		mejor = c; 
	}
}
Console.WriteLine();
Console.WriteLine("Curso con mejor promedio:");
mejor.MostrarDatos();

class Curso
{
	public string Nombre;
	public int Creditos;
	public double NotaPromedio;
	public string EvaluarRendimiento()
	{
		if (NotaPromedio >= 80)
		{
			return "Excelente";

		}
		else if (NotaPromedio >= 61)
		{
			return "Aceptable";

		}
		else
		{
			return "Bajo";

		}
	}
	public void MostrarDatos()
	{
		Console.WriteLine($"Curso: {Nombre} | Créditos: {Creditos} | Promedio: {NotaPromedio:F2} | Rendimiento: {EvaluarRendimiento()}");
	}
}