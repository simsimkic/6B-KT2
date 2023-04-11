﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS_Booking.Serializer;
using SIMS_Booking.Utility;

namespace SIMS_Booking.Model
{



    public class TourPoint : ISerializable, IDable, INotifyPropertyChanged
    {
        private int Id;

        public string Name { get; set; }
       

        private bool checkedCheckBox;
        public bool CheckedCheckBox
        {
            get { return checkedCheckBox; }
            set
            {
                if (checkedCheckBox != value)
                {
                    checkedCheckBox = value;
                    OnPropertyChanged(nameof(CheckedCheckBox));
                }
            }
        }



        public TourPoint() { }
        public TourPoint( string name, bool @checked)
        {
            
            Name = name;
            CheckedCheckBox = @checked;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public void FromCSV(string[] values)
        {
            Id = int.Parse(values[0]);
            Name = values[1];
            CheckedCheckBox = bool.Parse(values[2]);
        }

        public int getID()
        {
            return Id;
        }

        public void setID(int id)
        {
            Id = id;
        }

        public string[] ToCSV()
        {
            string[] csvValues = { Id.ToString(), Name, CheckedCheckBox.ToString() };
            return csvValues;
        }
    }
}
