using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = new Vector3(GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition.x, GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition.y);
	}
}
