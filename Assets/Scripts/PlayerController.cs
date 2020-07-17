using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{    
    #region variable declaration
    private Rigidbody rb; 
    public float speed;
    public GameObject[] randomPickUps;
    private float timeLeft;
    public bool MoveLeft;
    public bool MoveRight;
    public bool MoveUp;
    public bool MoveDown;
    private float _moveHorizontal;
    private float _moveVertical;
    public static int count;

    #endregion

    #region start
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        timeLeft = 30;
    }
    #endregion

    #region Update
    // provides velocity to the ball
    void Update()
    {
        if (MoveLeft)
        {
            _moveHorizontal = -1;
        }

        if (MoveRight)
        {
            _moveHorizontal = 1;
        }
        else if (!MoveRight && !MoveLeft)
        {
            _moveHorizontal = 0.0f;
        }

        if (MoveUp)
        {
            _moveVertical = 1;
        }


        if (MoveDown)
        {
            _moveVertical = -1;
        }
        else if (!MoveDown && !MoveUp)
        {
            _moveVertical = 0.0f;
        }

        if (Mathf.Abs(_moveHorizontal) < 0.01f && Mathf.Abs(_moveVertical) < 0.01f)
            return;
        
        Vector3 movement = new Vector3(_moveHorizontal, 0.0f, _moveVertical);

        rb.velocity = movement * speed;
    }
    #endregion

    #region Game check
    private void FixedUpdate()
    {
        if (count >= 15 && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            UIController.Instance.time.text = ((int) timeLeft).ToString();
        }
        else if (timeLeft <= 0)
        {
            UIController.Instance.time.text = 0.ToString();
        }

        if (timeLeft <= 0)
        {
            rb.freezeRotation = true;
            if (count >= 20)
            {
                UIController.Instance.winText.text = "YOU WON!!!";
            }
            else
            {
                UIController.Instance.winText.text = "YOU Loose!!!";
            }
        }
    }
    #endregion

    #region OnTriggerEnter
    //This portion works when ball hits a pick up
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            UIController.Instance.SetCountText();
            rb.mass += 1;
            if (count > 14)
            {
                int randomInt = Random.Range(0, 8);
                float random = Random.Range(-4, 4);
                Vector3 position = new Vector3(random, 0.5f, random);
                Instantiate(randomPickUps[0], position, transform.rotation);
                rb.mass += 1;
            }
        }
    }
    #endregion


}