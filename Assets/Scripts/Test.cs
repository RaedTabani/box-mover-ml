using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Collider collider;
    public Bounds bounds;
    void Start()
    {
        bounds = collider.bounds;
        Debug.Log(bounds.extents.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
