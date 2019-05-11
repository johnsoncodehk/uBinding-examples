using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using uBinding;

public class CustomTypeExample : MonoBehaviour
{

    /* Any Custom Type */

    public enum Fruit
    {
        Apple,
        Banana,
        Mango,
        Pomelo,

    }

    /* Support in program, not support in Editor Inspector */

    public Binding<Fruit> fruit_1 = new Binding<Fruit>(Fruit.Apple);


    /* Full Surrpot! */

    [System.Serializable] public class FruitBindingEvent : UnityEvent<Fruit> { }
    [System.Serializable]
    public class FruitBinding : Binding<Fruit, FruitBindingEvent, FruitBinding>
    {
        public FruitBinding(Fruit value) : base(value) { }
    }

    public FruitBinding fruit_2 = new FruitBinding(Fruit.Banana);

    /* Log Change */

    void Awake()
    {
        fruit_2 += val => print(val);
    }
}
