using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "runtimeset")]
public class runningset : ScriptableObject
{

    public List<GameObject> myset;
    public int enemies_left;
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
