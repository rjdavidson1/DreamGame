using UnityEngine;
using System.Collections;

public class ContinueScript : MonoBehaviour {
    private GameObject mouseoverL;
    private GameObject mouseoverR;
	// Use this for initialization
	void Start () {
        mouseoverL = GameObject.Find("MouseOver_ButtonC1");
        mouseoverR = GameObject.Find("MouseOver_ButtonC2");
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
