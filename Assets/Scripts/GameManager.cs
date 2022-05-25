using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	private int counter;
	public Text scoreText; 
	public GameObject winText;

	private void Start() {
		
		winText.SetActive(false);
	}

	public void Score(int ringScore){

		counter += ringScore;
		scoreText.text = counter.ToString();
	}
}
