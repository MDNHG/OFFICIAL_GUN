using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Enemy : MonoBehaviour
{
    private GameObject enemy;
    private float health = 100f;
    [SerializeField] private Damage_zone damage;
    void Start()
    {
        enemy = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<Damage_zone>() != null)
        {
            Damage();
            Debug.Log("In Damage zone");
        }

    }
    void Damage()
    {
        health -= 20;
        Debug.Log("It hurt, it hurt" + health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
