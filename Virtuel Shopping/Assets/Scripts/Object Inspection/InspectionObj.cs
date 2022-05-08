using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionObj : MonoBehaviour
{
    public GameObject[] inspectionObjects;
    private int currIndex;

    //T�nder inspection-v�rkt�jet n�r aktiveret (Bliver aktiveret i "ObjectInspect.cs"
    public void TurnOnInspection(int index)
    {
        currIndex = index;
        inspectionObjects[index].SetActive(true);
    }

    //Slukker inspection-v�rkt�jet n�r aktiveret (bliver aktiveret ved knaptryk)
    public void TurnOffInspection()
    {
        inspectionObjects[currIndex].SetActive(false);
    }
}
