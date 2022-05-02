using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text prisText;
    public static int wallet = 9999;

    //Displayer totalprisen på HUD'en
    public void Update()
    {
        prisText.text = "Du har " + Payment.walletEfterBetaling + " kr";
    }
}