using UnityEngine;
using System.Collections;

public class PipeGenerator : MonoBehaviour {

	public Pipe pipes;
	public float spawnDistance;
	public float pipeSpeed;

	public float maxHeight = -5.5f;
	public float minHeight = -0.5f;

	private Pipe lastPipes;
	private Player p;

	// Use this for initialization
	void Start () {
		p = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		spawnPipes();
	}
	
	// Update is called once per frame
	void Update () {
		if(GameState.gameState == 0){
			if(lastPipes.transform.position.x <= 12-spawnDistance)
				spawnPipes();
		}
	}

	void spawnPipes(){
		lastPipes = (Pipe)Instantiate(pipes);
		lastPipes.p = p;
		lastPipes.speed = pipeSpeed;
		lastPipes.transform.position = new Vector3(12,Random.Range(minHeight,maxHeight),0);
	}
}
