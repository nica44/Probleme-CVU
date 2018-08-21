using System;

//Nume - string
//Data: DateTime
//Aplica - delegat generic care primeste un Produs si nu intoarce nimic dar este important ca reducerea sa se aplice relativ la produs si nu global(adica indiferent de produs)

public class Reducere
{
    public string Nume;
    public DateTime data;
    public delegate void Aplica<Produs>(Produs item);
}
