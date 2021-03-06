﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// 
    /// </summary>
    public class ComponentBase
    {
        /// <summary>
        /// Game object that this componnet belongs to.
        /// </summary>
        public GameObject gameObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameObject">Game object that this componnet belongs to.</param>
        public ComponentBase(GameObject gameObject)
        {
            this.gameObject = gameObject;
        }
    }
}
