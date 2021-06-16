using System;
class Épület
{
    public string Név { get; set; }
    public string Város { get; set; }
    public string Ország { get; set; }
    public double Magasság { get; set; }
    public int Emelet { get; set; }
    public int ÉpítésÉve { get; set; }

    public Épület(string sor)
    {
        try
        {
            string[] SorSplitted = sor.Split(';');
            Név = SorSplitted[0];
            Város = SorSplitted[1];
            Ország = SorSplitted[2];
            Magasság = double.Parse(SorSplitted[3]);
            Emelet = int.Parse(SorSplitted[4]);
            ÉpítésÉve = int.Parse(SorSplitted[5]);
        }
        catch
        { }
    }
}