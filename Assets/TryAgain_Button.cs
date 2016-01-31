using UnityEngine;
using System.Collections;

public class TryAgain_Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)&&gameObject.GetComponent<Collider2D>().bounds.Contains(Input.mousePosition))
        {
            Driver.GameOver(1);
        }
    }
}
