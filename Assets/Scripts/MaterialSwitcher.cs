using UnityEngine;

public class MaterialSwitcher : MonoBehaviour
{
    public Material newMaterial;
    
    private GameObject _switchObject;

    private void Start()
    {
        _switchObject = GameObject.Find("VRSphere");
    }

    public void SwitchMaterial()
    {
        var mats = _switchObject.GetComponent<Renderer>().materials;
        mats[0] = newMaterial;
        _switchObject.GetComponent<Renderer>().materials = mats;
    }
}
