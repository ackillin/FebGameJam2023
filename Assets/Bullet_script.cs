using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_script : MonoBehaviour
{
	private bool inTravel = false;
	private Vector3 goal;
	public float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log("");
			Debug.Log(worldPosition.x);
			Debug.Log(worldPosition.y);
			goal = new Vector2 (worldPosition.x,worldPosition.y);
			
			//inTravel = true;
		}
		if (Input.GetKeyDown(KeyCode.A)){
			transform.position += transform.forward * Time.deltaTime * speed;
			transform.LookAt(goal, Vector2.up);
			inTravel = !inTravel;
		}
		if (inTravel) {
			transform.position += transform.forward * Time.deltaTime * speed;

			//inTravel = false;
		}
		
    }
}
