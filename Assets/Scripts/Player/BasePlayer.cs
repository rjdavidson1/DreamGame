using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        Acceleration = 0.05f;
        JumpSpeed = 1.0f;
        Player = gameObject;
        MaxSpeed = 0.3f;
        Driver.Player = Player;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Run"))
        {
            if (Speed < MaxSpeed)
            {
                Speed = Speed + Acceleration;
            }
            else
                Speed = MaxSpeed;
            Player.transform.localPosition = new Vector3((Player.transform.localPosition.x + Speed), Player.transform.localPosition.y, Player.transform.localPosition.z);
        }

        if (Input.GetButtonDown("Jump"))
        {
            //JumpSpeed = JumpSpeed + Gravity;
            Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, (Player.transform.localPosition.y + JumpSpeed), Player.transform.localPosition.z);

        }

	}

    void OnCollision2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform"))
        {
            Driver.CurrentPlatform = col.gameObject;
        }
        if (col.gameObject.CompareTag("Alarm"))
        {
            Driver.Timer += 5f;
        }
        if (col.gameObject.CompareTag("Sheep"))
        {
            sheepCaptured();
        }
        if (col.gameObject.CompareTag("Goat"))
        {
            Dead = true;
        }
        if (col.gameObject.CompareTag("Bottom"))
        {
            Dead = true;
        }
        if (Dead)
        {
            Driver.playerDied();
        }
    }

    private void sheepCaptured()
    {
        SheepCount++;
        if (SheepCount == Driver.SheepCount)
        {
            Driver.levelBeat();
        }
    }

    public GameObject Player { get; set; }
    public float Acceleration { get; set; }
    public float JumpSpeed { get; set; }
    public float Speed { get; set; }
    public float MaxSpeed { get; set; }
    public float Gravity { get; set; }
    public bool Dead { get; set; }
    public int SheepCount { get; set; }

}
