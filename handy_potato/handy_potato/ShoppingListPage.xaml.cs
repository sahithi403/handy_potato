﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace handy_potato
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShoppingListPage : RootPageDetail
    {
		public ShoppingListPage ()
		{
			InitializeComponent ();
		}
	}
}