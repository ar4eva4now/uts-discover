using UnityEngine;

/**
 * A class to help cycle through a list of materials at runtime.
 * To be used in conjunction with the MaterialSwitcher.
 */
public class MaterialCycler : MonoBehaviour
{
    // Public fields
    public Material[] materials;
    
    // Private fields
    private int _current = 0;
    
    /**
     * A public function to cycle to the next material.
     */
    public void CycleMaterial()
    {
        // Get a copy of the MaterialSwitcher and make the switch
        var materialSwitcher = GetComponent<MaterialSwitcher>();
        materialSwitcher.SwitchMaterial(materials[_current]);
        
        // Increment the value, clamping it between 0 and the length of the list
        _current = ++_current % materials.Length;
    }
}
