using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public float max_Health = 100f;
    public float cur_Health = 0f;

    public GameObject healthBar;


	// Use this for initialization
	void Start ()
    {
        cur_Health = max_Health;
        InvokeRepeating("decreasehealth", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update ()  {
	    	
	}

    void decreasehealth()
    {
        cur_Health -= 2f;
        float calc_Health = cur_Health / max_Health; // if cur 80/100 - 0.8f
        SetHealthBar(calc_Health);
    }

    public void SetHealthBar(float myHealth)
    {
        // myHealth value 0 ~ 1 , 
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

}
