using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	public float speed;
	public Player p;

	private bool isPassed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GameState.gameState == 0){
			transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
			if(transform.position.x < p.transform.position.x + p.renderer.bounds.size.x/2 && !isPassed){
				p.incScore();
				isPassed = true;
			}
			if(transform.position.x <= -9)
				Destroy(gameObject);
		}
	}
}
