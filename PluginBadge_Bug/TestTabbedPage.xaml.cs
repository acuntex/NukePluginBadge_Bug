﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PluginBadge_Bug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestTabbedPage : TabbedPage
    {
        public TestTabbedPage()
        {
            InitializeComponent();
        }
    }
}
