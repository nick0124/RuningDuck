using UnityEngine;
using System.Collections;

public class MovingParalax : MonoBehaviour {

    public Transform cameraObj;
    public RectTransform firstObj;
    public RectTransform secondObj;

    public Vector3 cameraObjPos;
    public Vector3 firstObjPos;
    public Vector3 secondObjPos;

    public float objYsize;

    public Vector2 startPos;

	// Use this for initialization
	void Start () {
        startPos = firstObj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        cameraObjPos = cameraObj.position;
        firstObjPos = firstObj.anchoredPosition;
        secondObjPos = secondObj.anchoredPosition;

        objYsize = secondObj.sizeDelta.y;

        firstObj.transform.position -= Vector3.up/2;
        secondObj.transform.position -= Vector3.up/2;
        if (secondObj.position.y <= cameraObj.position.y)
        {
            //firstObj.position = new Vector3(0, secondObj.sizeDelta.y, 0);
            firstObj.anchoredPosition = secondObj.anchoredPosition + new Vector2(0, secondObj.sizeDelta.y);
            Debug.Log(new Vector3(0, secondObj.sizeDelta.y, 0));
        }
        if (firstObj.position.y <= cameraObj.position.y)
        {
            //firstObj.position = new Vector3(0, secondObj.sizeDelta.y, 0);
            secondObj.anchoredPosition = firstObj.anchoredPosition + new Vector2(0, firstObj.sizeDelta.y);
            Debug.Log(new Vector3(0, secondObj.sizeDelta.y, 0));
        }
	}
}
