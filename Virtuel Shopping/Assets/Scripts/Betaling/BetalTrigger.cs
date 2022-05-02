using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetalTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject fakePlayer;
    public GameObject cutsceneCam;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        Player.SetActive(false);
        fakePlayer.SetActive(true);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(0.5f);
        cutsceneCam.SetActive(false);
        Application.LoadLevel(1);
    }
}
