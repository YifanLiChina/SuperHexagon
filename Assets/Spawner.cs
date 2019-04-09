using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float spawneRate = 1f;

	public GameObject hexagonPrefab;

	private float m_nextTimeToSpawn = 0f;

	// Update is called once per frame
	void Update () {
		
		if(Time.time >= m_nextTimeToSpawn){

			Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
			m_nextTimeToSpawn = Time.time + 1f/spawneRate;
		}
	}
}
