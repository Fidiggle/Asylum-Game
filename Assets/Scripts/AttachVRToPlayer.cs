using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachVRToPlayer : MonoBehaviour
{
    public Transform playerPos;

    void Update()
    {
        transform.position = playerPos.position;
    }
}
