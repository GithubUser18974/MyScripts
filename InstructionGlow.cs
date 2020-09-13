using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionGlow : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Head")
        {
            this.gameObject.SetActive(false);
        }
    }
}
