﻿using FluentBootstrap.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Forms
{
    public class InputButton : FormControl,
        IHasButtonExtensions, IHasButtonStateExtensions, IHasDisabledAttribute, 
        IHasTextContent, IHasValueAttribute, IHasNameAttribute
    {
        internal InputButton(BootstrapHelper helper, ButtonType buttonType)
            : base(helper, "input", Css.Btn, Css.BtnDefault)
        {
            MergeAttribute("type", buttonType.GetDescription());
        }

        protected override bool OutputEndTag
        {
            get { return false; }
        }
    }
}
