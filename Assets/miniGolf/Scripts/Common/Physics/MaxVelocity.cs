using UnityEngine;
using System.Collections;
/// <summary>
/// Max velocity of a rigidbody.
/// </summary>
public class MaxVelocity : MonoBehaviour {
	
	/// <summary>
	/// The max speed.
	/// </summary>/
	public float maxSpeed = 9.5f;
	
	void Update () {
		if(rigidbody && rigidbody.velocity.magnitude > maxSpeed)
		{
			rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}
	}
}
