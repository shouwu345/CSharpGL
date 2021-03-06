﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// contains parameters for some OpenGL code.
    /// </summary>
    public abstract class GLNode
    {
        internal abstract Type SelfTypeCache { get; }

        private List<GLNode> children = new List<GLNode>();
        /// <summary>
        /// 
        /// </summary>
        public List<GLNode> Children { get { return this.children; } }

    }
}
