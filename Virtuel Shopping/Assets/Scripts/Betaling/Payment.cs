using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payment : MonoBehaviour
{
    public static int walletEfterBetaling;

    private void Start()
    {
        walletEfterBetaling = Money.wallet;
    }

    public void Betaling()
    {
        walletEfterBetaling = walletEfterBetaling - Inventory.totalPris;
    }

    public void Teleport()
    {
        StartCoroutine(TeleportEfterBetaling());
    }

    IEnumerator TeleportEfterBetaling()
    {
        yield return new WaitForSeconds(0.3f);
        Application.LoadLevel(3);
    }
}
