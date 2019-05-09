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
        data.textData.Bind(OnDataUpdate);
    }
    void OnDisable()
    {
        data.textData.Unbind(OnDataUpdate);
    }

    void OnDataUpdate(string str)
    {
        text.text = str;
    }
}
