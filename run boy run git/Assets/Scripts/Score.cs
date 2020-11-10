
using System;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = Math.Max(0,player.position.z).ToString("0");

    }
}
