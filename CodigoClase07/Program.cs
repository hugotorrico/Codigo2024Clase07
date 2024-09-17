
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



Console.WriteLine("Hello, World!");
