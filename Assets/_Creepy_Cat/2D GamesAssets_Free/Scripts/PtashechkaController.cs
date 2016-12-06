using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PtashechkaController : MonoBehaviour {

	Rigidbody2D rb2D;
	public Vector2 jumpForce = new Vector2(0, 300);

	// Use this for initialization
	void Start () {
		rb2D = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			Jump();
		} else if (Input.GetKeyUp(KeyCode.Return)) {
			Crawl();
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y >= Screen.height) {
			Die();
		}
	}

	private void Jump() {
		rb2D.velocity = Vector2.zero;
		rb2D.AddForce(jumpForce);
	}

	private void Crawl() {
		rb2D.velocity = Vector2.zero;
		rb2D.AddForce(-jumpForce);
	}

	private void Die() {
		Destroy(gameObject);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Pidloga" || other.gameObject.tag == "Monetka") {
			Die();
		} else if (other.gameObject.tag == "Serdechko") {
			Destroy(other.gameObject);
		}
	}
}
