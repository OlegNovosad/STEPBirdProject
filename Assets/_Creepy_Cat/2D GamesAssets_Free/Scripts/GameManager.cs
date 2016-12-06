using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject monetka;
	public GameObject serdechko;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateMonetkas", 1f, 1f);
		InvokeRepeating("CreateSerdechkos", 1f, 2f);
	}

	private void CreateMonetkas() {
		GameObject monetkaGO = Instantiate(monetka) as GameObject;
		monetkaGO.transform.position = new Vector2(monetkaGO.transform.position.x, Random.Range(0f, 4f));
	}

	private void CreateSerdechkos() {
		GameObject serdechkoGO = Instantiate(serdechko) as GameObject;
		serdechkoGO.transform.position = new Vector2(serdechkoGO.transform.position.x, Random.Range(-1f, 5f));
	}
}
