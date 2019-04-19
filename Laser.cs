using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject CrosshairPrefab;

    private GameObject crosshairInst;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (crosshairInst == null)
                crosshairInst = Instantiate(CrosshairPrefab);

            crosshairInst.transform.position = hit.point;
        }
        else
        {
            if (crosshairInst != null)
                Destroy(crosshairInst);
        }
    }
}
