/* 
Las interfaces son una forma de definir un contrato que deben cumplir las clases que la implementen.
Las interfaces no pueden contener campos, solo propiedades, metodos, eventos e indexadores.
Las interfaces no pueden contener: 
    * constructores.
    * metodos con cuerpo.
    * metodos estaticos.    
    * metodos privados.
    * metodos protegidos.
    * metodos internos.
    * metodos protegidos internos.
    * metodos virtuales.
    * metodos abstractos.
    * metodos sellados.
*/

public interface IAnimal
{
    string Nombre { get; set; }
    void Comer();
    void Dormir();
}

public class Perro : IAnimal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine("El perro " + Nombre + " está comiendo");
    }

    public void Dormir()
    {
        Console.WriteLine("El perro " + Nombre + " está durmiendo");
    }
}

public class Gato : IAnimal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine("El gato " + Nombre + " está comiendo");
    }

    public void Dormir()
    {
        Console.WriteLine("El gato " + Nombre + " está durmiendo");
    }
}