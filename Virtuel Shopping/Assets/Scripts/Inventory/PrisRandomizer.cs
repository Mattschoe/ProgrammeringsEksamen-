using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisRandomizer : MonoBehaviour
{
    public static int varePris;

    //Giver alle varere en random pris
    private void Update()
    {
        varePris = Random.Range(5, 100);
    }
}
