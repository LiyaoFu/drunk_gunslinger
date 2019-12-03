using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_initiate : MonoBehaviour
{
	public int health;
	public float range;
    [SerializeField] GameObject bullet;
    void Start()
	{
		health = 5;
		range = 3.0f;
	}
	void Update()
	{
		if(health<=0) Destroy(this.gameObject);
		range -= Time.deltaTime;
		if (range <= 0.0f)
		{
			shoot();
		    range = 3.0f;
		}
		else
		{
			move();
		}
	}
	void shoot()
	{
        GameObject B = Instantiate(bullet, transform.position, transform.rotation);
        B.transform.parent = null;
        B.GetComponent<Bullet_hit>().origin = this.gameObject;
    }
	void move()
	{
		
	}
}
