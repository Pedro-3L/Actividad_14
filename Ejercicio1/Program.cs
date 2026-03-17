// See https://aka.ms/new-console-template for more information

List<Estudiante> estudiantes = new List<Estudiante>();
Console.Write("Ingrese la cantidad de estudiantes desea registrar: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	Estudiante e = new Estudiante();
	Console.WriteLine();
	Console.WriteLine($"Estudiante #{i + 1}");

	Console.Write("Nombre: ");
	e.Nombre = Console.ReadLine();

	Console.Write("Nota 1: ");
	e.Nota1 = double.Parse(Console.ReadLine());

	Console.Write("Nota 2: ");
	e.Nota2 = double.Parse(Console.ReadLine());

	Console.Write("Nota 3: ");
	e.Nota3 = double.Parse(Console.ReadLine());

	estudiantes.Add(e);
}

Estudiante mejor = estudiantes[0];
Console.Clear();
Console.WriteLine("===== LISTADO DE ESTUDIANTES ====");

foreach (Estudiante e in estudiantes)
{
	e.MostrarDatos();
	if (e.CalcularPromedio() > mejor.CalcularPromedio())
	{
		mejor = e;
	}
}
Console.WriteLine();
Console.WriteLine("Mejor estudiante:");
mejor.MostrarDatos();

class Estudiante
{
	public string Nombre;
	public double Nota1;
	public double Nota2;
	public double Nota3;
	public double CalcularPromedio()
	{
		return (Nota1 + Nota2 + Nota3) / 3;
	}
	public string ObtenerEstado()
	{
		if (CalcularPromedio() >= 61)
		{
			return "Aprobado";

		}
		else
		{
			return "Reprobado";

		}
	}
	public void MostrarDatos()
	{
		Console.WriteLine($"Nombre: {Nombre} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado()}");
	}
}