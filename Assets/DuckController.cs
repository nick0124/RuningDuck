using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DuckController : MonoBehaviour {

    public float jumpForce;
    public Animator animator;
    public bool grounded;
    public Text ingameScoreTxt;
    public Text aftergameScoreTxt;
    public GameObject endGameWindow;
    bool failure = false;
    float score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && grounded)
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        if (failure == false)
            score += Time.deltaTime;
        int scoreInt = (int)score;
        ingameScoreTxt.text = scoreInt.ToString();
        aftergameScoreTxt.text = scoreInt.ToString();
    }

    //возсожно нужно оптимизировать, или использовать стандарт метод
    //проверка в на земле или в воздухе игрок
    void OnCollisionEnter2D(Collision2D coll)
    {
        grounded = true;
        animator.SetBool("Grounded", true);

        //если столкновение с камнем то меню проигрыша активируется
        if (coll.gameObject.tag == "Rock")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000, 1000));
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            endGameWindow.SetActive(true);
            failure = true;
        }
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        grounded = false;
        animator.SetBool("Grounded", false);
    }
}
