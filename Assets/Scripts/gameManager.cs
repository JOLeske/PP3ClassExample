using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Singleton instance for global access
    public static gamemanager instance;

    // Core Object Refrences
    private GameObject _target;
    public GameObject Target
    { 
        get { return _target; } 
    }
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instance = this;

        _target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
