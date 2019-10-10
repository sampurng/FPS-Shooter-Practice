using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsShooter : MonoBehaviour
{
    public GameObject Bullet_Prefab;
    public float bulletImpulse = 300000000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            //Camera cam = Camera.main;
            //GameObject theBullet = (GameObject)(Instantiate(bulletPrefab, cam.transform.position, cam.transform.rotation));
            //theBullet.GetComponent<RigidBody>().AddForce( cam.transform.forward * bulletImpulse, ForceMode.Impulse);
            //theBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);
            Camera cam = Camera.main;
			GameObject thebullet =(GameObject)Instantiate(Bullet_Prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
			thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
        }
        
    }
}
