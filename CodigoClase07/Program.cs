
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






Console.WriteLine("Hello, World!");
