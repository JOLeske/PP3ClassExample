using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  new Vector3( Random.Range(-.25f, .25f) , 0.0f, Random.Range(-.25f, .25f) );
    }
}
