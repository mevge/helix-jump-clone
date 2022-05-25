using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class PlayerManager : MonoBehaviour {

	public Rigidbody myRigidbody;
	GameManager gameManager;
	public float jumpForce;
	public GameObject splashPrefab, winText;
	string materialName;
	
	private void OnCollisionEnter(Collision other) {

		GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.23f, 0f), transform.rotation);
		splash.transform.SetParent(other.gameObject.transform);
		Destroy(splash, 1);

		myRigidbody.velocity = Vector3.up * jumpForce;   // Jumping with not jumping double.

		materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
		//Debug.Log("MaterialName:" + " " + materialName);   --> // Checking platform materials, which is safe or unsafe.

		if(materialName == "UnSafe_Mat (Instance)"){             // And tagging here as full name.
			
			SceneManager.LoadScene("MainScene");
		}else if(materialName == "Final_Mat (Instance)"){
			
			winText.SetActive(true);
			StartCoroutine(LoadLevelInTime());
		}
	}

	IEnumerator LoadLevelInTime(){
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("MainScene");
	}
}
