using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlinkUntilButton : MonoBehaviour
{
    [SerializeField] private float blinkTime;
    private float startBlinkTime;
    private TextMeshProUGUI box;
    private string boxContents;
    [SerializeField] private KeyCode clickedKey1;
    [SerializeField] private KeyCode clickedKey2;

    // Start is called before the first frame update
    void Start()
    {
        startBlinkTime = blinkTime;
        box = GetComponent<TextMeshProUGUI>();
        boxContents = box.text;
        
    }

    // Update is called once per frame
    void Update()
    {
        blinkTime -= Time.deltaTime;
        if(blinkTime < 0)
        {
            blinkTime=startBlinkTime;
            if(box.text != "")
            {
                box.text = "";
            }
            else
            {
                box.text = boxContents;
            }
        }
        if(Input.GetKey(clickedKey1) || Input.GetKey(clickedKey2)) 
        {
            Destroy(gameObject);
        }
    }
}
