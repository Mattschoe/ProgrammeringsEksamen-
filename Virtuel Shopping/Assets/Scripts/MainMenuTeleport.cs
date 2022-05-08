using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuTeleport : MonoBehaviour
{
    public void Teleport()
    {
        StartCoroutine(MMTeleport());
    }

    IEnumerator MMTeleport()
    {
        yield return new WaitForSeconds(0.3f);
        Application.LoadLevel(1);
    }

    public void BaiBai()
    {
        StartCoroutine(QuitGame());
    }

    IEnumerator QuitGame()
    {
        yield return new WaitForSeconds(0.3f);
        Application.Quit();
        print("Bai Bai");
    }
}
