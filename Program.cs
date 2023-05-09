Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("M = Minuto => 1m = 1minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1)); // pegar da string um caractere específico(posiçao , quantidade)
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm')  // converter minuto para segundo
        multiplier = 60;

    if (time == 0) // Hoje nao tem 0
        System.Environment.Exit(0);

    PreStart(time * multiplier);

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Começando...");
    Thread.Sleep(2000);

    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear(); // Limpando a tela para aparecer somente o momento atual 
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000); // 1 segundo de delay para a contagem aparecer na tela
    }

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado.");
    Thread.Sleep(2000);
    Menu();

}