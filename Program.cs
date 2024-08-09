double numero;
int numero2;
do
{
    Console.WriteLine("Digite um número inteiro: ");
   numero = Convert.ToDouble(Console.ReadLine());
    numero2 = (int)Convert.ToDouble(numero);
}  while (numero != numero2);
Console.WriteLine($"^Você digitou um numero inteiro: {numero}");