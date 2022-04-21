using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCheating : MonoBehaviour
{
     string url = "https://raw.githubusercontent.com/mohamedaraby122/Validations/master/BookFair.json";
    void Start()
    {
        StartCoroutine(StartUrl());
    }
    IEnumerator StartUrl()
    {
        WWW www = new WWW(url);
        yield return www;
        if (www.error == null)
        {
            string s = www.text;
            if (s.Contains("false"))
            { Application.Quit(); }
            
        }
    }
}
