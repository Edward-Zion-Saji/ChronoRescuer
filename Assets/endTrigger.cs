using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public gameManager gameManager;

	void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}
}
