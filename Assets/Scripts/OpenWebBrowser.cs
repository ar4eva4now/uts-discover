﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWebBrowser : MonoBehaviour
{
    public void OpenWebsite()
    {
        Application.OpenURL("https://www.uts.edu.au/about/faculty-engineering-and-information-technology");
    }
}
