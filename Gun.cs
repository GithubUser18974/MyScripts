using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public ViveHand Hand;

    public GameObject BulletPrefab;
    public Transform Muzzle;

    public AudioClip LaserClip;

    private AudioSource audioSrc;

    // Use this for initialization
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ViveInput.GetButtonDown(Hand, ViveButton.Trigger))
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = Muzzle.position;
            bullet.transform.rotation = Muzzle.rotation;

            bullet.GetComponent<Rigidbody>()
                .AddForce(Muzzle.forward * 4f, ForceMode.Impulse);

            audioSrc.PlayOneShot(LaserClip);
        }
    }
}
