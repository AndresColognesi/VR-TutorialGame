using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnActivate : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireSpeed = 20;
    private AudioSource gun_soundFX;


    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        // Attach listener function to grabbed object:
        grabbable.activated.AddListener(FireBullet);

        // Get audio source from current game object:
        gun_soundFX = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireBullet(ActivateEventArgs arg)
    {
        // Create a bullet instance:
        GameObject spawnedBullet = Instantiate(bullet);
        // Set to proper spawn position:
        spawnedBullet.transform.position = spawnPoint.position;
        // Play shooting sound effect:
        gun_soundFX.Play();
        // Give forward velocity to bullet:
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        // Destroy the bullet after 5 seconds:
        Destroy(spawnedBullet, 5);
    }
}
