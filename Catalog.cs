using System;
using System.Collections.Generic;

//PerioadaStart: DateTime de tip nullable -DONE!
//PerioadaStop: DateTime de tip nullable - DONE!
//Reduceri: List<Reducere> - DONE!
public class Catalog: List<Produs>
{
    public DateTime? PerioadaStart;
    public DateTime? PerioadaStop;
    public List<Reducere> Reduceri = new List<Reducere>();
    //aboneaza-te

    public void Abonare()
    {

    }
}
