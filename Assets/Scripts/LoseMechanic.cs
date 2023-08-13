using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMechanic : MonoBehaviour
{
    [SerializeField] private ParticleController particleController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        particleController.PlayParticle("BloodParticles");
        Invoke("ReloadScene", 1.5f);
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
