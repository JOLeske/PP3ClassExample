using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIQuickFollow : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] GameObject Weapon;
    [SerializeField] NavMeshAgent MyNavMeshAgent;
    [SerializeField] GameObject RetreatePoint;

    [SerializeField] int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 300;
        MyNavMeshAgent = GetComponent<NavMeshAgent>();
        StartCoroutine(UpdateFollowPoint());
        StartCoroutine(EnemyBounce());
    }

    // Update is called once per frame
    void Update()
    {
        // See if the avatar has a target and their navmesh is enabled. If they do then move to that target
        if (health < 15)
        {
            //Debug.Log("RUNN AWAY");
            Target = RetreatePoint;
        }
    }


    IEnumerator UpdateFollowPoint()
    {
        while (true)
        {
            if (Target && MyNavMeshAgent.enabled)
            {
                //Debug.Log("SETTING DESTINATION POINT");
                Debug.LogError("Set destination point");
                //Debug.LogError("Destination set to " + Target.transform.position);

                    MyNavMeshAgent.SetDestination(Target.transform.position);

                    
            }
            yield return new WaitForSeconds(0.1250f +Random.Range(0,0.125f));
        }
    }

    IEnumerator EnemyBounce()
    {
        while (true)
        {
            this.gameObject.transform.position += new Vector3(0, 0.25f, 0);
            Physics.SyncTransforms();
            yield return new WaitForSeconds(3.0f);
        }
    }
}
