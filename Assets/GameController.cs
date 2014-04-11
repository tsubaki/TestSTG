using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	void PlayerDead()
	{
		Invoke("ResetStage", 1);
	}

	void ResetStage()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
