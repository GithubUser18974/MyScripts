using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// LET'S START THIS FUCKING GAME :)

public class GunMoving : MonoBehaviour {
    private Vector3 currRot;
    public float  speed =6f;
// Update is called once per frame
    void Update()
    {
        currRot.x -= Input.GetAxis("Mouse Y") * speed;
        currRot.x = Mathf.Clamp(currRot.x, -90, 90);
        currRot.y += Input.GetAxis("Mouse X") * speed;
        transform.localRotation = Quaternion.Euler(currRot);
    }
}

