using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMechanic : MonoBehaviour
{
    private ParticleSystem winParticles;
    private void Start()
    {
        winParticles = GetComponentInChildren<ParticleSystem>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        winParticles.Play();
        Invoke("ReloadScene", .5f);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
