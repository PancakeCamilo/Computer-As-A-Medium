using UnityEngine;

// I need to make a trap where
// when the player is on the trap (OnTriggerEnter2D)
// something appears! (SetActive)

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.ComapreTag("Player"))
        {
            playerHealth.health -= 10;
        }
    }
}