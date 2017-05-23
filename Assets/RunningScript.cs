using UnityEngine;
using System.Collections;

public class RunningScript : MonoBehaviour {
	float speed = 20;
	public float power = 500f;
	private Rigidbody _rigidbody;

	// Use this for initialization
	void Start () {
		_rigidbody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += transform.forward * speed * Time.deltaTime;

		if(Input.GetKeyDown(KeyCode.RightArrow)){
			Vector3 pos = transform.position;
			pos.x += 5;
			transform.position = pos;
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			Vector3 pos = transform.position;
			pos.x -= 5;
			transform.position = pos;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			_rigidbody.AddForce (Vector3.up * power);
		}

	}
}
