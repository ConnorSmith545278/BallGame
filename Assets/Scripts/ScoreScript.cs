using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private float score;
    private int scoreAsInt;
    private Rigidbody rb;
    private Movement moveScript;
    [SerializeField] private TextMeshProUGUI scoreBox;
    [SerializeField] private TextMeshProUGUI MultiplierBox;
    private float multiplier;
    [SerializeField] private float maxMultiplier;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveScript = GetComponent<Movement>();

    }

    // Update is called once per frame
    void Update()
    {
        multiplier = rb.velocity.z/moveScript.maxSpeed*maxMultiplier + 1;
        score += rb.velocity.z * multiplier * Time.deltaTime;
        MultiplierBox.text =  "X" + multiplier.ToString("#.0");
        scoreBox.text = ((int) score).ToString("D9"); 
    }
}
