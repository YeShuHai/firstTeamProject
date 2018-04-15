using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {

    public float x;
    public float y;
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {Debug.Log("OK");
            Vector2 f = new Vector2(x, y);
            other.rigidbody.AddForce(f);
        }
    }
}
