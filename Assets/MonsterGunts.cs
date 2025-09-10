using NUnit.Framework;
using System.Numerics;
using UnityEngine;
using UnityEngine.Audio;

public class MonsterGunts : MonoBehaviour
{

    [SerializeField]
    AudioResource[] Grunts = new AudioResource[0];

    [SerializeField]
    AudioSource MosterSFX = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            PlayGrunt();
    }

    void PlayGrunt()
    {
        MosterSFX.resource = Grunts[Random.Range(0, Grunts.Length)];
        MosterSFX.Play();
    }

}
