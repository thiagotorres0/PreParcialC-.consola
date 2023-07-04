double Area, Volumen, Radio, Generatriz, Altura;
do
{
    Console.WriteLine("Se solicita que ingrese la altura del cono");
    var str = Console.ReadLine(); //Esta variable es para trartar de convertir a un double lo que se ingrese por teclado.
    if (Double.TryParse(str, out Altura))
    {
        if (Altura > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor mal ingresado, intente nuevamente");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero, intente nuevamente");
    }
} while (true);
do
{
    Console.WriteLine("Se solicita que ingrese el radio del cono");
    var strl = Console.ReadLine();
    if (double.TryParse(strl, out Radio))
    {
        if (Radio > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor mal ingresado, intente nuevamente");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero, intente nuevamente");
    }
} while (true);
Generatriz = CalcularGeneratriz(Altura, Radio);
Volumen = CalcularVolumen(Radio, Altura);
Area = CalcularArea(Radio, Generatriz);

Console.WriteLine($"El area del cono es {Area}");
Console.WriteLine($"El volumen del cono es {Volumen}");

double CalcularArea(double radio, double generatriz)
{
    //Resultado=PI*Radio*(Radio+Generatriz)
    return Math.Truncate(Math.PI * Radio * (Radio + Generatriz));
}

double CalcularVolumen(double radio, double altura)
{
    //Resultado=(PI*Radio^2*Altura)/3;
    return Math.Truncate(Math.PI * (Math.Pow(Radio, 2) * Altura) / 3);
}

double CalcularGeneratriz(double altura, double radio)
{
    return Math.Truncate(Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2)));
}