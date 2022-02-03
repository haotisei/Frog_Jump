using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform CamTransform;
    public Transform Player;
    public Vector3 offset;
    public float followspeed;

    void Start()
    {
        CamTransform = Camera.main.transform;
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3(Player.position.x, CamTransform.position.y, Player.position.z);

        CamTransform.position = Vector3.Lerp(CamTransform.position, targetPosition + offset, Time.deltaTime * followspeed);
    }
}
