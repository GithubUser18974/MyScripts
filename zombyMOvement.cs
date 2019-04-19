using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombyMOvement : MonoBehaviour {
    public Transform Player;
    public float  MoveSpeed = 4.0f;
    public float MaxDist = 10.0f;
    public float MinDist = 5.0f;
    private void Start()
    {
        Player = Camera.main.transform;
        
    }
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                
            }

        }
    }
   
}