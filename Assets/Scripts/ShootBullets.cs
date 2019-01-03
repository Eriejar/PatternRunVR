using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour {
    public GameObject Emitter;
    public GameObject Bullet;
    public float BulletSpeed;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("ShootBullets Running");
		if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetButtonDown("Fire1"))
        {
            GameObject bulletHandler;
            bulletHandler = Instantiate(Bullet, Emitter.transform.position, Emitter.transform.rotation) as GameObject;
            bulletHandler.tag = "Bullet";
            Rigidbody bulletRb;
            bulletRb = bulletHandler.GetComponent<Rigidbody>();

            bulletRb.AddForce((transform.right * -1) * BulletSpeed, ForceMode.Impulse);

            Destroy(bulletHandler, 3.0f);
        }

	}
}
