using System.Collections.Generic;
using System;
using Problema4;

//Curs: static Dictionary<Moneda, decimal> - DONE!

//Valoare: decimal - DONE!

//Moneda: Moneda - DONE!

//decimal ValoareCurs(Moneda moneda) - intoarce valoarea in functie de curs pentru moneda primita - DONE

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
public class Pret
{
    public static Dictionary<Moneda, decimal> Curs = new Dictionary<Moneda, decimal>();
    

    public Moneda moneda;
    decimal Valoare;
    public decimal Val
    {
        get { return Valoare; }
        set
        {
            if (value >= 0)
            {
                if (PriceChanged!=null)
                {
                    this.PriceChanged(Valoare, value);
                    this.Valoare = value;
                }
            }
        }
    }
    public decimal ValoareCurs(Moneda moneda) 
    {

        switch (moneda)
        {
            case Moneda.RON:
                return Valoare * Curs[Moneda.RON];                
            case Moneda.EUR:
                return Valoare * Curs[Moneda.EUR];
            case Moneda.USD:
                return Valoare * Curs[Moneda.USD];
            default:
                return 0;
        }
        
    }
    
    public event PriceChangedHandler PriceChanged;

    protected virtual void OnPriceChanged(decimal Valoare, decimal value)
    {
        if (PriceChanged!=null)
        {
            PriceChanged(Valoare, value);
        }
    }
    public void functietest2()
    {

    }
}
