using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uBinding;

public class InspectorBindingExample : MonoBehaviour
{
    public BindableBool visiable;
    public BindableVector3 position;
    public BindableQuaternion rotation;
    public BindableVector3 scale;
    public BindableColor lightColor;
    [TextArea] public BindableString text;
}
