using UnityEngine;

public class MaterialCycler : MonoBehaviour
{
    public Material[] materials;
    
    public void CycleMaterial()
    {
        var mats = this.GetComponent<Renderer>().materials;
        mats[0] = materials[0];
        this.GetComponent<Renderer>().materials = mats;
    }
}
