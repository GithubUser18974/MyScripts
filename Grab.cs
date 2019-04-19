using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public ViveHand Hand;

    private Rigidbody grabbedBody;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbedBody == null)
        {
            if (ViveInput.GetButtonDown(Hand, ViveButton.Trigger))
            {
                var pos = ViveInput.GetPosition(Hand);
                var cols = Physics.OverlapSphere(pos, 0.08f);

                if (cols.Length > 0)
                {
                    grabbedBody = cols[0].GetComponent<Rigidbody>();
                    grabbedBody.isKinematic = true;
                }
            }
        }
        else
        {
            grabbedBody.transform.position = ViveInput.GetPosition(Hand);
            grabbedBody.transform.rotation = ViveInput.GetRotation(Hand);

            if (ViveInput.GetButtonUp(Hand, ViveButton.Trigger))
            {
                grabbedBody.velocity = ViveInput.GetVelocity(Hand);
                grabbedBody.angularVelocity = ViveInput.GetAngularVelocity(Hand);

                grabbedBody.isKinematic = false;
                grabbedBody = null;
            }
        }
    }
}
