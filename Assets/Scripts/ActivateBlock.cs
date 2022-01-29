using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBlock : MonoBehaviour
{
    public GameObject NextObject;

  void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
            NextObject.SetActive(true);
            Debug.Log("Block Activated");
             }
    }
}
