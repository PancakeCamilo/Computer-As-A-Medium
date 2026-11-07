using UnityEngine;

// When the player is on the trap (OnTriggerEnter2D)
// Something appears! (SetActive)

public class Trap : MonoBehaviour
{
    public GameObject popUp;
    public PlayerHealth playerHealth;
    void Start()
    {
    }
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.health -= 10;
            popUp.SetActive(true);
        }
    }
}