namespace itm.csharp.basic
{
    /*Solicita al usuario un número y eleva este número al cuadrado solo si es positivo*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            int cuad = (int)Math.Pow(num, 2);
            if (num >= 0)
            {
                Console.WriteLine($"El cuadrado de {num} es: {cuad}.");
            }
            else if(num < 0)
            {
                Console.WriteLine("Número negativo.");
            }
        }
    }

    /* Solicita al usuario dos números. Si el primero es mayor, devuelva su doble, de lo contrario devuelva el triple del segundo.*/
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el número 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El doble de {num1} es: {num1 * 2}");
            }
            else
            {
                Console.WriteLine($"El triple de {num2} es: {num2 * 3}");
            }
        }
    }

    /*Pide al usuario un número. Si es positivo, devuelve su raíz cuadrada, de lo contrario, devuelve su cuadrado*/
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número: ");
            double num = double.Parse(Console.ReadLine());
            double raiz = Math.Sqrt(num);

            if (num >= 0)
            {
                Console.WriteLine($"La raíz cuadrada de {num} es: {raiz}");
            }
            else
            {
                Console.WriteLine($"El cuadadro de {num} es: {num * num}");
            }
        }
    }

    /*Pide al usuario el radio de un círculo y calcula su perímetro*/
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio del circulo: ");
            double rad = double.Parse(Console.ReadLine());
            double perimetro = 2 * Math.PI * rad;
            Console.WriteLine($"El perimetro del circulo con radio {rad} es: {perimetro}");
        }
    }

    /*Solicita al usuario un número entre 1 y 7 y muestra el día de la semana correspondiente, pero solo considerando los días laborables*/
    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Número fuera del rango laboral.");
                    break;
                case 7:
                    Console.WriteLine("Número fuera del rango laboral.");
                    break;
                default:
                    Console.WriteLine("Número no válido");
                    break;
            }
        }
    }

    /*Solicita al usuario su salario anual y, si este excede los 12000, muestra el impuesto a pagar que es el 15% del excedente.*/
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario anual:");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 12000 ? 0.15 * salario : 0;
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
        }
    }

    /*Solicita dos números y muestra el residuo de la división del primero entre el segundo.*/
    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Número a dividir:");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor:");
                double divisor = double.Parse(Console.ReadLine());
                Console.WriteLine($"Residuo: {n % divisor}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar la operación!");
            }
        }
    }

    /*Calcula y muestra la suma de los números pares entre 1 y 50*/
    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 0; i <= 50; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de números pares entre 1 y 50 es: {suma}");
        }
    }

    /*Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones*/
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese numerador de la primera fracción:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la primera fracción:");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numerador de la segunda fracción:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la segunda fracción:");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Restar(fraccion2);

                Console.WriteLine($"La diferencia de {fraccion1} y {fraccion2} es: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Restar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

    /* Pide una palabra al usuario y muestra la longitud de esa palabra.*/
    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine().ToLower();
            int longitud = palabra.Length;
            Console.WriteLine($"La longitud de la palabra es: {longitud}");
        }
    }

    /*Pide al usuario cuatro números y muestra el promedio.*/
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Introduce el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número:");
            double num4 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
        }
    }

    /*Pide al usuario cinco números y muestra el más pequeño.*/
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce el número {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"El número más pequeño de la lista es: {numeros.Min()}");
        }
    }

    /*Pide una palabra al usuario y devuelve el número de vocales en esa palabra*/
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Escribe una palabra: ");
            string palab = Console.ReadLine().ToLower();
            int conta = 0;

            for (int i = 0; i < palab.Length; i++)
            {
                if (palab[i] == 'a' || palab[i] == 'e' || palab[i] == 'i' || palab[i] == 'o' || palab[i] == 'u')
                {
                    conta++;
                }
            }
            Console.WriteLine($"La cantidad de vocales en la palabra es de: {conta}");
        }
    }

    /*Pide un número al usuario y devuelve el factorial de ese número.*/
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int number = int.Parse(Console.ReadLine());
            int r = 1;

            for (int i = number; i > 0; i--)
            {
                r = i * r;
            }
            Console.WriteLine($"El factorial de {number} es de: {r}");
        }
    }

    /*Pide un número al usuario y verifica si está en el rango de 10 a 20(ambos incluidos).*/
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"El número {numero} está fuera del rango de 10 a 20.");
            }
        }
    }

}


