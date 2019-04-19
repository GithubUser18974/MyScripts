using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour {
    private    GameObject bullet;
    public float power = 100.0f;
    public AudioClip shootSFX;
    public GameObject[] arrbullet;
    public Button re;
    public Button re2;
    private static int reloading = 0;
    private GameObject[] targets;
    private GameObject target;
    public Canvas canvas;
    private bool showingCanvas = false;
    void Start()
    {

        bullet = arrbullet[reloading];
        Button btn = re.GetComponent<Button>();
        btn.onClick.AddListener(rel1);

        Button btn2 = re2.GetComponent<Button>();
        btn2.onClick.AddListener(rel2);
    }
    void rel1()
    {
        if (reloading == 1)
            power /= 2;
        reloading = 0;
     
            bullet=arrbullet[reloading];
        canvas.gameObject.SetActive(false);


    }
    void rel2()
    {
        if (reloading==0)
            power *= 2;

        reloading = 1;
        
        bullet = arrbullet[reloading];

        canvas.gameObject.SetActive(false);

    }
    void Update () {
       
        if (Input.GetMouseButtonDown(0))
        {
            if (bullet)
            {
                
                ///////////////////////////////////////////////////////////////////////////////////////////////////////              
                if (reloading == 1)
                {
                    targets = GameObject.FindGameObjectsWithTag("zomby");
                    Debug.Log(targets.Length);
                    int minINDEX = 0;
                    for (int i = 1; i < targets.Length; i++)
                    {

                        if (targets[minINDEX].transform.position.z -Camera.main.transform.position.z> targets[i].transform.position.z - Camera.main.transform.position.z)
                        {
                            minINDEX = i;
                        }
                    }
                    try
                    { target = targets[minINDEX]; }
                    catch
                    {}
                    GameObject newbullet2 = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
                    if (!newbullet2.GetComponent<Rigidbody>())
                    {
                        newbullet2.AddComponent<Rigidbody>();

                    }
                   
                    if (target!= null)
                    {
                        Vector3 vec = new Vector3(0f, 1.0f, 0f);
                        
                        newbullet2.GetComponent<Rigidbody>().AddForce(-1 *target.transform.forward * power, ForceMode.VelocityChange);
                        newbullet2.transform.up = newbullet2.transform.up + newbullet2.transform.up + newbullet2.transform.up + 2*newbullet2.transform.up;
                    }

                    else
                    {
                        newbullet2.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);
                    }
                    if (shootSFX)
                    {
                        if (newbullet2.GetComponent<AudioSource>())
                        {
                            newbullet2.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                        }
                        else
                        {
                            AudioSource.PlayClipAtPoint(shootSFX, newbullet2.transform.position);
                        }
                    }

                }
                ////////////////////////////////////////////////////////////////////////////////////////////////////
                else
                {
                    GameObject newbullet = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as GameObject;
                    if (!newbullet.GetComponent<Rigidbody>())
                    {
                        newbullet.AddComponent<Rigidbody>();

                    }
                    newbullet.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);
                    if (shootSFX)
                    {
                        if (newbullet.GetComponent<AudioSource>())
                        {
                            newbullet.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                        }
                        else
                        {
                            AudioSource.PlayClipAtPoint(shootSFX, newbullet.transform.position);
                        }
                    }
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            if(showingCanvas)
            {
                canvas.gameObject.SetActive(false);
                showingCanvas = false;
            }
            else
            {
                canvas.gameObject.SetActive(true);
                showingCanvas = true;
            }
           
        }
    }

  

}
