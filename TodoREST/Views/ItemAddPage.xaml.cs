using TodoREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoREST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemAddPage : ContentPage
    {
        bool isNewItem;
        public ItemAddPage(bool isNew = false)
        {
            InitializeComponent();
            isNewItem = isNew;
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.todoItemManager.SaveTaskAsync(todoItem, isNewItem);
            await Navigation.PopAsync();
        }
        async void OnCancelButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}