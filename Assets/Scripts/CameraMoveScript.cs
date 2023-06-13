using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
	[SerializeField]
	private GameObject player;
	private Vector3 offset = new Vector3(0, 7, -7);
	private Vector3 playerPosition;
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		playerPosition = player.transform.position;

		this.transform.position = playerPosition + offset;
	}
}
