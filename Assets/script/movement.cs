using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float adjust = 10;
        var world_p_mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var difference_p = world_p_mouse - transform.position;
        var r = Mathf.Atan2(difference_p.y, difference_p.x);
        transform.eulerAngles = Vector3.forward * Mathf.Rad2Deg * (r);
        rb.velocity = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * adjust;
    }
}
