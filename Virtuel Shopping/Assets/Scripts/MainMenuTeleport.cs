using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuTeleport : MonoBehaviour
{
    public void Teleport()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
