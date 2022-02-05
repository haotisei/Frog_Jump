using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlatformDestroy : MonoBehaviour
{
    public TextMeshPro Count;
    public float Seconds;
    bool Timer = false;

    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Timer = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Timer = false;
            
        }
    }

    private void Update()
    {
        if (Timer)
        {
            if (Seconds > 0)
            { Seconds -= Time.deltaTime;
                Count.text = ((int)Seconds).ToString(); }

            else
            {
                Destroy(gameObject);
            }

        }
    }
}
