using System;
using Playground.Wpf.Base;
using Playground.Wpf.Model;
using System.Collections.ObjectModel;

namespace Playground.Wpf
{
    public class ShellWindowViewModel : BaseViewModel
    {
        public static ShellWindowViewModel Instance = new ShellWindowViewModel()
        {
            ItemCharacteristics = new ObservableCollection<ItemCharacteristic>()
            {
                new ItemCharacteristic()
                {
                    Name = "Length",
                    LowerLimit = 1.0,
                    UpperLimit = 1.5,
                    Unit = "mm",
                    CurrentValue = 1.2334,
                    Measurements = new ObservableCollection<Measurement>()
                    {
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (2.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (3.4342, new DateTime(2020, 3, 27, 2, 13, 55), true),
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (45.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (5.4342, new DateTime(2020, 3, 27, 2, 13, 55), true)
                    }
                },

                new ItemCharacteristic()
                {
                    Name = "Width",
                    CurrentValue = 12.3321,
                    LowerLimit = 12.0,
                    UpperLimit = 12.5,
                    Unit = "mm",
                    Measurements = new ObservableCollection<Measurement>()
                    {
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (2.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (3.4342, new DateTime(2020, 3, 27, 2, 13, 55), true),
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (45.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (5.4342, new DateTime(2020, 3, 27, 2, 13, 55), true)
                    }
                },
                new ItemCharacteristic()
                {
                    Name = "Height",
                    CurrentValue = 13.5321,
                    LowerLimit = 13.0,
                    UpperLimit = 13.5,
                    Unit = "mm",
                    Measurements = new ObservableCollection<Measurement>()
                    {
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (2.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (3.4342, new DateTime(2020, 3, 27, 2, 13, 55), true),
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (45.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (5.4342, new DateTime(2020, 3, 27, 2, 13, 55), true)
                    }
                },
                new ItemCharacteristic()
                {
                    Name = "Thickness",
                    CurrentValue = 16.9332,
                    LowerLimit = 16.0,
                    UpperLimit = 18.5,
                    Unit = "mm",
                    Measurements = new ObservableCollection<Measurement>()
                    {
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (2.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (3.4342, new DateTime(2020, 3, 27, 2, 13, 55), true),
                        new Measurement (23.4342, new DateTime(2020, 3, 27, 12, 43, 55), true),
                        new Measurement (45.4342, new DateTime(2020, 3, 27, 1, 43, 55), false),
                        new Measurement (5.4342, new DateTime(2020, 3, 27, 2, 13, 55), true)
                    }
                }
            }
        };

        public ObservableCollection<ItemCharacteristic> ItemCharacteristics { get; set; }

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
            
        }

        private void SetUpItemAttributes()
        {
            ItemCharacteristics.Add( new ItemCharacteristic()
            {
                Name = "Length",
                CurrentValue = 1.23,
                LowerLimit = 1.0 ,
                UpperLimit =1.5}
            );
            ItemCharacteristics.Add(new ItemCharacteristic()
            {
                Name = "Width",
                CurrentValue = 12.33,
                LowerLimit = 12.0,
                UpperLimit = 12.5
            });
            ItemCharacteristics.Add(new ItemCharacteristic()
            {
                Name = "Height",
                CurrentValue = 13.53,
                LowerLimit = 13.0,
                UpperLimit = 13.5
            });
            ItemCharacteristics.Add(new ItemCharacteristic()
            {
                Name = "Thickness",
                CurrentValue = 16.93,
                LowerLimit = 16.0,
                UpperLimit = 18.5
            });
        }
    }
}
