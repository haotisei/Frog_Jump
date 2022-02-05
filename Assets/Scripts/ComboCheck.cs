using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboCheck : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Scores.Combo();
        Destroy(gameObject);
    }
}
