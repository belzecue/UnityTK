﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEssentials.DataBinding
{
    /// <summary>
    /// Databinding field attribute that can be used to draw inspector fields for databinding node fields using a ui popup.
    /// </summary>
    public class DataBindingMethodAttribute : PropertyAttribute
    {
        public string parentNodeField = "parentNode";
    }
}