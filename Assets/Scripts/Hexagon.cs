using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

	public Rigidbody2D rb;

	// private GameObject m_player;

	public float shrinkSpeed = 3f;

	// Use this for initialization
	void Start () {
		rb.rotation = Random.Range(0f, 360f);
		transform.localScale = Vector3.one * 10f;
		// m_player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

		// Vector3 player_position = m_player.transform.position;
		// Debug.Log(player_position);
		if(transform.localScale.x <=  0.9f){
			Destroy(gameObject);
		}
	}
}
