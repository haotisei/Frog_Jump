using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSpace : MonoBehaviour
{
    
    public GameObject Tap;

    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Tap.SetActive(false);
        }
    }
}
