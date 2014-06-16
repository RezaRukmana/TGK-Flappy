using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private static int score = 0;
	public float jumpVelocity;
	private Vector2 jumpVector;

	// Use this for initialization
	void Start () {
		jumpVector = new Vector2(0,jumpVelocity);
	}
	
	// Update is called once per frame
	void Update () {
		if(GameState.gameState == 0){
			checkPosition();
			if(Input.GetMouseButtonDown(0))
				flap ();
			transform.eulerAngles = new Vector3(0,0,rigidbody2D.velocity.y/7*30);
		}
	}

	void flap(){
		rigidbody2D.velocity = jumpVector;
	}

	void checkPosition(){
		if(transform.position.y > 7)
			transform.position = new Vector2(transform.position.x, 7);
	}

	public static int getScore(){
		return score;
	}

	public void incScore(){
		score++;
	}

	public void resetScore(){
		score=0;
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Obstacle" || other.gameObject.tag == "Ground" )
			GameState.gameState = 1; //game over
	}
}
