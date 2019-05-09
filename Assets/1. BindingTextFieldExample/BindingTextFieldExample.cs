using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uBinding;

public class BindingTextFieldExample : MonoBehaviour
{

    public BindableString text;

    void OnGUI()
    {
        text.value = GUILayout.TextField(text.value);
    }
}
