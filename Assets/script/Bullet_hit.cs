using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_hit : MonoBehaviour
{
    public GameObject origin;
    public float range;
    bool flag;
    void Start()
    {
        range = 0.1f;
        flag = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject target = other.gameObject;
        if (target != origin && target.tag == "enemy" )
        {
            target.GetComponent<Enemy_initiate>().health--;
            Destroy(this.gameObject);
        }
        
    }
}
