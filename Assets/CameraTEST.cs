using UnityEngine;
using System.Collections;

public class CameraTEST : MonoBehaviour {
	public float playerX;
	public float playerY;
	public GameObject player;
	public GameObject Camm;
	public float CamX;
	public float camY;
	public float camHEIGHT;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		playerY = player.transform.position.y;
		playerX = player.transform.position.x;
				
		if(playerX > -40.0f && playerX <0.0f)
			CamX = -20.0f;
		if(playerX > -80.0f && playerX <-40.0f)
			CamX = -60.0f;
		if(playerX > -120.0f && playerX <-80.0f)
			CamX = -100.0f;
		if(playerX > -160.0f && playerX <-120.0f)
			CamX = -140.0f;
		if(playerX > -200.0f && playerX <-160.0f)
			CamX = -180.0f;
		if(playerX > -240.0f && playerX <-200.0f)
			CamX = -220.0f;
		if(playerX > -280.0f && playerX  <-240.0f)
			CamX = -260.0f;
		if(playerX > -320.0f && playerX  <-280.0f)
			CamX = -300.0f;
		if(playerX > -360.0f && playerX  <-320.0f)
			CamX = -340.0f;
		if(playerX > -400.0f && playerX  <-360.0f)
			CamX = -380.0f;
		if(playerX > -440.0f && playerX  <-400.0f)
			CamX = -420.0f;

		if(playerY < 30.0f && playerY >0.0f)
			camY = 15.0f;
		if(playerY < 60.0f && playerY >30.0f)
			camY = 45.0f;
		if(playerY < 90.0f && playerY >60.0f)
			camY = 75.0f;
		if(playerY < 120.0f && playerY >90.0f)
			camY = 105.0f;
		if(playerY < 150.0f && playerY >120.0f)
			camY = 135.0f;
		if(playerY < 180.0f && playerY >150.0f)
			camY = 165.0f;
		if(playerY < 210.0f && playerY >180.0f)
			camY = 195.0f;
		if(playerY < 240.0f && playerY >210.0f)
			camY = 225.0f;
		if(playerY < 270.0f && playerY >240.0f)
			camY = 255.0f;
		if(playerY < 300.0f && playerY >270.0f)
			camY = 285.0f;
		if(playerY < 330.0f && playerY >300.0f)
			camY = 315.0f;

		transform.position = new Vector3 (CamX, camY, camHEIGHT);
	}
}
