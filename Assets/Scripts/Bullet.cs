using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public float lifeTime = 3;
    public Vector2 damageRange = new Vector2(10, 20);
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        var damage = Random.Range(damageRange.x, damageRange.y);
        Destroy(other.gameObject, damage);
        print($"Hit {other.gameObject} for {damage} damage");
    }
}
