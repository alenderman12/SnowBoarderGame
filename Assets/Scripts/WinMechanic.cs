using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMechanic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = new Vector3(0, 0, 0);
        collision.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
