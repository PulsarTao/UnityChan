using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SplashScreen : BaseScript
{
	void NextLevel ()
	{
		Application.LoadLevel ("GameTitle");
	}
}
