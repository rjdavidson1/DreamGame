using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {


	// Use this for initialization
	void Start () {
        Driver.Timer = 30.0f;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
       
        //Print Time
        Driver.Timer -= Time.deltaTime;
        
        if (Driver.Timer <= 0)
        {
            Driver.Timer = 0;
        }
        
	}

    
    
}
