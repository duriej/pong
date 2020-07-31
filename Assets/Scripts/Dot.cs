using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
	private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Fire(float direction, float force=1f)
    {
        var radians = direction * Mathf.Deg2Rad;
        var vec = new Vector2((float)Mathf.Cos(radians), (float)Mathf.Sin(radians)) * force;
    	rigidBody.AddForce(vec);
    }
}
