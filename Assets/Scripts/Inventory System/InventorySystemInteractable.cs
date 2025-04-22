using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystemInteractable : MonoBehaviour, IInteractable
{

    public GameObject billboardGO;
    private void OnCollisionEnter(Collision collision)
    {
        billboardGO.SetActive(true);
        Interact(this.transform);  
    }

    private void OnCollisionExit(Collision collision)
    {
        billboardGO.SetActive(false);
        Debug.Log("COllision Exit");
    }

    public void Interact(Transform transform) 
    {
        Debug.Log("COllision Entered");
    }
}
