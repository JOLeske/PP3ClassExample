using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIQuickFollow : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] NavMeshAgent MyNavMeshAgent;    

    [SerializeField] int navemeshupdates =0;


    // Start is called before the first frame update
    void Start()
    {
        MyNavMeshAgent = GetComponent<NavMeshAgent>();

        //////////////
        // Get Target
        //////////////

        // Find Via Name
        Target = GameObject.Find("Follow Point");

        // Find Via Tag
         //Target = GameObject.FindWithTag("Player");

        // Find Via GM
        //Target = gamemanager.instance.Target;

        // Allow Paths in the background
        //MyNavMeshAgent.SetDestination(Target.transform.position);
        

        // Force path calculation on spawn
       NavMeshPath path = new NavMeshPath();
       if (NavMesh.CalculatePath(transform.position, Target.transform.position, NavMesh.AllAreas, path))
       {
           MyNavMeshAgent.SetPath(path);
       }

        
        // Start coroutine to update destination point should it move.
        StartCoroutine(UpdateFollowPoint());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator UpdateFollowPoint()
    {
        while (true)
        {
            if (Target && MyNavMeshAgent.enabled && MyNavMeshAgent.hasPath)
            {
                Debug.LogError("DEBUG LOG ERROR: SETTING DESTINATION POINT: " + Target.transform.position);

                //for(int i = 0;i<100; i++)
                    MyNavMeshAgent.SetDestination(Target.transform.position);
            }

            navemeshupdates++;

            ///////////////////////////
            // updating target location Timer
            ///////////////////////////

            //Reset target location every frame
            yield return null;

            //Reset Target location every 1/8 of a second
            //yield return new WaitForSeconds(0.1250f);

            //Reset target within a range of every 1/8 - 1/4 of a second
            //yield return new WaitForSeconds(0.01250f + Random.Range(0, 0.0125f));

        }
    }
}
