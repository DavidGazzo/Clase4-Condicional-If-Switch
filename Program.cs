// Condicional If
Console.WriteLine("Al ingresar edad se le dirá si es menor o mayor de edad...");
Console.WriteLine("Ingrese su edad:");
int edadUsuario = int.Parse(Console.ReadLine());
Console.WriteLine("Su edad ingresada es: " + edadUsuario);


Console.WriteLine("Ingrese su equipo de fútbol:");
string equipoUsuario = Console.ReadLine();
Console.WriteLine("El equipo ingresado es " + equipoUsuario);

//atajos de teclado CTRL+K+X

bool condicion = edadUsuario < 18 && equipoUsuario == "River";
if (condicion)
{   //Si se cumple la condición
    Console.WriteLine("Usted es menor de edad...");
}
else
{   //Si no se cumple la condición
    Console.WriteLine("Usted e mayor de edad...");
}



// Comentar bloque seleccionarlo y CTRL+K+C
// Descomentar bloque seleccionarlo y CTRL+K+U
