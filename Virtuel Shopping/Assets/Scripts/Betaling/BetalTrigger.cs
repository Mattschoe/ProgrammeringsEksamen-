using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetalTrigger : MonoBehaviour
{
    public GameObject Player;
    public GameObject fakePlayer;
    public GameObject cutsceneCam;

    //Starter animation når spilleren træder ind i triggeren
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        Player.SetActive(false);
        fakePlayer.SetActive(true);
        StartCoroutine(FinishCut());
    }
    
    //Flytter spilleren til betalingscenen
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(2.8f);
        cutsceneCam.SetActive(false);
        Application.LoadLevel(2);
    }
}
