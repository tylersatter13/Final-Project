using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Keys
    {
        private int KeysID;
        private String KeyNumberCurrent;
        private DateTime KeyNumberCurrentDate;
        private String KeyNumberPrevious;
        private DateTime KeyNumberPrevDate;

        public Keys(int keysID)
        {
            KeysID = keysID;
        }
        public Keys(string keyNumberCurrent, DateTime keyNumberCurrentDate,
            string keyNumberPrevious, DateTime keyNumberPrevDate)
        {
            KeyNumberCurrent = keyNumberCurrent;
            KeyNumberCurrentDate = keyNumberCurrentDate;
            KeyNumberPrevious = keyNumberPrevious;
            KeyNumberPrevDate = keyNumberPrevDate;
        }
        public Keys(Int32 keysID, String keyNumberCurrent, DateTime keyNumberCurrentDate, String keyNumberPrevious, DateTime keyNumberPrevDate):
            this(keyNumberCurrent, keyNumberCurrentDate, keyNumberPrevious, keyNumberPrevDate)
        {
            KeysID = keysID;
        }

        public int KeysID1 { get => KeysID; set => KeysID = value; }
        public string KeyNumberCurrent1 { get => KeyNumberCurrent; set => KeyNumberCurrent = value; }
        public DateTime KeyNumberCurrentDate1 { get => KeyNumberCurrentDate; set => KeyNumberCurrentDate = value; }
        public string KeyNumberPrevious1 { get => KeyNumberPrevious; set => KeyNumberPrevious = value; }
        public DateTime KeyNumberPrevDate1 { get => KeyNumberPrevDate; set => KeyNumberPrevDate = value; }
    }
}
