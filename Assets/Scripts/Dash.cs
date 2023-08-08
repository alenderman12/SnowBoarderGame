using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField] private float dashForce;
    [SerializeField] private float dashDuration;
    [SerializeField] private float dashCooldown;
    [SerializeField] private ParticleController particleController;
    private Rigidbody2D rb;
    private bool canUse = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && canUse)
        {
            particleController.PlayParticle("DashParticles");
            StartCoroutine(DashCo());
        }
    }

    private IEnumerator DashCo()
    {
        canUse = false;
        rb.velocity = transform.right * dashForce;
        yield return new WaitForSeconds(dashDuration);
        StartCoroutine(DashCooldown());
    }

    private IEnumerator DashCooldown()
    {
        yield return new WaitForSeconds(dashCooldown);
        canUse = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        particleController.StopParticle("DashParticle");
    }
}
