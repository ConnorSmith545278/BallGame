using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private float score;
    private int scoreAsInt;
    private Rigidbody rb;
    [SerializeField] private TextMeshProUGUI scoreBox;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        score += rb.velocity.z * Time.deltaTime;
        scoreBox.text = ((int) score).ToString("D9"); 
    }
}
