using Playground.Wpf.Base;
using System.Collections.ObjectModel;
using System;

namespace Playground.Wpf.Model
{

    public class ItemCharacteristic : BaseModel
    {
        public static ItemCharacteristic Instance => new ItemCharacteristic() {
            Name ="Weight",
            CurrentValue = 23.4342,
            UpperLimit = 23.998,
            LowerLimit = 23.432,
            IsCurrentValueValid = true,
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
        };

        public ItemCharacteristic()
        {
            Measurements = new ObservableCollection<Measurement>();
        }

        public ObservableCollection<Measurement> Measurements { get; set; }

        private string _unit;
        /// <summary>
        /// Gets or sets the unit of <see cref="ItemCharacteristic"/>
        /// </summary>
        public string Unit  
        {
            get { return _unit; }
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }


        private string _name;
        /// <summary>
        /// Gets or sets the name of <see cref="ItemCharacteristic"/>
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(Name);
            }
        }

        private double _currentValue;

        /// <summary>
        /// Gets or sets the current value of <see cref="ItemCharacteristic"/>
        /// </summary>
        public double CurrentValue
        {
            get { return _currentValue; }
            set
            {
                _currentValue = value;
                OnPropertyChanged(nameof(CurrentValue));
            }
        }

        private double _upperLimit;
        /// <summary>
        /// Gets or sets the upper limit of <see cref="ItemCharacteristic"/>
        /// </summary>
        public double UpperLimit
        {
            get { return _upperLimit; }
            set
            {
                _upperLimit = value;
                OnPropertyChanged(nameof(UpperLimit));
            }
        }


        private double _lowerLimit;
        /// <summary>
        /// Gets or sets the lower limit of <see cref="ItemCharacteristic"/>
        /// </summary>
        public double LowerLimit
        {
            get { return _lowerLimit; }
            set
            {
                _lowerLimit = value;
                OnPropertyChanged(nameof(LowerLimit));
            }
        }

        private bool _isCurrentValueValid;
        /// <summary>
        /// Gets is the current value of <see cref="ItemCharacteristic"/> valid
        /// </summary>
        public bool IsCurrentValueValid
        {
            get { return _isCurrentValueValid; }
            private set
            {
                _isCurrentValueValid = value;
                OnPropertyChanged(nameof(IsCurrentValueValid));
            }
        }


        private void SetIsCurrentValueValid()
        {
            IsCurrentValueValid = LowerLimit <= CurrentValue && CurrentValue <= UpperLimit;
        }
    }
}
