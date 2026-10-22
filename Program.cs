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
    if (data[0] != "s" || data[0] != "z" || data[0].IsWhiteSpace())
    {
        hibasSorokSzama++;
        continue;
    }
    if(!int.TryParse(data[2] ,out int Kapacitas)) //"!"
    {
        hibasSorokSzama++;
        continue;
    }
    if (data[0] =="z"&& !int.TryParse(data[3], out int Toronymagassag)) //"!"
    {
        hibasSorokSzama++;
        continue;
    }
    if (data[0] == "z")
    {
        Szelgenerator szelgenerator = new Szelgenerator(int.Parse(data[2]), data[1], Kapacitas);
        lista.Add(szelgenerator);
    }
    if(data[0] == "s")
    {
        Eromu eromu = new Eromu(data[1], Kapacitas);
        lista.Add(eromu);
    }
}