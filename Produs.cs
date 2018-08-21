using System;

//Id: guid - identificare unica in sistem

//Nume: string

//Pret: Pret

//Stoc: intreg > 0

//Producator: Producator
public delegate void StockChangedHandler(int stocVechi, int value);
public class Produs
{
    public Guid Id;
    public string Nume;
    public Pret pret;
    public int stocVechi;
    public int Stoc
    {
        get { return stocVechi; }
        set
        {
            if (StockChanged!=null)
            {
                StockChanged(stocVechi, value);
                stocVechi = value;
            }
        }
    }
    public Producator producator;

    public event StockChangedHandler StockChanged;
    public virtual void OnStockChanged(int stocVechi, int value)
    {
        StockChanged?.Invoke(stocVechi, value);
    }
}
