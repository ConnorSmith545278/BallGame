using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public float score;
    private Rigidbody rb;
    private Movement moveScript;
    [SerializeField] private TextMeshProUGUI scoreBox;
    [SerializeField] private TextMeshProUGUI MultiplierBox;
    [SerializeField] private TextMeshProUGUI powerBox;
    private float multiplier;
    [SerializeField] private float power;
    [SerializeField] private float maxMultiplier;
    GameManager gm;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveScript = GetComponent<Movement>();
        gm = GameObject.FindWithTag("GameManager").gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //calculate with multiplier
        multiplier = rb.velocity.z/moveScript.maxSpeed*maxMultiplier + 1;
        gm.score += rb.velocity.z * Mathf.Pow(multiplier,power) * Time.deltaTime;
        //set to readable string
        powerBox.text = power.ToString();
        MultiplierBox.text =  "X" + multiplier.ToString("#.0");
        
    }

    private void OnDestroy()
    {
    }
}
