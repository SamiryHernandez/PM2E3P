namespace Examen.Views;
using Examen.ViewModel;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System;


public partial class PageListNotes : ContentPage
{
	public PageListNotes()
	{
		InitializeComponent();

		BindingContext = new ViewModel.ListViewModel(Navigation);
    }
}