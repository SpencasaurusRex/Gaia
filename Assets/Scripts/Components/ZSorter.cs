using UnityEngine;

public class ZSorter : MonoBehaviour {
	private const float Scale = .1f;
	
	void FixedUpdate () {
		Vector3 pos = transform.localPosition;
		pos.z = pos.y * Scale;
		transform.localPosition = pos;
	}
}
