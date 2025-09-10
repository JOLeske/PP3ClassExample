using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{


    [SerializeField] private float TimeToSelfDestruct = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Destroy the containing object after the time has passed.
        Destroy(gameObject, TimeToSelfDestruct);
    }
}
