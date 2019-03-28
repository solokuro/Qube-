using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneback : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{
		
		{
			if (Input.GetKey(KeyCode.Q)&& Input.GetKey(KeyCode.E))
			{
				SceneManager.LoadScene("Game");
			 
			}
		}
	}
}
