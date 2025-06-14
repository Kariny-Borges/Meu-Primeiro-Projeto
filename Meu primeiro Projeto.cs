// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, sou a Kariny!");
Console.WriteLine("Vamos entender melhor sobre rotina diária!");


//Declarando variavies

int HorasSono = 8;
int HorasTrabalho = 8;
int HorasLivre = 5;
int HorasCelular = 3;
int TotalGasto = 24;

Console.WriteLine("Quantas horas você dormiu hoje?");
HorasSono = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas horas você trabalhou hoje?");
HorasTrabalho = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas horas você teve livre hoje?");
HorasLivre = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas horas você passou no celular hoje? ");
HorasCelular = int.Parse(Console.ReadLine());

int TotalGastoNoDia = HorasSono + HorasTrabalho + HorasCelular; HorasLivre = 24 - TotalGastoNoDia;
Console.WriteLine("você ainda tem\n" + HorasLivre + "horas livres do seu dia\n");

if (HorasLivre < 2)
{
    Console.WriteLine("Sua rotina está muito corrida, quase não sobrou tempo livre.\n");
}
else if (HorasLivre >= 2 && HorasLivre < 4)
{
    Console.WriteLine("Sua rotina está um pouco corrida, tente ajustar algo.\n");
}
else
{
    Console.WriteLine(" Show, você está conseguindo equilibrar sua rotina :)\n");
}

Console.ReadLine();