using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uBinding;

public class InputFieldExample : MonoBehaviour
{

    [Multiline] public BindableString text;

    public void OnInputFieldEndEdit(string text)
    {
        this.text.value = text;
    }
}
