using System.Reflection.Metadata;
using Exercicio02;

// List<Fatura> listaDeFaturas = new List<Fatura>();
// List<Relatorio> listaDeRelatorios = new List<Relatorio>();
// List<Contrato> listaDeContratos = new List<Contrato>();

// Fatura fatZe = new Fatura();
// fatZe.Dono = "Zé da Esquina";
// Fatura fatMaria = new Fatura();
// fatMaria.Dono = "Maria Eduarda";
// Fatura fatEdu = new Fatura();
// fatEdu.Dono = "Eduardo Pereira";
// Fatura fatHenrique = new Fatura();
// fatHenrique.Dono = "Henrique Nascimento";
// Fatura fatMarcos = new Fatura();
// fatMarcos.Dono = "Marcos Vinícius";
// Fatura fatFrancisco = new Fatura();
// fatFrancisco.Dono = "Francisco Hugo";
// Fatura fatDavi = new Fatura();
// fatDavi.Dono = "Davi Muniz";
// Fatura fatLucas = new Fatura();
// fatLucas.Dono = "Lucas Marinho";
// Fatura fatJoao = new Fatura();
// fatJoao.Dono = "João";

// Relatorio relaZe = new Relatorio();
// relaZe.Dono = "Zé da Esquina";
// Relatorio relaMaria = new Relatorio();
// relaMaria.Dono = "Maria Eduarda";
// Relatorio relaEdu = new Relatorio();
// relaEdu.Dono = "Eduardo Pereira";
// Relatorio relaHenrique = new Relatorio();
// relaHenrique.Dono = "Henrique Nascimento";
// Relatorio relaMarcos = new Relatorio();
// relaMarcos.Dono = "Marcos Vinícius";
// Relatorio relaFrancisco = new Relatorio();
// relaFrancisco.Dono = "Francisco Hugo";
// Relatorio relaDavi = new Relatorio();
// relaDavi.Dono = "Davi Muniz";
// Relatorio relaLucas = new Relatorio();
// relaLucas.Dono = "Lucas Marinho";
// Relatorio relaJoao = new Relatorio();
// fatJoao.Dono = "João";

// Contrato conZe = new Contrato();
// conZe.Dono = "Zé da Esquina";
// Contrato conMaria = new Contrato();
// conMaria.Dono = "Maria Eduarda";
// Contrato conEdu = new Contrato();
// conEdu.Dono = "Eduardo Pereira";
// Contrato conHenrique = new Contrato();
// conHenrique.Dono = "Henrique Nascimento";
// Contrato conMarcos = new Contrato();
// conMarcos.Dono = "Marcos Vinícius";
// Contrato conFrancisco = new Contrato();
// conFrancisco.Dono = "Francisco Hugo";
// Contrato conDavi = new Contrato();
// conDavi.Dono = "Davi Muniz";
// Contrato conLucas = new Contrato();
// conLucas.Dono = "Lucas Marinho";
// Contrato conJoao = new Contrato();
// fatJoao.Dono = "João";

// listaDeFaturas.Add(fatDavi);
// listaDeFaturas.Add(fatEdu);
// listaDeFaturas.Add(fatFrancisco);
// listaDeFaturas.Add(fatHenrique);
// listaDeFaturas.Add(fatJoao);
// listaDeFaturas.Add(fatMarcos);
// listaDeFaturas.Add(fatLucas);
// listaDeFaturas.Add(fatZe);
// listaDeFaturas.Add(fatMaria);

// listaDeRelatorios.Add(relaDavi);
// listaDeRelatorios.Add(relaEdu);
// listaDeRelatorios.Add(relaFrancisco);
// listaDeRelatorios.Add(relaHenrique);
// listaDeRelatorios.Add(relaJoao);
// listaDeRelatorios.Add(relaMarcos);
// listaDeRelatorios.Add(relaLucas);
// listaDeRelatorios.Add(relaZe);
// listaDeRelatorios.Add(relaMaria);

// listaDeContratos.Add(conDavi);
// listaDeContratos.Add(conEdu);
// listaDeContratos.Add(conFrancisco);
// listaDeContratos.Add(conHenrique);
// listaDeContratos.Add(conJoao);
// listaDeContratos.Add(conMarcos);
// listaDeContratos.Add(conLucas);
// listaDeContratos.Add(conZe);
// listaDeContratos.Add(conMaria);

// foreach (var item in listaDeFaturas)
// {
//     item.Imprimir();
// }

// foreach (var item in listaDeFaturas)
// {
//     item.Imprimir();
// }

// foreach (var item in listaDeFaturas)
// {
//     item.Imprimir();
// }

// Relatorio rl = new Relatorio();
// rl.Imprimir();
// Contrato c1 = new Contrato();
// c1.Imprimir();
// Fatura ft = new Fatura();
// ft.Imprimir();


List<IIprimivel> docu = new List<IIprimivel>();
int opcao;
// Fatura FatEdu = new Fatura("eduardo", "Izabel Dark Lab", 50, 1);

// FatEdu.Imprimir();
do
{
    System.Console.WriteLine($"-------- MENU --------");
    System.Console.WriteLine();
    System.Console.WriteLine("1 - Cadastrar Fatura");
    System.Console.WriteLine("2 - Cadastrar Relatorio");
    System.Console.WriteLine("3 - Cadastrar Contrato");
    System.Console.WriteLine("4 - Listar");
    System.Console.WriteLine("5 - Listar");
    System.Console.WriteLine("6 - Listar");
    System.Console.WriteLine("0 - Sair");
    System.Console.WriteLine("Escolha uma dessas opçães:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            CadastrarRelatorio();
            break;
        case 3:
            CadastrarContrato();
            break;
        case 4:
            listarF();
            break;
        case 5:
            listarR();
            break;
        case 6:
            listarC();
            break;
        case 0:
            System.Console.WriteLine("Sair");
            break;
        default:
            System.Console.WriteLine("opção invalida");
            break;
    }

    System.Console.WriteLine("presione <enter> para continuar");
    Console.ReadLine();
} while (opcao != 0);

void CadastrarFatura()
{

    System.Console.WriteLine("digite o nome do devedor:");
    string dev = Console.ReadLine();

    System.Console.WriteLine("digite o nome do credor:");
    string credor = Console.ReadLine();
    System.Console.WriteLine("digite o valor da fatura:");
    float valor = float.Parse(Console.ReadLine());

    System.Console.WriteLine("Quantos dias a fatura está em atraso?");
    int DiasA = int.Parse(Console.ReadLine());

    Fatura Fat = new Fatura(dev, credor, valor, DiasA);


    docu.Add(Fat);

}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante:");
    string contratante = Console.ReadLine();

    Console.WriteLine($"Digite o nome da pessoa contratada");
    string PrestadorServico = Console.ReadLine();

    Console.WriteLine($"Quais sao as clausulas do contrato?");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, PrestadorServico, txtClausulas);

    docu.Add(c);

}

//Relatorio
void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do Responsavel:");
    string responsavel = Console.ReadLine();

    Console.WriteLine($"Quais são as clausulas");
    string PrestadorServico = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, PrestadorServico);

    docu.Add(r);
}

void listarF()
{
    foreach (var item in docu)
    {
        if (item is Fatura) { item.Imprimir(); }

    }

}
void listarC()
{
    foreach (var item in docu)
    {
        if (item is Contrato) { item.Imprimir(); }

    }

}
void listarR()
{
    foreach (var item in docu)
    {
        if (item is Relatorio) { item.Imprimir(); }
        ;
    }

}