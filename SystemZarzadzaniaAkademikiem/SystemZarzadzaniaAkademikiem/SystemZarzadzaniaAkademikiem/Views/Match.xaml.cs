﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemZarzadzaniaAkademikiem.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SystemZarzadzaniaAkademikiem.Views
{
	public partial class Match : ContentPage
    {
        private MatchViewModel viewModel;

        public Match (MatchViewModel matchViewModel)
		{
			InitializeComponent ();
            BindingContext = viewModel = matchViewModel;

        }

        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}