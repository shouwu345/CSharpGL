﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpGL;

namespace CSharpGL3.Demo
{
    public partial class FormMain
    {


        void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            this.renderAction.Render();
        }

    }
}
