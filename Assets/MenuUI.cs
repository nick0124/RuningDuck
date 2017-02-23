using UnityEngine;
using System.Collections;

public class MenuUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayBtn()
    {
        Application.LoadLevel(1);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void Repeat()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Menu()
    {
        Application.LoadLevel(0);
    }
}
