using UnityEngine;
using System.Collections;

public class ObstacleCreatngScript : MonoBehaviour {
	public GameObject Obstacle;
	public GameObject Obstacle2;
	public GameObject Obstacle3;
	public GameObject Obstacle4;
	float timer = 0;
	int interval = 1;
	float speed = 28.75f;
	public int randomCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){
		this.transform.position += transform.forward * speed * Time.deltaTime;

		timer += Time.deltaTime;
		randomCount = Random.Range (0, 6);

		if (interval <= timer) {
			if (randomCount == 0) {
				float x = 7.372527f;
				float y = transform.position.y;
				float z = transform.position.z;
				Instantiate (Obstacle, new Vector3 (x, y, z), transform.rotation);
				timer = 0;
			} else if (randomCount == 1) {
				float x = 2.29252f;
				float y = transform.position.y;
				float z = transform.position.z;
				Instantiate (Obstacle, new Vector3 (x, y, z), transform.rotation);
				timer = 0;
			} else if (randomCount == 2) {
				float x = -2.607472f;
				float y = transform.position.y;
				float z = transform.position.z;
				Instantiate (Obstacle, new Vector3 (x, y, z), transform.rotation);
				timer = 0;
			} else if (randomCount == 3) {
				Instantiate (Obstacle2, transform.position, transform.rotation);
				timer = 0;
			} else if (randomCount == 4) {
				Instantiate (Obstacle3, transform.position, transform.rotation);
				timer = 0;
			} else if (randomCount == 5) {
				Instantiate (Obstacle4, transform.position, transform.rotation);
				timer = 0;
			}
		}
	}

	void OnCollisionEnter(Collision other){
				speed = 0;
	}
}
