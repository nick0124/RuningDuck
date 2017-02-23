using UnityEngine;
using System.Collections;

public class Paralax : MonoBehaviour {

    public float scrollSpeed = 0.1f;
    public GameObject triggerGo;
    public Vector2 vec;

    //акпкдклать в 1 скрипт где слои хранятся в массиве

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //
        Vector3 speed = new Vector3(scrollSpeed, 0, 0);
        gameObject.transform.position -= speed;

        vec = triggerGo.transform.position;
        if (triggerGo.transform.position.x <= 0)
        {
            gameObject.transform.position = new Vector2(0, gameObject.transform.position.y);//переделать
        }
	}
}
