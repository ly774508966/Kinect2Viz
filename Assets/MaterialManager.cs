﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : OSCControllable {

    public Material mat;

    [OSCMethod("matColor")]
    public void setMatColor(string id, Color32 c)
    {
        mat.SetColor(id, c);
    }

    [OSCMethod("matFloat")]
    public void setMatFloat(string id, float value)
    {
        mat.SetFloat(id, value);
    }

    [OSCMethod("matInt")]
    public void setMatInt(string id, int value)
    {
        mat.SetInt(id, value);
    }
}
