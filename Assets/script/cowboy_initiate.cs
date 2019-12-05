using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cowboy_initiate : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] runningset Enemies;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        Enemies.myset.Add(gameObject);
        Enemies.enemies_left = 4;

    }

    // Update is called once per frame
    void Update()
    {
        if (Enemies.enemies_left < 1)
            text.SetActive(true);
    }
}
