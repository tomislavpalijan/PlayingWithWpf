﻿using Playground.Wpf.Base;
using System;

namespace Playground.Wpf.Model
{
    public class Measurement : BaseModel
    {
        public static Measurement Instance => new Measurement(23.125, new DateTime(2020, 3, 21, 5, 33, 21), true); 


        public Measurement(double measure, DateTime measureTime, bool isValid)
        {
            MeasurementValue = measure;
            MeasureTime = measureTime;
            IsValid = isValid;
        }

        private double _measurementValue;

        public double MeasurementValue
        {
            get { return _measurementValue; }
            set
            {
                _measurementValue = value;
                OnPropertyChanged(nameof(MeasurementValue));
            }
        }

        private DateTime _measureTime;

        public DateTime MeasureTime
        {
            get { return _measureTime; }
            private set
            {
                _measureTime = value;
                OnPropertyChanged(nameof(MeasureTime));
            }
        }

        private bool _isValid;

        public bool IsValid
        {
            get { return _isValid; }
            private set
            {
                _isValid = value;
                OnPropertyChanged(nameof(IsValid));
            }
        }


    }
}
