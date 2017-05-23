using UnityEngine;
using System.Collections;

public class roadCreatingScript : MonoBehaviour {
	public GameObject road;
	float timer = 0;
	int interval = 20;
	float speed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (interval <= timer) {
			Instantiate (road, transform.position, transform.rotation);
			timer = 0;
		}

		this.transform.position += transform.forward * speed * Time.deltaTime;

	}

}
