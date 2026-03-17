// See https://aka.ms/new-console-template for more information

List<Empleado> empleados = new List<Empleado>();
Console.Write("Ingrese la cantidad de empleados que desea ingresar: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
	Empleado e = new Empleado();
	Console.WriteLine();
	Console.WriteLine($"Empleado #{i + 1}");

	Console.Write("Nombre: "); 
	e.Nombre = Console.ReadLine();

	Console.Write("Puesto: ");
	e.Puesto = Console.ReadLine();

	Console.Write("Salario mensual: ");
	e.SalarioMensual = double.Parse(Console.ReadLine());

	empleados.Add(e);
}
Console.Clear();
Console.WriteLine("==== LISTADO DE EMPLEADOS ====");
foreach (Empleado emp in empleados)
{
	emp.MostrarDatos();
}
class Empleado
{
	public string Nombre;
	public string Puesto;
	public double SalarioMensual;
	public double CalcularSalarioAnual() 
	{ 
		return SalarioMensual * 12; 
	}
	public double CalcularBono()
	{
		if (SalarioMensual >= 7000)
		{
			return SalarioMensual * 0.25;
		}
		else
		{
			return SalarioMensual * 0.05;
		}

	}
	public string ClasificarSalario()
	{
		if (SalarioMensual >= 7000)
		{
			return "Salario alto";

		}
		else if (SalarioMensual >= 4500)
		{
			return "Salario medio";
		}
		else
		{
			return "Salario básico";
		}

	}
	public void MostrarDatos()
	{
		Console.WriteLine($"Nombre: {Nombre} | Puesto: {Puesto} | Salario mensual: Q{SalarioMensual:F2} | Salario anual:Q{CalcularSalarioAnual():F2} | Bono: Q{CalcularBono():F2} | Nivel: {ClasificarSalario()}");
	}
}
