using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebController : MonoBehaviour
{
    public void OpenWebsite(string website)
    {
        Application.OpenURL(website);
    }
}