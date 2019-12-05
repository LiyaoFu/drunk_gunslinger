using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_initiate : MonoBehaviour
{
	public float range;
    [SerializeField] runningset Enemies;
    [SerializeField] GameObject bullet;
    public Vector3 targetposition;
    GameObject tar;
    private float speed = 10f;
    void Start()
    {
        Enemies.myset.Add(gameObject);
		range = 1.5f;
        StartCoroutine(ChangePosition());
	}
    IEnumerator ChangePosition()
    {
        while (true)
        {
            print("abc");
            print(Enemies.myset.Count);
            float ran = Random.Range(0.5f, 1f);
            float xcor = Random.Range(-7.93f, 7.41f);
            float ycor = Random.Range(-4.24f, 3.54f);
            targetposition = new Vector3(xcor, ycor, -1);
            tar = Enemies.myset[(int)(Random.value * Enemies.myset.Count) % Enemies.myset.Count];
            yield return new WaitForSeconds(1.0f * ran);
        }
    }
	void Update()
	{
        
        float step = speed * Time.deltaTime;

        var world_p_mouse = tar.transform.position;
        var difference_p = world_p_mouse - transform.position;
        var r = Mathf.Atan2(difference_p.y, difference_p.x);
        transform.eulerAngles = Vector3.forward * Mathf.Rad2Deg * (r);

        transform.position = Vector3.MoveTowards(transform.position, targetposition, step);
		//transform.Translate(targetposition*0.01f);
		range -= Time.deltaTime * Random.value;
		if (range <= 0.0f)
		{
			shoot();
		    range = 1.5f;
		}
	}
	void shoot()
	{
        GameObject B = Instantiate(bullet, transform.position, transform.rotation);
        B.transform.parent = null;
        B.GetComponent<Bullet_hit>().origin = this.gameObject;
    }

}
