using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Slider bar;

    public float getValue()
    {
        return bar.value;
    }

    public void setValue(int v)
    {
        bar.value = v;
    }

    public void changeValue(int v)
    {
        bar.value += v;
    }
}
