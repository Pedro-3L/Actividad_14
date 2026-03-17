// See https://aka.ms/new-console-template for more information

Dictionary<int, Estudiante> estudiantes = new Dictionary<int, Estudiante>();
Console.Write("Ingrese la cantidad de estudiantes que desea registrar: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	Console.WriteLine();
	Console.WriteLine($"Registro #{i + 1}");

	Console.Write("Carnet: ");
	int carnet = int.Parse(Console.ReadLine());

	Estudiante e = new Estudiante();
	Console.Write("Nombre: "); 
	e.Nombre = Console.ReadLine();

	Console.Write("Carrera: ");
	e.Carrera = Console.ReadLine();

	Console.Write("Nota final: "); 
	e.Nota = double.Parse(Console.ReadLine());

	estudiantes[carnet] = e;
}
Console.Clear();
Console.WriteLine("==== LISTADO GENERAL ====");
foreach (KeyValuePair<int, Estudiante> item in estudiantes)
{
	Console.Write($"Carnet: {item.Key} | ");
	item.Value.MostrarDatos();
}
Console.WriteLine();
Console.Write("Ingrese un carnet para buscar: ");
int buscar = int.Parse(Console.ReadLine());

if (estudiantes.ContainsKey(buscar))
{
	Console.WriteLine();
	Console.WriteLine("Estudiante encontrado:");
	estudiantes[buscar].MostrarDatos();
}
else
{
	Console.WriteLine("Estudiante no encontrado");
}
class Estudiante
{
	public string Nombre;
	public string Carrera;
	public double Nota;
	public string ObtenerEstado()
	{
		return Nota >= 61 ? "Aprobado" : "Reprobado";
	}
	public void MostrarDatos()
	{
		Console.WriteLine($"Nombre: {Nombre} | Carrera: {Carrera} | Nota: {Nota:F2} | Estado: {ObtenerEstado()}");
	}
}
