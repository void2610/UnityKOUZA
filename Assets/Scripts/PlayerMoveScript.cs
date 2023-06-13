using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
	private GameObject _player;
	private Rigidbody _rigidbody;


	[SerializeField]
	private float speed = 5f;

	// Start is called before the first frame update
	void Start()
	{
		_player = this.gameObject;
		_rigidbody = _player.GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			_rigidbody.AddForce(Vector3.forward * speed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			_rigidbody.AddForce(Vector3.back * speed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			_rigidbody.AddForce(Vector3.left * speed);
		}
		if (Input.GetKey(KeyCode.D))
		{
			_rigidbody.AddForce(Vector3.right * speed);
		}
	}
}
