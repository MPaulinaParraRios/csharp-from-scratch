/*conditionals*/
//Console.WriteLine("Ingrese por favor un número: ");
//int num = int.Parse(Console.ReadLine());
//if (num > 0) Console.WriteLine("Positivo");
//else if (num < 0) Console.WriteLine("Negativo");
//else Console.WriteLine("Es cero");

/*End conditionals*/

/*Operators*/
Console.WriteLine("Ingrese por favor un número: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese por favor el segundo número: ");
double b = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {a+b}, Resta: {a-b}, Multiplicación: {a*b}, División: {(b!=0 ? a/b: Indeterminado)}");
/*End Operators*/
