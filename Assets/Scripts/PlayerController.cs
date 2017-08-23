using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float Speed;
	public float SprintModifier;

	private Character character;

	void Start() {
		character = new Character();
	}

	void FixedUpdate () {
		float dx = Input.GetAxisRaw("Horizontal");
		float dy = Input.GetAxisRaw("Vertical");
		Vector3 movement = new Vector3(dx, dy, 0);
		
		float scale = Time.deltaTime * Speed;

		// Sprinting
		if (Input.GetKey(KeyCode.LeftShift)) {
			scale *= SprintModifier;
		}

		// Move character
		transform.localPosition += movement * scale;
	}
}
