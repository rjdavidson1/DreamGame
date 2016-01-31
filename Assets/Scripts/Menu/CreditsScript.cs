using UnityEngine;
using System.Collections;

public class CreditsScript : MonoBehaviour {
    private GameObject credits;
	// Use this for initialization
	void Start () {
        credits = GameObject.Find("Credits_Button");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

        }
	}
}
