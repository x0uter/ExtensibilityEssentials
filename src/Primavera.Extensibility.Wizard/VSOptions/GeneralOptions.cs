﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primavera.Extensibility.Options
{
    internal class GeneralOptions : BaseOptionModel<GeneralOptions>
    {
        [Category("ERP Settings")]
        [DisplayName("Installation Path")]
        [Description("PRIMAVERA installation path.")]
        public string Path { get; set; } = @"C:\Program Files (x86)\PRIMAVERA\SG100\APL\";

        [Category("ERP Settings")]
        [DisplayName("User Name")]
        [Description("PRIMAVERA user name.")]
        public string UserName { get; set; }

        [Category("ERP Settings")]
        [DisplayName("Password")]
        [Description("PRIMAVERA user password.")]
        [PasswordPropertyText(true)]
        public string Password { get; set; } 

        [Category("ERP Settings")]
        [DisplayName("Company")]
        [Description("PRIMAVERA company name.")]
        public string Company { get; set; }

        [Category("ERP Settings")]
        [DisplayName("Product line")]
        [Description("PRIMAVERA product line. 0 = Executive; 1 = Professional")]
        [DefaultValue(0)]
        public int ProductLine { get; set; }

        [Category("ERP Settings")]
        [DisplayName("Common Extension")]
        [Description("Extension scope. True= All companies; False=One Company")]
        [DefaultValue(true)]
        public bool CommonExtension { get; set; }
    }
}
