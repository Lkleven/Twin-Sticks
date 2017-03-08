using UnityEngine;
using System.Collections;

public class SelfieStick : MonoBehaviour {
	private GameObject player;
	private Vector3 armRotation;

	public float panSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		armRotation = transform.rotation.eulerAngles;
	
	}
	
	// Update is called once per frame
	void Update () {
		armRotation.y += Input.GetAxis ("RHoriz") * panSpeed;
		armRotation.x += Input.GetAxis ("RVert") * panSpeed;
		armRotation.x = Mathf.Clamp(armRotation.x, 180.01f, 359.99f);
	
		transform.position = player.transform.position;
		transform.rotation = Quaternion.Euler(armRotation);
	}
}
