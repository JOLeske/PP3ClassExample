using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    Vector3 StartingPosition;
    [SerializeField]
    float MovementDelay = 1.0f;
    [SerializeField]
    float MovementRangeRadius = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartingPosition = gameObject.transform.position;
        StartCoroutine(Move());
    }



    // Update is called once per frame
    void Update()
    {
        //transform.position +=  new Vector3( Random.Range(-.25f, .25f) , 0.0f, Random.Range(-.25f, .25f) );
    }

    IEnumerator Move()
    {
        while (true)
        {
            Vector2 modifier = Random.insideUnitCircle * MovementRangeRadius;
            Vector3 NewPostition = StartingPosition;
            NewPostition.x += modifier.x;
            NewPostition.z += modifier.y;

            gameObject.transform.position = NewPostition;

            yield return new WaitForSeconds(MovementDelay);
        }
    }
}
