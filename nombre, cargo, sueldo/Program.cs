// See https://aka.ms/new-console-template for more information
Console.WriteLine("datos del empleado");

// Solicitar al usuario que ingrese los datos del empleado
Console.WriteLine("Ingrese el nombre del empleado:");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese el cargo del empleado:");
string cargo = Console.ReadLine();

Console.WriteLine("Ingrese el sueldo del empleado:");
double sueldo = Convert.ToDouble(Console.ReadLine());

// Llamar al método para mostrar los resultados
   MostrarInformacionEmpleado(nombre, cargo, sueldo);
    

    static void MostrarInformacionEmpleado(string nombre, string cargo, double sueldo)
{
    // Mostrar los resultados en pantalla
    Console.WriteLine("Nombre del empleado: " + nombre);
    Console.WriteLine("Cargo del empleado: " + cargo);
    Console.WriteLine("Sueldo del empleado: " + sueldo);
}