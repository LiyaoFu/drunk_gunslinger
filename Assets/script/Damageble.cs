using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageble : MonoBehaviour
{
    [SerializeField] runningset Enemies;
    public SimpleHealthBar healthbar;
    public int health;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Enemies.myset.Remove(this.gameObject);
            Enemies.enemies_left--;
            Destroy(this.gameObject);
               
        }
        if(this.gameObject.tag == "Player")
        healthbar.UpdateBar(health, 3);
    }

}
