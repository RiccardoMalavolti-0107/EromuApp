using EromuApp;

List<Eromu> lista = new List<Eromu>();
int hibasSorokSzama = 0;


foreach(var sor in File.ReadAllLines("eromuvek.txt").Skip(1))
{
    List<string> data = new List<string>(sor.Split('|'));
    foreach(var item in data)
    {
        if (item.IsWhiteSpace())
        {
            hibasSorokSzama++;
            continue;
        }
    }
    if (data.Count < 4)
    {
        hibasSorokSzama++;
        continue;
    }
    //if (data[0] != "S" || data[0] != "Z" || data[0].IsWhiteSpace())
    //{
    //    hibasSorokSzama++;
    //    continue; 
    //}
    if(!int.TryParse(data[2] ,out int Kapacitas)) //"!"
    {
        hibasSorokSzama++;
        continue;
    }
    if (data[0] =="Z" && !int.TryParse(data[3], out int Toronymagassag)) //"!"
    {
        hibasSorokSzama++;
        continue;
    }
    if (data[0] == "Z")
    {
        Szelgenerator szelgenerator = new Szelgenerator(int.Parse(data[2]), data[1], Kapacitas);
        lista.Add(szelgenerator);
    }
    if(data[0] == "S")
    {
        Eromu eromu = new Eromu(data[1], Kapacitas);
        lista.Add(eromu);
    }
}
Console.WriteLine("Sikeresen beolvasott erőművek: " + lista.Count() + " db");
Console.WriteLine("Kiszűrt hibás sorok száma: " + hibasSorokSzama + " db");
Console.WriteLine("Beolvasott erőművek listája:");
foreach(var item in lista)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("Szélgenerátorok külön elemzése:");
foreach (var item in lista)
{
    if (item is Szelgenerator) Console.WriteLine(item.ToString());

}

Console.WriteLine("Összesített energiatermelés 12 óra alatt: ");
Console.WriteLine("Erőmű példányok száma (static): ");