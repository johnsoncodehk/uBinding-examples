using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVP_Presenter : MonoBehaviour
{

    public MVP_Model model;
    public MVP_View view;

    void Start()
    {
        view.slider.onValueChanged.AddListener(UpdateModel);
    }
    void OnEnable()
    {
        model.volume += UpdateView;
    }
    void OnDisable()
    {
        model.volume -= UpdateView;
    }

    void UpdateModel(float volum)
    {
        model.volume.value = volum;
    }
    void UpdateView(float volum)
    {
        view.slider.value = volum;
        view.text.text = "Volum: " + volum;
    }
}
