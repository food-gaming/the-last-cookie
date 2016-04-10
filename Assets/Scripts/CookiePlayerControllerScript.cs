using UnityEngine;
using System.Collections;
using CnControls;

//[RequireComponent(typeof(CharacterController))]
public class CookiePlayerControllerScript : MonoBehaviour {

	[SerializeField] private float maxSpeed = 150f;                    // The fastest the player can travel in the x axis.

	private Rigidbody2D body;

	private void Awake()
	{
		body = GetComponent<Rigidbody2D>();
	}

	public void FixedUpdate()
	{
		body.velocity = new Vector2(CnInputManager.GetAxis("Horizontal") * maxSpeed * Time.deltaTime,
									CnInputManager.GetAxis("Vertical") * maxSpeed * Time.deltaTime);
	}
}
