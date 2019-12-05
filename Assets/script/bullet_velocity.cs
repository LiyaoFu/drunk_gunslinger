using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_velocity : MonoBehaviour
{
    float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = transform.rotation.eulerAngles;
        float rotation = Mathf.Deg2Rad*vec.z;
        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos(rotation), Mathf.Sin(rotation)) * 30;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
            Destroy(this.gameObject);
    }
}
