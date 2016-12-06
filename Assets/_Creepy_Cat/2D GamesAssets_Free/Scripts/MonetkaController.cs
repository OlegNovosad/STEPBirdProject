using UnityEngine;
using System.Collections;

public class MonetkaController : MonoBehaviour {

	Vector2 velocity = new Vector2(-10, 0);

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
