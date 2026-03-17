// See https://aka.ms/new-console-template for more information

List<Libro> libros = new List<Libro>();
Console.Write("¿Cuántos libros desea registrar?: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	Libro l = new Libro();
	Console.WriteLine();
	Console.WriteLine($"Libro #{i + 1}");

	Console.Write("Título: "); 
	l.Titulo = Console.ReadLine();

	Console.Write("Autor: "); 
	l.Autor = Console.ReadLine();

	Console.Write("Categoría: "); 
	l.Categoria = Console.ReadLine();

	Console.Write("Cantidad de páginas: "); 
	l.Paginas = int.Parse(Console.ReadLine());

	libros.Add(l);
}
Libro mayor = libros[0];
Console.Clear();
Console.WriteLine("==== LISTADO DE LIBROS BIBLIOTECA ====");
foreach (Libro l in libros)
{
	l.MostrarDatos();
	if (l.Paginas > mayor.Paginas) { mayor = l; }
}
Console.WriteLine();
Console.WriteLine("Libro con más páginas:");
mayor.MostrarDatos();

class Libro
{
	public string Titulo;
	public string Autor;
	public string Categoria;
	public int Paginas;
	public string ClasificarTamaño()
	{
		if (Paginas < 200)
		{
			return "Corto";

		}
		else if (Paginas >= 200)
		{
			return "Mediano";

		}
		else
		{
			return "Extenso";
		}
	}
	public void MostrarDatos()
	{
		Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Categoría: {Categoria} | Páginas: {Paginas} | Tipo: {ClasificarTamaño()}");
	}
}