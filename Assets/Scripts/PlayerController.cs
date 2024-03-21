using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject gameOverTextObject;
    public float totalTime = 60f;
    private float timeLeft;
    private int count;
    public TextMeshProUGUI timeText;

    public Button restartButton;
    public Button menuButton;

    public AudioClip colisionSound;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
        gameOverTextObject.SetActive(false);
        timeLeft = totalTime;

    }
    public void RestartGame()
    {
        // retorna a tela ao normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    void SetCountText()
    {
        countText.text = "Pontos: " + count.ToString();

    }

    void Update()
    {
        UpdateTime();

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(colisionSound);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("Esfera") || other.gameObject.CompareTag("Cilindro"))
        {
            StartCoroutine(Example());
            count = count - 1;
            SetCountText();
        }
        
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = new Color(0, 220f / 255f, 255f / 255f);
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = new Color(0, 220f / 255f, 255f / 255f);
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Renderer>().material.color = new Color(0, 220f / 255f, 255f / 255f);
    }

    void UpdateTime()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0 || count < 0)
        {
            timeLeft = 0;
            gameOverTextObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            menuButton.gameObject.SetActive(true);
            //bloqueia a  tela
            Time.timeScale = 0;

        }
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
        timeText.text = "Tempo : " + Mathf.Round(timeLeft).ToString();
    }
}


