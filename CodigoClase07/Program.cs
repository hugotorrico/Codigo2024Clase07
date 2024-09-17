
using CodigoClase07;


//Constructor por defecto
Persona persona = new Persona();

//Asi sería en JAVA
//persona.setNombres("Ronald");
//persona.getNombres();

//Forma Antigua
persona.setNombres("Ronald");
Console.WriteLine(persona.getNombres());

//Forma Nueva
persona.Nombres2 = "Ronald";
Console.WriteLine(persona.Nombres2);

//Constructor con  2 parámetros
Persona persona1 = new Persona("Hugo", "Torrico");

//Constructor con  3 parámetros
Persona persona2 = new Persona("Hugo", "Torrico",36);


Producto producto = new Producto();
producto.Descripcion = "Nuevo";
producto.Nombre = "Laptop";
producto.Cantidad = 10;
producto.Precio = 5000;


Producto producto1 = new Producto
{
    Nombre = "TV",
    Cantidad = 10,
    Descripcion = "Descripcion",
    Precio = 2500
};

Producto producto2 = new Producto
{
    Nombre = "Mouse",
    Precio = 150
};



//Punto punto1 = new Punto { X=0,Y=0};
Punto punto2 = new Punto { X = 6, Y = 0 };
Punto punto3= new Punto {  X=6,Y=10};
Punto punto4 = new Punto { X = 0, Y = 10 };


Rectangulo rectangulo = new Rectangulo();
rectangulo.Punto1 = new Punto { X = 0, Y = 0 };
rectangulo.Punto2 = punto2;
rectangulo.Punto3 = punto3;
rectangulo.Punto4 = punto4;

Console.WriteLine("El área del rectangulo es:");
Console.WriteLine(rectangulo.CalcularArea());

Console.WriteLine("El perímetro del rectangulo es:");
Console.WriteLine(rectangulo.CalcularPerimetro());


Console.Read();
