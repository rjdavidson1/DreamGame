using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.IO;

public class ContinueScript : MonoBehaviour {
    private GameObject mouseoverL;
    private GameObject mouseoverR;
	// Use this for initialization

	void Start () {
        mouseoverL = GameObject.Find("MouseOver_ButtonC1");
        mouseoverR = GameObject.Find("MouseOver_ButtonC2");

        try {
        string[] saveinfo = File.ReadAllLines("save.txt");
        if (saveinfo[0] == "x") {
                    gameObject.SetActive(true);
               
            }
            } catch {
            Debug.Break();
            }

    }
	
	// Update is called once per frame
	void Update () {

        if (EventSystem.current.IsPointerOverGameObject())
            {
            mouseoverL.GetComponent<SpriteRenderer>().enabled = true;
            mouseoverR.GetComponent<SpriteRenderer>().enabled = true;
        } else {
            mouseoverL.GetComponent<SpriteRenderer>().enabled = false;
            mouseoverR.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
