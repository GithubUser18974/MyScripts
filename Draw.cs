using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public GameObject BrushPrefab;

    public ViveHand Hand;

    private Color clr = Color.white;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var touch = ViveInput.GetTouchPoint(Hand);
        var angle = Mathf.Asin(touch.y / touch.magnitude) * Mathf.Rad2Deg;
        if (touch.x < 0)
        {
            angle = 180 - angle;
        }
        else if (touch.y < 0)
        {
            angle += 360;
        }

        if (!float.IsNaN(angle))
            clr = Color.HSVToRGB(angle / 360f, 1f, 1f);

        if (ViveInput.GetButtonState(Hand, ViveButton.Trigger))
        {
            var inst = Instantiate(BrushPrefab);
            inst.transform.position = ViveInput.GetPosition(Hand);
            inst.GetComponent<MeshRenderer>().material.color = clr;
        }
    }
}
