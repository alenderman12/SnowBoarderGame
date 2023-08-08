using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMechanic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("ReloadScene", .5f);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
