using UnityEngine;

public class PlayerTorque : MonoBehaviour
{
    [SerializeField] private float torqueAmount;
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
}
