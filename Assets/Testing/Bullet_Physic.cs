using UnityEngine;
using UnityEngine.InputSystem;
public class Bullet_Physic : MonoBehaviour
{
    Rigidbody2D bullet_rb;
       void Start()
    {
        bullet_rb = GetComponent<Rigidbody2D>();
        bullet_rb.angularDamping = 0.5f;
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.IsPressed())
        {
            bullet_rb.AddForceAtPosition(bullet_rb.transform.up*10f, new Vector2(0,0));
            Debug.Log("Lifted");
        }
    }
}
