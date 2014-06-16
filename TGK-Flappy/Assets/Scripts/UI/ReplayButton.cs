using UnityEngine;
using System.Collections;

public class ReplayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GameState.gameState == 0)
			Destroy(gameObject);
	}

	void OnMouseUp(){
		replay();
	}
	
	public void replay(){
		Player p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		p.transform.position = new Vector3(-4,1,0);
		p.transform.eulerAngles = new Vector3(0,0,0);
		p.resetScore();
		Camera.main.GetComponent<UI>().replayGame();
		GameObject[] pipes = GameObject.FindGameObjectsWithTag("Obstacle");
		for(int i=0;i<pipes.Length;i++)
			Destroy(pipes[i].gameObject);
		GameState.gameState = 0;
	}
}
