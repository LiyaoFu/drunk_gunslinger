using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
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
        if (Input.GetMouseButtonDown(0))
        {
            GameObject B = Instantiate(bullet, transform.position, transform.rotation);
            B.transform.parent = null;
        }
        
        
    }
}
