using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GpalScript : MonoBehaviour
{


	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	//playerが侵入したら
	void OnTriggerEnter(Collider other)
	{
		//playerが侵入したら
		if (other.gameObject.name == "Player")
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("EndScene");
		}
	}
}
