using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Paralax2 : MonoBehaviour {

    public float scrollSpeed = 0.1f;
    public RectTransform triggerGo;
    public Vector2 startPos;
    public Vector2 vec;

    //акпкдклать в 1 скрипт где слои хранятся в массиве

	// Use this for initialization
	void Start () {
        startPos = gameObject.GetComponent<RectTransform>().position;
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 speed = new Vector3(0, scrollSpeed, 0);
        gameObject.GetComponent<RectTransform>().position -= speed;

        vec = triggerGo.position;
        if (triggerGo.position.y <= 0)
        {
            gameObject.GetComponent<RectTransform>().position = new Vector2(gameObject.GetComponent<RectTransform>().position.x, 0);//переделать
        }
         
	}
}
