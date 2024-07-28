//Primeiro código em c# escrevendo um simples "Hello Word!".
// Console.WriteLine - Imprimi uma mensagem no console de saída e no final da mensagem dar um linha semelhante a função "return" ou "enter".

Console.WriteLine("Hello, World!");
Console.ReadLine();

// Console.Write - Imprimi uma mensagem no console de saída porém se adicionar outra mensagem tanto com Console.WriteLine quanto com Console.Write, irá imprimir a mensagem na mesma linha.

Console.Write("Congratulations!");
Console.Write(" ");
Console.WriteLine("You wrote your first lines of code.");
Console.WriteLine("HelloWord!");
Console.ReadLine();

// imprimit diferentes tipos de dados

Console.WriteLine("Bu");
Console.WriteLine('B');
Console.WriteLine(123);
Console.WriteLine(12.3F);
Console.WriteLine(12.388);
Console.WriteLine(12.39816m);
Console.WriteLine(true);
Console.WriteLine(false);
Console.ReadLine();

// Atribuição de variáveis

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

string secundName = "lili";
Console.WriteLine(secundName);
secundName = "juju";
Console.WriteLine(secundName);

Console.ReadLine();

// 1. Desafio: Exibir valores literais e variáveis

string name = "Bob";

int messages = 3;

decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write('!');
Console.Write(" You have ");
Console.Write(messages);
Console.Write(" messages in your inbox.");
Console.Write(" The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

Console.ReadLine();


