using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puck : MonoBehaviour
{
    // Start is called before the first frame update
    public int pScore = 0;
    public int eScore = 0;
    public Vector3 sPos =new Vector3();
    public TMP_Text pScoreText;
    public TMP_Text eScoreText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("PlayerGoal"))
        {
            gameObject.GetComponent<Rigidbody2D>().MovePosition(sPos);
            gameObject.GetComponent<Rigidbody2D>().velocity =Vector2.zero;
            eScore++;
            eScoreText.text = eScore.ToString();
            
        }
        if (collision.gameObject.name.Contains("EnemyGoal"))
        {
            gameObject.GetComponent<Rigidbody2D>().MovePosition(sPos);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            pScore++;
            pScoreText.text = eScore.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
