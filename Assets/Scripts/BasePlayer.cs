using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        Acceleration = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Run"))
        {
            if (Speed < 0.3)
            {
                Speed = Speed + Acceleration;
            }
            Player.transform.localPosition = new Vector3((Player.transform.localPosition.x + Speed), Player.transform.localPosition.y, Player.transform.localPosition.z);
        }

        if (Input.GetButtonDown("Jump"))
        {
            JumpSpeed = JumpSpeed + Gravity;
            Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, (Player.transform.localPosition.y + JumpSpeed), Player.transform.localPosition.z);

        }

	}


    public GameObject Player { get; set; }
    public float Acceleration { get; set; }
    public float JumpSpeed { get; set; }
    public float Speed { get; set; }
    public float Gravity { get; set; }
    public bool Dead { get; set; }

}
