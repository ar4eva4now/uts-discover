using UnityEngine;

public class MaterialSwitcher : MonoBehaviour
{
    public void SwitchMaterial(Material newMaterial)
    {
        var mats = this.GetComponent<Renderer>().materials;
        mats[0] = newMaterial;
        this.GetComponent<Renderer>().materials = mats;
    }
}
