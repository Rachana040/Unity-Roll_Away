using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class PlayerController : MonoBehaviour {

    public GameObject enemy;
    int start;
    public float speed;
    private int count;
    public Text countText;
   
	// Use this for initialization
	void Start () {


        start = 0;
        count = 0;
        setCountText();
        
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "item")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }
         
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            countText.text = "GAME OVER";
           
        }
    }
    private void FixedUpdate()
    {
        if (start == 0)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    void setCountText()
    {
        if(count!=4)
            countText.text = "Count: " + count.ToString();
        else
        {
            countText.text = "BRAVO!!";
        }
    }
    // Update is called once per frame
    void Update () {
        if (count == 4)
        {
            start = 1;
        }
	}
}
