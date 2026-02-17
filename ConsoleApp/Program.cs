
////1-Crie um programa que determine se um número é par ou ímpar. (if / else)

//Console.WriteLine("Digite um número inteiro para verificar se é par ou ímpar:");

//string entradaDoUsuario = Console.ReadLine();
//int numero;

//if (int.TryParse(entradaDoUsuario, out numero))
//{
//    // Usa o operador ternário para definir a mensagem
//    string resultado = (numero % 2 == 0) ? "PAR" : "ÍMPAR";
//    Console.WriteLine($"O número {numero} é {resultado}.");
//}
//else
//    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");





////2 - Crie um programa que imprima a tabuada de um número. (for)
//Console.WriteLine("Digite um número para ver a tabuada:");
//int numero = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"\nTabuada do {numero}:");
//for (int i = 1; i <= 10; i++)
//    Console.WriteLine($"{numero} x {i} = {numero * i}");

////OU

//Console.WriteLine("Digite um número para ver a tabuada:");
//string valorDigitado = Console.ReadLine();
//int numeroTabuada;

//// Tenta converter a entrada para um inteiro
//if (int.TryParse(valorDigitado, out numeroTabuada))
//{
//    // Se a conversão for bem-sucedida, executa a lógica da tabuada
//    Console.WriteLine($"\nTabuada do {numeroTabuada}:");

//    for (int i = 1; i <= 10; i++)
//        Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
//}
//else
//    // Se falhar, informa o usuário educadamente
//    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");



////3 - Crie um programa que calcule a soma dos números em um array. - (foreach)
//int[] numeros = { 10, 20, 30, 40, 50 };
//int soma = 0;
//foreach (int i in numeros)
//    Console.WriteLine(i);
//foreach (int numero in numeros)
//    soma += numero;
//Console.WriteLine($"A soma dos números é: {soma}");

////-----

//string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" };
//Console.WriteLine("Lista de frutas:");
//foreach (string fruta in frutas)
//    Console.WriteLine(fruta);

////-----

//List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
//Console.WriteLine("\nNúmeros na lista:");
//foreach (int numero in numeros)
//    Console.WriteLine(numero);

////------

//Dictionary<string, int> idadePessoas = new Dictionary<string, int>
//    {
//            { "João", 25 },
//            { "Maria", 30 },
//            { "Pedro", 35 }
//    };
//Console.WriteLine("\nIdades das pessoas:");
//foreach (var pessoa in idadePessoas)
//    Console.WriteLine($"{pessoa.Key} tem {pessoa.Value} anos.");



////4 - Criar um programa que só aceita números positivos e
////   continua pedindo até que o usuário insira um número válido
////(do-while)

//int numero;
//do
//{
//    Console.WriteLine("Digite um número positivo:");

//    numero = Convert.ToInt32(Console.ReadLine());

//    if (numero < 0)
//        Console.WriteLine("Número inválido! Tente novamente.");

//} while (numero < 0);

//Console.WriteLine($"Número válido inserido: {numero}");




////5 - Criar um programa que faça a contagem regressiva a partir do número informado pelo usuário.
//int contador = 10; // Definição do valor inicial
//Console.WriteLine("Contagem regressiva:");
//while (contador > 0) // Enquanto o contador for maior que 0, o loop continua
//{
//    Console.WriteLine(contador);
//    contador--; // Decrementa o contador
//}

//Console.WriteLine("Contagem regressiva concluída!");


////6 - Crie um programa que faça a tabuada de 1 ao 5 (loop aninhado)
//Console.WriteLine("Tabuada de 1 a 5:");
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"\nTabuada do {i}:");

//    for (int j = 1; j <= 10; j++)
//        Console.WriteLine($"{i} x {j} = {i * j}");
//}
