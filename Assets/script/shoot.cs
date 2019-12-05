using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    public float range = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnMouseDown()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(range <= 0.0f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject B = Instantiate(bullet, transform.position, transform.rotation);
                B.transform.parent = null;
                B.GetComponent<Bullet_hit>().origin = this.gameObject;
                range = 0.0f;
            }
            

        }
        else
        {
            range -= Time.deltaTime;
        }


    }
}
