using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PositionToSlider : MonoBehaviour
{
    [SerializeField] private Slider Slider;
    [SerializeField] private float maxSliderValue;
    private GameObject endPoint;

    // Start is called before the first frame update
    void Start()
    {
        endPoint = GameObject.FindWithTag("Finish");
        maxSliderValue = endPoint.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        Slider.value = transform.position.z/maxSliderValue;
    }
}
