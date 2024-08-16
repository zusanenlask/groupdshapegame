using UnityEngine;
using UnityEngine.SceneManagement;



public class Key : MonoBehaviour
{
 
    public static bool playerhaskey;

    private void Start()
    {
       playerhaskey=false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision Detected with: " + other.name); // This will log to the console

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Detected!"); // This will confirm the player tag detection
            playerhaskey = true;
        }
    }

    public static bool haskey(){
        if (playerhaskey)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}