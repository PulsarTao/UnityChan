using UnityEngine;
using System.Collections;

public class UIObjectController : BaseScript {
	
	public GUISkin guiSkin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frameZ:\Unity\UnityChan
	void Update () {
	
	}


	void OnGUI(){
		if (guiSkin == null)
			return;

		GUI.skin = guiSkin;

		int buttonX = Screen.width / 2;
		int buttonY = Screen.height / 2;
		if (GUI.Button (new Rect (buttonX, buttonY, 200, 100), "GameStart")) {
			Application.LoadLevel("TestStage");
		}
	}
}
