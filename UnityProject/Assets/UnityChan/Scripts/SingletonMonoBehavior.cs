using UnityEngine;
using System.Collections;

public class SingletonMonoBehavior<T> : MonoBehaviour where T : MonoBehaviour
{

	private static T instance;

	public static T Instance {
	
		get{
			if(instance == null){
				instance = (T)FindObjectOfType(typeof(T));
				if(instance == null){
					Debug.LogError(typeof(T) + "is Error");
				}
			}
			return instance;
		}
	}


}

