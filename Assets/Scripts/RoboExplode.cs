using UnityEngine;
using System.Collections;

public class RoboExplode : MonoBehaviour {
	
	//public AudioClip explosion;
	public Transform explosionPrefab;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Destroy(gameObject, 5);
	}
	
	
	void OnTriggerEnter(Collider hit) { 
//		Debug.Log("Collider hit: " + hit.gameObject.tag);
			Destroy(hit.gameObject);
		
		Instantiate(explosionPrefab, transform.position, transform.rotation);
		
		//Destroy(gameObject);
	}
	
	void OnCollisionEnter(Collision hit) { 
			Destroy(hit.gameObject);
		
		Instantiate(explosionPrefab, transform.position, transform.rotation);
		
	}
}
