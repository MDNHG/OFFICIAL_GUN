using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Projectile : MonoBehaviour
{
    GameObject bullet;
    Rigidbody phy_bullet;
    Cannon cannon;
    float timer = 4f;
     void Start()
    {
        bullet = GetComponent<GameObject>();
        Rigidbody2D phy_bullet = bullet.AddComponent<Rigidbody2D>();

    }

    void Update()
    {
        if(bullet != null)
        {
        phy_bullet.AddForceAtPosition(bullet.transform.up*1000f, new UnityEngine.Vector2(0,0));
        phy_bullet.AddForce(new UnityEngine.Vector2(0,-1)*9.8f);
        }
    }
    void FixedUpdate()
    {
        timer -=1*Time.deltaTime;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D wall = collision.otherCollider;
        float angle = UnityEngine.Vector2.Dot(bullet.transform.up, wall.transform.up);
        Debug.Log("Collider speed" + collision.relativeVelocity.magnitude);
        Debug.Log("Collider angle" + angle);
        Destroy(bullet);
    }
}
