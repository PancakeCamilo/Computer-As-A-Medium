using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponRotate : MonoBehaviour
{
    public GameObject Weapon;
    public float moveSpeed = 5f;

    private float speedX;
    private float speedY;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            transform.localScale = new Vector3(-3.278266f, 3.278266f, 3.278266f); // Flip the sword to face left
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            transform.localScale = new Vector3(3.278266f, 3.278266f, 3.278266f); // Reset the sword orientation
        }
        else
        {
            speedX = 0f;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            transform.localScale = new Vector3(3.278266f, 3.278266f, 3.278266f);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            transform.localScale = new Vector3(3.278266f, -3.278266f, 3.278266f); // Flip the sword vertically
        }
        else
        {
            speedY = 0f;
        }
    }
}
