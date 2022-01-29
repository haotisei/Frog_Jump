using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBlock : MonoBehaviour
{
    public GameObject NextObject;
    public Transform Object;
    public GameObject Player;

  void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
            NextObject.SetActive(true);
            Player.transform.LookAt(Object);
             }
    }
}
