using UnityEngine;
using System.Collections;

public class TESTMove : MonoBehaviour {
	public Vector3 MOVEdir;
	public Vector3 moveDIRS;
	public float HA;
	public float VA;
	public float SPEED;
	public float multiplier;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		CharacterController controller = GetComponent<CharacterController> ();
		if (Input.GetButton ("Sprint"))
			multiplier = 1.5f;
		if (!Input.GetButton ("Sprint"))
			multiplier = 1.0f;
		HA = -Input.GetAxis ("Horizontal");
		VA = Input.GetAxis ("Vertical");
		moveDIRS = new Vector3 (HA, VA, SPEED);
		MOVEdir = new Vector3 (moveDIRS.x, moveDIRS.y);
		//transform.position += (MOVEdir * moveDIRS.z * Time.deltaTime * multiplier);

		controller.Move (MOVEdir * Time.deltaTime * multiplier * SPEED);
	}
}
