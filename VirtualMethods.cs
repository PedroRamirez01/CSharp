class VirtualMethods
{
    public class FiguraGeometrica
    {
        public virtual int Perimetro { get; set; }
        public virtual int Area { get; set; }
    }

    public class Rectangulo : FiguraGeometrica
    {
        public virtual int Ancho { get; set; }
        public virtual int Alto { get; set; }

        public override int Area { get { return Ancho * Alto; } }
        public override int Perimetro { get { return (2 * Ancho) + (2 * Alto); } }
    }

    public class Cuadrado : FiguraGeometrica
    {
        public int Lado { get; set; }
        public override int Area { get { return Lado * Lado; } }
        public override int Perimetro { get { return 4 * Lado; } }
    }

    public class Circulo : FiguraGeometrica
    {
        public int Radio { get; set; }
        public override int Area
        {   // sobre escribir el método de la clase base
            get
            {
                return (int)(3.1416 * Radio * Radio);
            }
        }
        public override int Perimetro
        {
            get
            {
                return (int)(2 * 3.1416 * Radio);
            }
        }
    }

    static void Main()
    {
        Rectangulo rectangulo = new Rectangulo();
        rectangulo.Ancho = 10;
        rectangulo.Alto = 5;
        Console.WriteLine("Rectangulo Area: " + rectangulo.Area);
        Console.WriteLine("Rectangulo Perimetro: " + rectangulo.Perimetro);

        Cuadrado cuadrado = new Cuadrado();
        cuadrado.Lado = 5;
        Console.WriteLine("Rectangulo Area: " + cuadrado.Area);
        Console.WriteLine("Rectangulo Perimetro: " + cuadrado.Perimetro);

        Circulo circulo = new Circulo();
        circulo.Radio = 5;
        Console.WriteLine("Circulo Area: " + circulo.Area);
        Console.WriteLine("Circulo Perimetro: " + circulo.Perimetro);
    }
}