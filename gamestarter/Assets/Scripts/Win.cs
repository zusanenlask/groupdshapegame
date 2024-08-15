using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject winCanvas;

    private void Start()
    {
        winCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision Detected with: " + other.name); // This will log to the console

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Detected!"); // This will confirm the player tag detection
            winCanvas.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
