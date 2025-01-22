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

            // Arreglos
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
            Console.WriteLine("Bucle For");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public int Multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
    }
}
