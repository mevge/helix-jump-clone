using UnityEngine;

public class RingController : MonoBehaviour {

	public Transform ball;
	GameManager gameManager;

	void Start() {

		gameManager = GameObject.FindObjectOfType<GameManager>();	
	}
	
	void Update () {
		
		if(transform.position.y >= ball.position.y){

			Destroy(gameObject);
			gameManager.Score(25);
		}
	}
}
