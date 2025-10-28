string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1, TotalAlunos = 0;
// nomes[0] = "Maria";
// idades[0] = 20;

// nomes[1] = "Matheus";
// idades[1] = 16;

// nomes[2] = "Eloysa";
// idades[2] = 17;

// nomes[3] = "Felipe";
// idades[3] = 18;

do
{
    Console.Clear();
    Console.WriteLine("1) Cadastrar alunos");
    Console.WriteLine("2) Listar alunos");
    Console.WriteLine("0) Sair");
    Console.WriteLine("Digite uma opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        case 0:
            System.Console.WriteLine("Encerrando ...");
            System.Console.WriteLine("Pressione <Enter> para continuar");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);


void CadastrarAluno()
{
    if (TotalAlunos >= 4)
    {
        Console.WriteLine("Limite atingido");
        return;

        System.Console.WriteLine("Pressione <Enter> para continuar");
        System.Console.ReadLine();
    }


    System.Console.WriteLine("Digite o nome do aluno");
    string n = Console.ReadLine();
    System.Console.WriteLine("Digite a idade do aluno");
    int i = int.Parse(Console.ReadLine());
    nomes[TotalAlunos] = n;
    idades[TotalAlunos] = i;
    TotalAlunos++;

    System.Console.WriteLine("Aluno cadastrado com sucesso");
    System.Console.WriteLine($"Há {TotalAlunos} aluno(s) cadastrado(s) no sistema");
    System.Console.WriteLine("Pressione <Enter> para continuar");
    System.Console.ReadLine();


}

void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine("Resultado:");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine(nomes[i]);
        Console.WriteLine("" + idades[i]);
        Console.WriteLine();

    }

    System.Console.WriteLine("Pressione <Enter> para continuar");
    System.Console.ReadLine();
}