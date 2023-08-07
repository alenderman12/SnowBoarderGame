using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMechanic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
