using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PositionToSlider : MonoBehaviour
{
    [SerializeField] private Slider Slider;
    [SerializeField] private float maxSliderValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Slider.value = transform.position.z/maxSliderValue;
    }
}
