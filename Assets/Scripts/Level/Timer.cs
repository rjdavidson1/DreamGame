using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {


	// Use this for initialization
	void Start () {
        TimeLeft = 30.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Print Time
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            TimeLeft = 0;
        }
	}

    public float TimeLeft { get; set;}
    
}
