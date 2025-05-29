
#region Exemplos Array em C# 
//Array amostra = new double[5];
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

////TestaArrayInt();
////TesteBuscarPaçavra();
////TestaMediana(amostra);

//void TestaArrayInt()
//{
//    int[] idades = new int[5];

//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"Tamanho do Array {idades.Length}");

//    int acumulador = 0;
//    for ( int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        acumulador += idade;

//        Console.WriteLine($"indice [{i}] = {idade}");
//    }

//    int media = acumulador/idades.Length;
//    Console.WriteLine("Media de idades = " + media);
//}
//void TesteBuscarPaçavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite a {i + 1}ª palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite a palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string s in arrayDePalavras) 
//    { 
//        if (s.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}");
//            return;
//        }

//    }
//}
//void TestaMediana(Array array)
//{
//    if ((array ==  null) || (array.Length == 0)){
//        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenados = (double[]) array.Clone();
//    Array.Sort(numerosOrdenados);

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;

//    double mediana = (tamanho%2!=0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio-1])/2;

//    Console.WriteLine("Com base na amostra a mediana é: " + mediana);
//}


//void TestaArrayDeContascorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874, "6436-A"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "45636-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "646736-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "6436-A"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "45636-B"));


//    var contaDoAndre = new ContaCorrente(963, "CONTA DE TESTE-X");
//    listaDeContas.Adicionar(contaDoAndre);
//    //listaDeContas.ExibirLista();
//    //Console.WriteLine("=========================");
//    //listaDeContas.Remover(contaDoAndre);
//    //listaDeContas.ExibirLista();

//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
//    } 

//}

//TestaArrayDeContascorrentes();

#endregion

#region Listas Genericas
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("Ola mundo");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}

#endregion

#region Recursos do List -> Collections
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(895, "123456-A"){Saldo = 100},
//    new ContaCorrente(895, "987556-B"){Saldo = 200},
//    new ContaCorrente(984, "986753-C"){Saldo = 60}
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(975, "123456-D"){Saldo = 100},
//    new ContaCorrente(975, "987556-E"){Saldo = 200},
//    new ContaCorrente(794, "986753-F"){Saldo = 60}
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"indice [{i}] - conta: {_listaDeContas2[i].Conta}");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"indice [{i}] - conta: {range[i].Conta}");
//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"indice [{i}] - conta: {_listaDeContas3[i].Conta}");
//}

#endregion



using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas vindas ao ByteBank, Atendimento.");

new BybeBankAtendimento().AtendimentoCliente();
