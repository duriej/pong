using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    public float defaultForce = 100;
	private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    public void Fire(float direction)
    {
        Fire(direction, defaultForce);
    }

    public void Fire(float direction, float force)
    {
        Debug.LogFormat("Firing: {0} : {1}", direction, force);
        var radians = direction * Mathf.Deg2Rad;
        var vec = new Vector2((float)Mathf.Cos(radians), (float)Mathf.Sin(radians)) * force;
        rigidBody.velocity = Vector2.zero;
        rigidBody.AddForce(vec);
    }
}
