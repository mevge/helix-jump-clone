using UnityEngine;

public class PlatformMovement : MonoBehaviour {

	public float rotationSpeed;
	private float moveX;
	
	void Update () {

		moveX = Input.GetAxis("Mouse X");
		
		if(Input.GetMouseButton(0)){

		transform.Rotate(0f, moveX * rotationSpeed * Time.deltaTime, 0f);
		}
	}
}
