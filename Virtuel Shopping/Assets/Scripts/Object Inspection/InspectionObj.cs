using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionObj : MonoBehaviour
{
    public GameObject[] inspectionObjects;
    private int currIndex;

    //Tænder inspection-værktøjet når aktiveret (Bliver aktiveret i "ObjectInspect.cs"
    public void TurnOnInspection(int index)
    {
        currIndex = index;
        inspectionObjects[index].SetActive(true);
    }

    //Slukker inspection-værktøjet når aktiveret (bliver aktiveret ved knaptryk)
    public void TurnOffInspection()
    {
        inspectionObjects[currIndex].SetActive(false);
    }
}
