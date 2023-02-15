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
			Vector2 mousePos = Input.mousePosition;
			Debug.Log(mousePos.x);
			Debug.Log(mousePos.y);
			goal = new Vector2 (mousePos.x/2,mousePos.y/2);
			//inTravel = true;
		}
		if (Input.GetKeyDown(KeyCode.A)){
			transform.position += -transform.right * Time.deltaTime * speed;
			inTravel = !inTravel;
		}
		if (inTravel) {
			//transform.LookAt(goal,Vector2.left);
			transform.position += -transform.right * Time.deltaTime * speed;

			//inTravel = false;
		}
		
    }
}
