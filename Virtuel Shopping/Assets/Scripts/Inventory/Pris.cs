using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pris : MonoBehaviour
{
    public Text prisText;

    //Displayer totalprisen p� HUD'en
    public void Update()
    {
        prisText.text = Inventory.totalPris.ToString() + " kr";
    }
}
