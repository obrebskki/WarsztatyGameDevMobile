using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float playerSpeed;
    private Rigidbody2D playerRigidbody;
    [SerializeField]
    private Color32 colorRed;
    [SerializeField]
    private Color32 colorYellow;
    [SerializeField]
    private Color32 colorPurple;
    [SerializeField]
    private Color32 colorBlue;


    private PLAYER_COLORS currentPlayerColor;
    private SpriteRenderer playerSprite;



    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        currentPlayerColor = PLAYER_COLORS.RED;
        playerSprite.color = colorRed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            playerRigidbody.velocity = Vector2.up * playerSpeed;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == GameProperties.BLUE_TAG)
        {
            if (!(currentPlayerColor == PLAYER_COLORS.BLUE))
                gameObject.SetActive(false);
        }
        else if (collision.transform.tag == GameProperties.RED_TAG)
        {
            if (!(currentPlayerColor == PLAYER_COLORS.RED))
                gameObject.SetActive(false);
        }
        else if (collision.transform.tag == GameProperties.YELLOW_TAG)
        {
            if (!(currentPlayerColor == PLAYER_COLORS.YELLOW))
                gameObject.SetActive(false);
        }
        else if (collision.transform.tag == GameProperties.PURPLE_TAG)
        {
            if (!(currentPlayerColor == PLAYER_COLORS.PURPLE))
                gameObject.SetActive(false);
        }
        else if (collision.transform.tag == GameProperties.STAR_TAG)
        {
                gameObject.SetActive(false);
                ScoreScript.Incrementscore();
        }
    }
}

public enum PLAYER_COLORS { RED = 1, BLUE, YELLOW, PURPLE }