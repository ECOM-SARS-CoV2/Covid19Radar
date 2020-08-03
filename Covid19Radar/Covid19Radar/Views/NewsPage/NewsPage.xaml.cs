﻿using System;
using Covid19Radar.Resources;
using Covid19Radar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19Radar.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsPage : ContentPage
	{
		public NewsPage()
		{
			this.InitializeComponent();
		}

		private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
		{
			NewsPageViewModel.Url     = $"{AppResources.GoogleSearchUrl}+{Uri.EscapeDataString(CovidSearchBar.Text)}";
			NewsPageViewModel.GSearch = true;
			GSearchButton.Command.Execute(null);
		}
	}
}
