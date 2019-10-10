using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bullet_thermalDetonator : MonoBehaviour
{
    float lifeSpan = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeSpan -= Time.deltaTime;
        if(lifeSpan <= 0)
        {
            Explode();
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("lol");
        if((other.gameObject.CompareTag("Untagged")))
        {
            Debug.Log(other.gameObject.tag);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    void Explode()
    {
        Destroy(gameObject);
    }
}
