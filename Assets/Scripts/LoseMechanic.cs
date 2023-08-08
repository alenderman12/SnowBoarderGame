using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMechanic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("ReloadScene", 1.5f);
    }
    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
