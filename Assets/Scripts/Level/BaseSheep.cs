using UnityEngine;
using System.Collections;

public class BaseSheep : MonoBehaviour {

    public GameObject player;
    private GameObject standingPlatform;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        if (TimeUp == true)
        {
            gameObject.tag = "Goat";

        }
        else
            gameObject.tag = "Sheep";
        if (TimeUp==true && Driver.CurrentPlatform.Equals(standingPlatform)){

            float platformLeftEdge = (standingPlatform.GetComponent<BoxCollider2D>().size.x / 2f)-standingPlatform.GetComponent<BoxCollider2D>().offset.x;
            float platformRightEdge = (standingPlatform.GetComponent<BoxCollider2D>().size.x / 2f) + standingPlatform.GetComponent<BoxCollider2D>().offset.x;
            if (transform.localPosition.x > platformLeftEdge && transform.localPosition.x < platformRightEdge)
            {
                transform.localPosition = new Vector3((transform.localPosition.x + Driver.Player.GetComponent<BasePlayer>().MaxSpeed), transform.localPosition.y, transform.localPosition.z);
            }
        }
	}

    void OnCollision2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            standingPlatform = col.gameObject;
        }
    }
    public bool TimeUp { get; set; }
}
