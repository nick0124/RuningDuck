using UnityEngine;
using System.Collections;

public class MoveByTouch : MonoBehaviour {

    public GameObject go;
    public Vector2 currentMousePos;
    public float mouseY;
    public float mouseX;
    public Vector2 additionVector;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
    void Update()
    {
        currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (currentMousePos.y < 0)
            mouseY = -currentMousePos.y;
        else
            mouseY = currentMousePos.y;

        if (currentMousePos.x < 0)
            mouseX = -currentMousePos.x;
        else
            mouseX = currentMousePos.x;



        if (Input.GetMouseButton(0))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (currentMousePos.y > 0)
                {
                    additionVector = (Vector2)go.transform.position + new Vector2(mouseX, -mouseY);
                    Debug.Log("X > 0 Y < 0");
                }
                if (currentMousePos.x > 0)
                {
                    additionVector = (Vector2)go.transform.position + new Vector2(-mouseX, mouseY);
                    Debug.Log("X < 0 Y > 0");
                }
                if (currentMousePos.x > 0 && currentMousePos.y > 0)
                {
                    additionVector = (Vector2)go.transform.position - new Vector2(mouseX, mouseY);
                    Debug.Log("X > 0 Y > 0");
                }
                if (currentMousePos.x < 0 && currentMousePos.y < 0)
                {
                    additionVector = (Vector2)go.transform.position + new Vector2(mouseX, mouseY);
                    Debug.Log("X < 0 Y < 0");
                }
            }
            go.transform.position = currentMousePos + additionVector;
        }
    }
}
