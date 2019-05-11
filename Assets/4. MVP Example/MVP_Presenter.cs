using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVP_Presenter : MonoBehaviour
{

    public MVP_Model model;
    public MVP_View view;

    void Start()
    {
        view.slider.onValueChanged.AddListener(vol =>
        {
            model.volume.value = vol;
        });
    }
    void OnEnable()
    {
        model.volume += OnVolumeChanged;
    }
    void OnDisable()
    {
        model.volume -= OnVolumeChanged;
    }

    void OnVolumeChanged(float volum)
    {
        view.slider.value = volum;
        view.text.text = "Volum: " + volum;
    }
}
