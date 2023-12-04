static int multiplicacionRusa(int a, int b)
{
    int resultado = 0;
    while(a > 0)
    {
        if(a % 2 !=0)
        {
            resultado += b;
        }
        a /= 2;
        b *= 2;
    }
    return resultado;
}
Console.Write("Ingresa el valor del multiplicador: ");
int v1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el valor del multiplicando: ");
int v2 = Convert.ToInt32(Console.ReadLine());

int resultado = multiplicacionRusa(v1,v2);
Console.WriteLine(resultado);