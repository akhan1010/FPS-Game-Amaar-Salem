using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBottle : MonoBehaviour
{
    [SerializeField] GameObject[] pieces;
    [SerializeField] float velMultiplier = 2f;
    [SerializeField] float timeBeforeDestroying = 60f;

    void Start()
    {
        Destroy(this.gameObject, timeBeforeDestroying);
    }
    
    public void RandomVelocities()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            float xVel = Random.Range(0f, 1f);
            float yVel = Random.Range(0f, 1f);
            float zVel = Random.Range(0f, 1f);
            Vector3 vel = new Vector3(velMultiplier * xVel, velMultiplier * yVel, velMultiplier * zVel);

            Rigidbody rb = pieces[i].GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = vel;
            }
            else
            {
                Debug.LogWarning("Piece missing Rigidbody: " + pieces[i].name);
            }
        }
    }
}
