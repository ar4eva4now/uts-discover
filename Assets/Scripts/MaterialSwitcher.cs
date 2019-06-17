using UnityEngine;

/**
 * A class to help switch GameObject materials on runtime.
 */
public class MaterialSwitcher : MonoBehaviour
{
    /**
     * A public function to switch the GameObject's 0th material property
     */
    public void SwitchMaterial(Material newMaterial)
    {
        // Change the first (and only) material over to the one given
        var mats = GetComponent<Renderer>().materials;
        mats[0] = newMaterial;
        GetComponent<Renderer>().materials = mats;
    }
}
