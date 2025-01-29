/* 

SOLID
S - SRP - Single Responsibility Principle
            Cada modelo debe cumplir con solo un proposito.
            Ejemplo: Una clase que se encargue de la conexion a la base de datos y otra que se
            encargue de la logica de negocio.

            Cohesion: Una clase debe tener una sola responsabilidad.
            Acoplamiento: Una clase no debe depender de otra clase.

O - OCP - Open/Closed Principle
            Las clases deben estar abiertas para extenderse pero cerradas para modificarse.
            Se debe poder extender la funcionalidad de una clase sin modificar su codigo fuente.
            Ejemplo: Crear una clase abstracta que contenga un metodo abstracto y que las clases hijas
            implementen dicho metodo.

L - LSP - Liskov Substitution Principle
            Las clases hijas deben poder ser sustituidas por las clases padre sin afectar el comportamiento.
            Si una clase hija no puede ser sustituida por la clase padre, entonces la jerarquia de clases
            no esta bien diseñada.
            Ejemplo: Crear una clase abstracta que contenga un metodo abstracto y que las clases hijas
            implementen dicho metodo.

I - ISP - Interface Segregation Principle
            No se deben implementar interfaces que no se usen, se deben crear interfaces especificas
            para cada clase.
            Ejemplo: Crear una interfaz para cada clase que contenga solo los metodos que se usen.

D - DIP - Dependency Inversion Principle
            Al crear clases, se deben inyectar las dependencias en lugar de crearlas dentro de la clase.
            Ejemplo: Crear una interfaz que contenga los metodos que se usen y que las clases que la implementen
            
*/

