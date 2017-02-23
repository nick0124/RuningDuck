using UnityEngine;
using System.Collections;

public class RockSpawner : MonoBehaviour {

    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    private float lastRockPosX;
    public float rockSpeed = 0.1f;

    /*                                    ВНИМАНИЕ!!!
      Программный код представленный ниже может нанести вред вашему психическому здоровью
      после увиденного 1 человека повесился, 6 потеряли рассудок, у 4 возникла развилась программирования*/

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        //переделать в циклы
        if (rock1.transform.position.x > rock2.transform.position.x && rock1.transform.position.x > rock3.transform.position.x)
            lastRockPosX = rock1.transform.position.x;
        if (rock2.transform.position.x > rock1.transform.position.x && rock2.transform.position.x > rock3.transform.position.x)
            lastRockPosX = rock2.transform.position.x;
        if (rock3.transform.position.x > rock1.transform.position.x && rock3.transform.position.x > rock2.transform.position.x)
            lastRockPosX = rock3.transform.position.x;

        Vector3 speed = new Vector3(rockSpeed, 0, 0);
        rock1.transform.position -= speed;
        rock2.transform.position -= speed;
        rock3.transform.position -= speed;

        if(rock1.transform.position.x<-8)
        {
            rock1.transform.position = new Vector2(lastRockPosX + 15, rock1.transform.position.y);
        }
        if (rock2.transform.position.x < -8)
        {
            rock2.transform.position = new Vector2(lastRockPosX + 15, rock2.transform.position.y);
        }
        if (rock3.transform.position.x < -8)
        {
            rock3.transform.position = new Vector2(lastRockPosX + 15, rock3.transform.position.y);
        }
    }
}
