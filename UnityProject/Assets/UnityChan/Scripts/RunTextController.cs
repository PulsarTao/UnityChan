using UnityEngine;
using System.Collections;

public class RunTextController : BaseScript {
	
	public float runMeter = 100.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "残り距離:" + runMeter.ToString("0.00");

	}

	void OnGUI(){
//		if(runMeter < 0.0f){
//			if(GUI.Button(new Rect(0, 0, Screen.width, Screen.height), "一時停止")){
//				Application.LoadLevel("GameTitle");
//			}
//		}
	}
}
