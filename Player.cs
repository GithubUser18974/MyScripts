using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject RightHand, LeftHand;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RightHand.transform.position = ViveInput.GetPosition(ViveHand.Right);
        RightHand.transform.rotation = ViveInput.GetRotation(ViveHand.Right);
        LeftHand.transform.position = ViveInput.GetPosition(ViveHand.Left);
        LeftHand.transform.rotation = ViveInput.GetRotation(ViveHand.Left);
    }
}
