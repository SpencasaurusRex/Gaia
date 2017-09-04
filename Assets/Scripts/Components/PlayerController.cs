using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	[Range(0.02f, 1f)]
	public float CameraRigidity;
	public float Speed;
	public float SprintModifier;
	public float Force;

	private Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	void Update() {
	}

	void FixedUpdate () {
		float dx = Input.GetAxisRaw("Horizontal");
		float dy = Input.GetAxisRaw("Vertical");
		Vector2 movement = new Vector2(dx, dy);
		
		float scale = Time.fixedDeltaTime * Speed * Force;

		// Sprinting
		if (Input.GetKey(KeyCode.LeftShift)) {
			scale *= SprintModifier;
		}

		// TODO add deadzone

		// Move character
		rb.AddForce(movement * scale, ForceMode2D.Force);
	
		// Have main camera lerp towards character
		// TODO make VectorUtils to handle extra Z component on Vector3s
		Vector3 newCamPos = Vector3.Lerp(Camera.main.transform.position, transform.position, CameraRigidity);
		newCamPos.z = Camera.main.transform.position.z;
		Camera.main.transform.position = newCamPos;
	}
}
