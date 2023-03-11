static void saludar(String nomsal)
{
    Console.WriteLine($"Un gran saludo a {nomsal}");
}
//Esta no devuelve valor, por lo que se le llama método (void)

static int Calculo_año_nacimiento(int edad) 
{
    int añon = 2023 - edad;
    return añon;
}
//Esta devuelve valor, por lo que se le llama función

static bool palindromo(String palabra)
{
    int longitud = palabra.Length;
    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();
        //Console.SetCursorPosition(5, 10);
        //Console.WriteLine(palabra[c]);
        //Thread.Sleep(100);
    }

    if (palabra.Equals(pal))
    {
        return true;
    }
    return false;

    //Console.WriteLine(palabra[2]);
}

String palabra;
bool esPalindromo = palindromo("Ana".ToUpper());

if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
}
else 
{
    Console.WriteLine("No es palindromo");
}

//String nombre;
//int edad;
//char letra = 'a';

//Console.WriteLine("¿Cómo te llamas?");
//nombre = Console.ReadLine();
//saludar(nombre);

//Console.WriteLine($"Hola. Gusto de saludarte, {nombre}");
//Console.WriteLine("¿Cuántos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Bonita edad: {edad}\n Naciste en {Calculo_año_nacimiento(edad)}");
