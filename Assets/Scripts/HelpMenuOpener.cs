using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMenuOpener : MonoBehaviour
{
    public GameObject helpPanel;
    //public Button helpButton;

    public void DisplayHelpMenu()
    {

        if (helpPanel != null)
        {
            Animator animator = helpPanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isSlideIn = animator.GetBool("SlideIn");
                animator.SetBool("SlideIn", !isSlideIn);

            }
        }
    }

}


