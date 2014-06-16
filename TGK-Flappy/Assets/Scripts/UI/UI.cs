using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public GUIStyle uiStyle = new GUIStyle();
	public GameObject replayButton;

	private bool buttonInitiated = false;

	// Use this for initialization
	void Start () {
		uiStyle.alignment = TextAnchor.MiddleCenter;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label(new Rect(Screen.width/2,0,50,50), ""+Player.getScore(), uiStyle);
		if(GameState.gameState == 1){
			GUI.Label(new Rect(Screen.width/2,Screen.height/3,50,50), "Game Over", uiStyle);
			if(!buttonInitiated){
				Instantiate(replayButton);
				buttonInitiated = true;
			}
		}
	}

	public void replayGame(){
		buttonInitiated = false;
	}
}
