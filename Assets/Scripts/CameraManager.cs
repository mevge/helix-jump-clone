using UnityEngine;

public class CameraManager : MonoBehaviour {

	public Transform ball;
	Vector3 offset;
	public float smoothSpeed;

	void Start() {

		offset = transform.position - ball.position;
	}

	void Update() {
		
		Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed);
		transform.position = newPos;
	}

}
