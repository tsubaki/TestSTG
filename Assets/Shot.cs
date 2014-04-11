using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public GameObject bullet;

	public float interval = 0.3f;

	void Start()
	{
		InvokeRepeating("Shoot", 0, interval);
	}

	void Shoot ()
	{
		var obj = GameObject.Instantiate( bullet , transform.position, transform.rotation) as GameObject;
		obj.SetActive(true );
	}
}
