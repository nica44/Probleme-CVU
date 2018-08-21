using System;
using System.Collections.Generic;


//Inbox: string[10] (privat) -DONE!
//Email: string - DONE
//Moneda: Moneda - DONE
//ProduseFavorite: List<guid> - DONE
//boolean Notifica(string mesaj) - DONE
//daca mesajul este mare de 60 de caractere intoarce false si nu adauga mesajul in inbox, altfel true si adauga in inbox - DONE
//daca numarul de mesaje depaseste numarul maxim(10) arunca o exceptie(OutOfMemoryException) - almost DONE (not sure if it works)
public class Client
{
    string[] Inbox = new string[10];
    int inbox_capacity = 0;
    string Email;
    Problema4.Moneda Moneda;
    List<Guid> ProduseFavorite = new List<Guid>();
    public bool Notifica(string mesaj)
    {
        if (mesaj.Length > 60)
        {
            return false;
        }
        if (inbox_capacity < Inbox.Length)
        {
            Inbox[inbox_capacity] = mesaj;
            inbox_capacity++;
            return true;
        }
        else
        {
            return false;
            throw new OutOfMemoryException();
        }
    }
    public void Notifica(decimal Valoare, decimal value)
    {
        string mesaj = $"Pretul s-a modificat de la {Valoare} la {value}";
        if (inbox_capacity < Inbox.Length)
        {
            Inbox[inbox_capacity] = mesaj;
            inbox_capacity++;
        }
        else
        {
            throw new OutOfMemoryException();
        }
    }
    public void NotificaStoc(int stocvechi, int stocnou)
    {
        string mesaj = $"Stocul s-a modificat de la {stocvechi} la {stocnou}";
        if (inbox_capacity < Inbox.Length)
        {
            Inbox[inbox_capacity] = mesaj;
            inbox_capacity++;
        }
        else
        {
            throw new OutOfMemoryException();
        }
    }
    public void ArataMesaje()
    {
        for (int i = 0; i < inbox_capacity; i++)
        {
            Console.WriteLine($"Mesaj {i}: {Inbox[i]}");
        }
    }
}
