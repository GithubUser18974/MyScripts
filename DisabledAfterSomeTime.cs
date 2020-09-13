using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledAfterSomeTime : MonoBehaviour
{
    public float time = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeadNow());
    }

   IEnumerator DeadNow()
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
