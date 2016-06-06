using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class WaterColliderToggle : MonoBehaviour {

	public bool ShowWaterColliders;
	void DontShowThem()
	{
		Debug.Log ("DONT SHOW THEM");
		Renderer[] rs = GetComponentsInChildren<Renderer>();
		foreach(Renderer r in rs)
			r.enabled = false;
	}
	void ShowThem()
	{
		Debug.Log ("SHOW THEM");
		Renderer[] rs = GetComponentsInChildren<Renderer>();
		foreach(Renderer r in rs)
			r.enabled = true;
	}
	void Update()
	{
		if (ShowWaterColliders == true) 
		{
			ShowThem ();
		}

		if (ShowWaterColliders == false) 
		{
			DontShowThem ();
		}
	}
}
