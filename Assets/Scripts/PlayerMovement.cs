using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    readonly Rigidbody myRigidBody;
    private bool turnLeft, turnRight;
    private float speed = 6.0f;
    private CharacterController myCharacterController;
    public int score = 0;
    public Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {

        myCharacterController = GetComponent<CharacterController>();
        

}


    // Update is called once per frame
    /* void Update()
     {

         if(!alive) return;

         if(transform.position.y<0.5){
             // Die();
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         }

         turnLeft = Input.GetKeyDown(KeyCode.A);
         turnRight = Input.GetKeyDown(KeyCode.D);


         if (turnLeft)
             transform.Rotate(new Vector3(0f, -90f, 0f));
         else if (turnRight)
             transform.Rotate(new Vector3(0f, 90f, 0f));

         myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
         myCharacterController.Move(transform.forward * speed * Time.deltaTime);
         ScoreText.text = score.ToString();
         if(score >= 3)
         {
             speed = 7.0f;
         }
         if(score >= 5)
         {
             speed = 10.0f;
         }



     }*/

    void Update()
    {
        if (!alive) return;

        if (transform.position.y < 0.5)
        {
            SceneManager.LoadScene("FallDeath");
        }

        /* bool turnLeft = Input.GetKeyDown(KeyCode.A) || Input.touchCount > 0 && Input.GetTouch(0).position.x < Screen.width / 2;
         bool turnRight = Input.GetKeyDown(KeyCode.D) || Input.touchCount > 0 && Input.GetTouch(0).position.x > Screen.width / 2;

         if (turnLeft)
             transform.Rotate(new Vector3(0f, -90f, 0f));
         else if (turnRight)
             transform.Rotate(new Vector3(0f, 90f, 0f));*/

        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);

        // Touch input for turns
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2f)
                    turnLeft = true;
                else
                    turnRight = true;
            }
        }

        if (turnLeft)
            transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            transform.Rotate(new Vector3(0f, 90f, 0f));


        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);
        ScoreText.text = score.ToString();

        if (score >= 3)
        {
            speed = 7.0f;
        }
        if (score >= 5)
        {
            speed = 10.0f;
        }
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (score <= -2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        if (collision.gameObject.tag == "assignment")
        {
            score += 2;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "obstacle")
        {
            score--;
            Destroy(collision.gameObject);
            
        }
        else if(collision.gameObject.tag == "finish")
        {
            Finish();
        }

    }
     
    public void Die()
    {
        Debug.Log(score);
        alive = false;
        SceneManager.LoadScene("FallDeath");

    }
    public void Finish()
    {
        if(score >= 7)
        {
            SceneManager.LoadScene("endScreen");
        }
        else
        {
            SceneManager.LoadScene("LowScore");
        }
    }
}



