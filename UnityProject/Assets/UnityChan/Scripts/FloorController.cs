using UnityEngine;
using System.Collections;

public class FloorController : BaseScript {

    public GameObject goal;
    public GameObject cube;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 20; i++)
        {
            float xPosition = Random.Range(-5, 5);
            float zPosition = Random.Range(10, 100);
            Instantiate(cube, new Vector3(xPosition, 0.4f, zPosition), Quaternion.identity);
        }


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
