using UnityEngine;
using System.Collections;

public class RocketBhv : MonoBehaviour
{
	public int upSpeed; // 100
	public int downSpeed; // 100
	public int leftSpeed; // 100
	public int rightSpeed; // 100
	Rigidbody2D body;

	// Use this for initialization
	void Start ()
	{
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (body == null) {
			Debug.LogWarning ("body not found");
			return;
		}

		float hax = Input.GetAxis ("Horizontal");
		float vax = Input.GetAxis ("Vertical");

		body.AddForce (Vector2.right * (rightSpeed * hax));
		body.AddForce (Vector2.up * (upSpeed * vax));

		if (Input.GetKey (KeyCode.Space)) {
			body.velocity = new Vector2 (0f, 0f);
			if (body.angularVelocity > 0)
				body.angularVelocity -= 150;
			if (body.angularVelocity < 0)
				body.angularVelocity += 150;
		}
	}
}
