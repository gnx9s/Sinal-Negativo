int valorDigitado;

mensagem("-- SINAL / POSITIVO OU NEGATIVO --", ConsoleColor.White);

mensagem2("Digite um valor para que eu possa verificar seu sinal...: ", ConsoleColor.White);
valorDigitado = int.Parse(Console.ReadLine()!);

Thread.Sleep(1500);

mensagem("Verificando o sinal do número digitado...", ConsoleColor.White);

Thread.Sleep(1500);

if (valorDigitado > 0)
{
    mensagem("O valor digitado é POSITIVO! ", ConsoleColor.Blue);
}
else if (valorDigitado < 0)
{
    mensagem("O valor digitado é NEGATIVO! ", ConsoleColor.Red);
}
else
{
    mensagem("O Valor digitado é igual a ZERO ", ConsoleColor.Yellow);
}

Thread.Sleep(1500);

mensagem("Obrigado por usar o programa! ", ConsoleColor.White);


void mensagem(string mensagem, ConsoleColor cortexto)
{
    Console.ForegroundColor = cortexto;
    Console.WriteLine(mensagem);
    Console.ResetColor();
}

void mensagem2(string mensagem, ConsoleColor cortexto)
{
    Console.ForegroundColor = cortexto;
    Console.Write(mensagem);
    Console.ResetColor();
}