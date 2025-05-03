using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.AI;

public class KnockerBacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Taking a right click in to trigger knock back on any object with this component
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 clickposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 ForceDirection = transform.position - clickposition;

            StartCoroutine(knockbackDelay());
            GetComponent<Rigidbody>().AddForce(ForceDirection);
        }
    }

    IEnumerator knockbackDelay()
    {
        // getting the nav mesh for the parent object
        NavMeshAgent MyNav = GetComponent<NavMeshAgent>();
        if (MyNav)
        {
            //turning the navmesh off and on again with a delay to allow for physics
            MyNav.enabled = false;
            yield return new WaitForSeconds(.3f);
            MyNav.enabled = true;
        }

    }

}
