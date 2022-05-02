using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static int totalPris;
    private int pris;
    public GameObject[] varer;

    //Assigner alle varer i spillet med et tag
    public void Start()
    {
        for (int i = 0; i < varer.Length; i++)
        {
            varer[i].gameObject.tag = "Varer";
            varer[i].GetComponent<PrisRandomizer>();
        }
    }

    //Opdaterer prisen på HUD'en
    private void PrisUpdate()
    {
        totalPris = totalPris + PrisRandomizer.varePris;
    }

    //Tagger varen hvis man vælger at tage den med
    public void ButtonCheck()
    {
        PrisUpdate();
    }
    
    public void DisableObject()
    {
        Destroy(GameObject.FindWithTag("FokusVare"));
    }
}
