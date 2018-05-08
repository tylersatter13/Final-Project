using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Key
    {
        private int KeyNumberID;
        private String KeyNumberCurrent;
        private DateTime CurrentKeyDate;
        private DateTime previousKeyDat;
        private String KeyNumberPrevious;

        public Key(int keyNumberID, string keyNumberCurrent, DateTime currentKeyDate, DateTime previousKeyDat, string keyNumberPrevious)
        {
            KeyNumberID1 = keyNumberID;
            KeyNumberCurrent1 = keyNumberCurrent;
            CurrentKeyDate1 = currentKeyDate;
            this.PreviousKeyDat = previousKeyDat;
            KeyNumberPrevious1 = keyNumberPrevious;
        }

        public int KeyNumberID1 { get => KeyNumberID; set => KeyNumberID = value; }
        public string KeyNumberCurrent1 { get => KeyNumberCurrent; set => KeyNumberCurrent = value; }
        public DateTime CurrentKeyDate1 { get => CurrentKeyDate; set => CurrentKeyDate = value; }
        public DateTime PreviousKeyDat { get => previousKeyDat; set => previousKeyDat = value; }
        public string KeyNumberPrevious1 { get => KeyNumberPrevious; set => KeyNumberPrevious = value; }
    }
}
