using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    float elapsedTime = 0;
    bool gameTimer = true;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = elapsedTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTimer)
        {
            elapsedTime += Time.deltaTime;
            scoreText.text = Mathf.Floor(elapsedTime).ToString();
        }
    }

    public void StopGameTimer()
    {
        gameTimer = false;
    }
}
