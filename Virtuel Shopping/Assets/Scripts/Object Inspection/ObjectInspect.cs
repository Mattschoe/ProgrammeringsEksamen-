using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInspect : MonoBehaviour
{
    public GameObject Inspection;
    public InspectionObj inspectionObj;
    public int index;

    void Update()
    {
        //S� transparent effecten ikke virker n�r man er i inspectmode
        if (Inspection.active)
        {
            return; 
            
        }

        //Raycast til at finde objekter
        Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Color color = GetComponent<MeshRenderer>().material.color;
        
        if (GetComponent<Collider>().Raycast(ray, out hit, 100f))
        {
            //G�r objektet lidt gennemsigtigt
            color.a = 0.6f;
            
            //Aktiverer inspection n�r objektet bliver trykket p�
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.tag = "FokusVare";
                Inspection.SetActive(true);
                inspectionObj.TurnOnInspection(index); 
            }
        }
        else
        {
            color.a = 1.0f;
        }
        GetComponent<MeshRenderer>().material.color = color;
    }
}
