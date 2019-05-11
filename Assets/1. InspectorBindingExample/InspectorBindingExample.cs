using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uBinding;

public class InspectorBindingExample : MonoBehaviour
{
    public BoolBinding visiable;
    public Vector3Binding position;
    public QuaternionBinding rotation;
    public Vector3Binding scale;
    public ColorBinding lightColor;
    [TextArea] public StringBinding text;
}
