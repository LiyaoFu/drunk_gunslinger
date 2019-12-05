using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_hit : MonoBehaviour
{
    public GameObject origin;
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject target = other.gameObject;
        if (target != origin && (target.tag == "obstacle" || target.tag == "enemy" || target.tag == "Player"))
        {
            target.GetComponent<Damageble>().health--;
            Destroy(this.gameObject);
        }

    }
}
