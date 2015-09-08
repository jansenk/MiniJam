using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	private float movex;
	private float movey;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		rb.velocity = new Vector2 (movex * speed, movey * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		checkifWin (other);
	}

	void OnTriggerStay(Collider other){
		checkifWin (other);
	}

	void checkifWin(Collider other){
		if (Input.GetButtonDown ("Button 1") || Input.GetButtonDown ("Button 2")) {
			Debug.Log ("Win");
			MiniGame.Instance.ReportWin ();
		} else {
			Debug.Log ("In zone but not winning");
		}
	}
}

