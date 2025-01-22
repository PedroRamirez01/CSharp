using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, C#!");

            // Variables
            string myString = "Esta es una cadena de texto";    // string es un tipo de dato que almacena texto
            int myInt = 10; // int es un tipo de dato que almacena números enteros
            double myDouble = 10.5; // double es un tipo de dato que almacena números decimales
            float myFloat = 10.5f;  // float es un tipo de dato que almacena números decimales
            bool myBool = true; // bool es un tipo de dato que almacena valores booleanos (true o false)
            char myChar = 'A';  // char es un tipo de dato que almacena un solo caracter
            dynamic myDynamic = "Hola"; // dynamic es un tipo de dato que puede cambiar de tipo en tiempo de ejecución
            myDynamic = 10;             //lo malo del Dynamic es que puede dar errores en ejecución si no se maneja correctamente
            myDynamic = true;
            myDynamic = 10.5;

            Console.WriteLine(myString);
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myFloat);
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);
            Console.WriteLine(myDynamic);

            // Colecciones
            var myArrayInt = new int[5] { 1, 2, 3, 4, 5 }; // Array es un tipo de dato que almacena una colección de elementos
            var myArrayString = new string[5] { "value1", "value2", "value3", "value4", "value5" }; // Array es un tipo de dato que almacena una colección de elementos
            var myDictionary = new Dictionary<string, string>   // Dictionary es un tipo de dato que almacena pares de clave-valor
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key3", "value3" }
            };
            var mySet = new HashSet<string>() { "Hola", "Mundo", "C#", "Hola" }; // HashSet es un tipo de dato que almacena valores únicos

            Console.WriteLine(myArrayInt[0]);
            Console.WriteLine(myArrayString[3]);
            Console.WriteLine(myDictionary["key1"]);
            Console.WriteLine(mySet.Count); // retorna valor 3, ya que el valor "Hola" se repite

            // Bucles
            Console.WriteLine("Bucle for");
            for (int i = 0; i < 10; i++)    // for es un bucle que se ejecuta un número determinado de veces
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bucle foreach");
            foreach (var item in myArrayString) // foreach es un bucle que se ejecuta por cada elemento de una colección
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Bucle foreach - dictionary");
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Key + " - " + item.Value);   // item.Key es la clave y item.Value es el valor
            }
            Console.WriteLine("Bucle foreach - HashSet");   
            foreach (var item in mySet)
            {
                Console.WriteLine(item);    // solo se imprimirá una vez el valor "Hola"
            }

            // Funciones
            Console.WriteLine(Multiplicacion(5, 10));
            
            Persona persona = new Persona("Juan", 30);
            persona.Saludar();
        }

        static int Multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
    }
}

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void Saludar()
    {
        Console.WriteLine("Hola, mi nombre es " + Nombre);
    }
}
