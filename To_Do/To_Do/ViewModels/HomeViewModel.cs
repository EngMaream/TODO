using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using To_Do.Models;
using Xamarin.Forms;

namespace To_Do.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {

        private string text;
        private ObservableCollection<ToDoItem> items;
        private TimeSpan dataTime;

        public HomeViewModel(INavigation navigation) : base(navigation)
        {
            AddItemCommand = new Command(AddItem);
            Items = new ObservableCollection<ToDoItem>();
            Title = "Home";
        }

        public ObservableCollection<ToDoItem> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        
        public TimeSpan DataTime
        {
            get => dataTime;
            set => SetProperty(ref dataTime, value);
        }

        private void AddItem()
        {
            if (string.IsNullOrEmpty(Text))
                return;
            Items.Add(new ToDoItem { Text = Text, TextDataTime=DataTime.ToString(),
                                     IsDone = false, Id = Items.Count });
            Text = "";
            DataTime = TimeSpan.Zero;
        }

        public ICommand AddItemCommand { get; }

    }
   
}
