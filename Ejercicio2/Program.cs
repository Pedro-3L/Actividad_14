// See https://aka.ms/new-console-template for more information

List<Producto> productos = new List<Producto>();
Console.Write("Ingrese cuantos productos desea registrar: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	Producto p = new Producto();
	Console.WriteLine();
	Console.WriteLine($"Producto #{i + 1}");

	Console.Write("Nombre: ");
	p.Nombre = Console.ReadLine();

	Console.Write("Precio: ");
	p.Precio = double.Parse(Console.ReadLine());

	Console.Write("Cantidad: ");
	p.Cantidad = int.Parse(Console.ReadLine());

	productos.Add(p);
}
double totalInventario=0;
Producto mayorPrecio=productos[0];
Console.Clear();
Console.WriteLine("==== INVENTARIO ====");
foreach (Producto p in productos)
{
	p.MostrarDatos();
	totalInventario += p.CalcularValorInventario();
	if (p.Precio > mayorPrecio.Precio) 
	{ 
		mayorPrecio = p; 
	}
}
Console.WriteLine();
Console.WriteLine($"Valor total del inventario: Q{totalInventario:F2}");
Console.WriteLine();
Console.WriteLine("Producto con mayor precio:");
mayorPrecio.MostrarDatos();

class Producto
{
	public string Nombre;
	public double Precio;
	public int Cantidad;
	public double CalcularValorInventario()
	{
		return Precio * Cantidad;
	}
	public string ObtenerEstadoStock()
	{
		if (Cantidad == 0)
		{
			return "Sin existencia";

		}
		else if (Cantidad < 5)
		{
			return "Stock bajo";

		}
		else
		{
			return "Stock suficiente";

		}
	}
	public void MostrarDatos()
	{
		Console.WriteLine($"Producto: {Nombre} | Precio: Q{Precio:F2} | Cantidad: {Cantidad} | Total: Q{CalcularValorInventario():F2} | Estado:{ObtenerEstadoStock()}");
	}
}
