using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_hit : MonoBehaviour
{
    public float range;
    bool flag;
    void Start()
    {
        range = 0.1f;
        flag = false;
    }
    void Update()
    {
        if (flag == false)
        {
            range -= Time.deltaTime;
            if (range <= 0.0f)
            {
                flag = true;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (flag==true && (other.tag == "enemy" || other.tag == "Player"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
    }
}
