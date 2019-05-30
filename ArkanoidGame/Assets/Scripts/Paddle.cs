using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paddle : MonoBehaviour { 

[SerializeField] float screenWidthInUnits = 16f;
[SerializeField] float minX = 1f;
[SerializeField] float maxX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
    Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
    paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
    transform.position = paddlePos;

        Debug.Log(Input.mousePosition.x/Screen.width);
    }
    void Win()
    {
        if ((GameObject.FindGameObjectsWithTag("brick")).Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}
