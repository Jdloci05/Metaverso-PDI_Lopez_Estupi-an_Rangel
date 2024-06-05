using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnExteriorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }
}



