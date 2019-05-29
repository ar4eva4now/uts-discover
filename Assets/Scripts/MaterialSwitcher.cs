using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTextureSwitcher : MonoBehaviour
{
    public Material newMaterial;

    public void SwitchMaterial()
    {
        var mats = GetComponent<Renderer>().materials;
        mats[0] = newMaterial;
        GetComponent<Renderer>().materials = mats;
    }
}
