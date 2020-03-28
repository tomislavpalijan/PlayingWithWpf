using Playground.Wpf.Base;
using Playground.Wpf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Wpf
{
    public class ShellWindowViewModel : BaseViewModel
    {
        public static ShellWindowViewModel Instance = new ShellWindowViewModel();

        public readonly ObservableCollection<ItemCharacteristic> ItemAttributes;

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public ShellWindowViewModel()
        {
            Title = nameof(ShellWindowViewModel);
            ItemAttributes = new ObservableCollection<ItemCharacteristic>();

            SetUpItemAttributes();
        }

        private void SetUpItemAttributes()
        {
            ItemAttributes.Add( new ItemCharacteristic()
            {
                Name = "Length",
                CurrentValue = 1.23,
                LowerLimit = 1.0 ,
                UpperLimit =1.5}
            );
            ItemAttributes.Add(new ItemCharacteristic()
            {
                Name = "Width",
                CurrentValue = 12.33,
                LowerLimit = 12.0,
                UpperLimit = 12.5
            });
            ItemAttributes.Add(new ItemCharacteristic()
            {
                Name = "Height",
                CurrentValue = 13.53,
                LowerLimit = 13.0,
                UpperLimit = 13.5
            });
            ItemAttributes.Add(new ItemCharacteristic()
            {
                Name = "Thickness",
                CurrentValue = 16.93,
                LowerLimit = 16.0,
                UpperLimit = 18.5
            });
        }
    }
}
