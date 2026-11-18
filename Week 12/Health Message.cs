using System.Collections;
using UnityEngine;

public class HealthMessage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject halfHealthUI;
    private bool halfHealthMessageShown = false;

 
    // Update is called once per frame
    void Update()
    {
        CheckHalfHealth();
    }

    void CheckHalfHealth()
    {
        if (playerHealth.health <= 50 && halfHealthMessageShown == false)
        {
            halfHealthMessageShown = true;
            StartCoroutine(HalfHealthWarning());
        }
    }

    IEnumerator HalfHealthWarning()
    {
        halfHealthUI.SetActive(true);
        yield return new WaitForSeconds(3f);
        halfHealthUI.SetActive(false);
        playerHealth.healthText.text = "Health: 0";
        player.SetActive(false);
        yield return new WaitForSeconds(3f);
    }
}
