using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavingTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(4);
    }
}
