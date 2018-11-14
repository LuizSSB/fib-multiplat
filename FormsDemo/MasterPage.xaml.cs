using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace FormsDemo
{
    public partial class MasterPage : ContentPage
    {
        public event EventHandler<Page> PageSelected;
        public Page SelectedPage => PageListView.SelectedItem as Page;

        public MasterPage(IEnumerable<Page> pages)
        {
            InitializeComponent();
            PageListView.ItemsSource = pages;
            PageListView.SelectedItem = pages.ElementAtOrDefault(0);
        }

        void Handle_ItemSelected(
            object sender,
            Xamarin.Forms.SelectedItemChangedEventArgs e
        )
        {
            PageSelected?
                .Invoke(this, e.SelectedItem as Page);
        }
    }
}
