using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HexagonPlayer : MonoBehaviour {

	public float moveSpeed = 600f;

	float m_movement = 0f;
	
	// Update is called once per frame
	void Update () {
		m_movement = Input.GetAxisRaw("Horizontal");
	}

	void FixedUpdate(){
		// Debug.Log(m_movement);
		transform.RotateAround(Vector3.zero, Vector3.forward, m_movement * Time.fixedDeltaTime * -moveSpeed);
	}

	void OnTriggerEnter2D(Collider2D collision){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
