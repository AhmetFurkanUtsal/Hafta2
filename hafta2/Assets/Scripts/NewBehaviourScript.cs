using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        int sayi1 = 15;
        int sayi2 = 42;

        int secim = 4;

        if (secim == 1)
        { 
          benimFonksiyonum(sayi1,sayi2);
        }

        if (secim == 2)
        {
            ikiyebolum(sayi1, sayi2);
        }
        if (secim == 3)
        {
            ucebolum(sayi1, sayi2);
        }

        if (secim == 4)
        {
            dordebolum(sayi1, sayi2);
        }

        if (secim == 5)
        {
            besebolum(sayi1, sayi2);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }


    void benimFonksiyonum(int sayi1 , int sayi2)
    {

        for (int i = sayi1; i<= sayi2; i++)
        {
            print(i);
        }
    }

    void ikiyebolum(int sayi1, int sayi2)
    {
        for (int i = sayi1; i <= sayi2; i++)
        {
            if(i%2 == 0)
            {
                print(i);
            }
        }

    }


    void ucebolum(int sayi1, int sayi2)
    {

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 3 == 0)
            {
                print(i);
            }
        }
    }

    void dordebolum(int sayi1, int sayi2)
    {

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 4 == 0)
            {
                print(i);
            }
        }
    }

    void besebolum(int sayi1, int sayi2)
    {

        for (int i = sayi1; i <= sayi2; i++)
        {
            if (i % 5 == 0)
            {
                print(i);
            }
        }
    }
}
