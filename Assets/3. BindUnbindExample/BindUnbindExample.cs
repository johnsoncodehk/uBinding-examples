using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BindUnbindExample : MonoBehaviour
{

    public BindUnbindExampleData data;
    public Text text;

    void OnEnable()
    {
        data.textData += OnDataUpdate;
    }
    void OnDisable()
    {
        data.textData -= OnDataUpdate;
        text.text = "Unbind Success!";
    }

    void OnDataUpdate(string str)
    {
        text.text = str;
    }
}
