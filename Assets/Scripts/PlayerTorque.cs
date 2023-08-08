using UnityEngine;

public class PlayerTorque : MonoBehaviour
{
    [SerializeField] private float torqueAmount;
    [SerializeField] private ParticleController particleController;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(-Input.GetAxisRaw("Horizontal") * torqueAmount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        particleController.PlayParticle("SnowParticles");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        particleController.StopParticle("SnowParticles");
    }
}
