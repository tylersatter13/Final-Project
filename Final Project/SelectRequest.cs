using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class SelectRequest
    {
        String tableName;
        public List<String> chosenColumns;
        public List<String> chosenTables;
        public List<String> filterCritera;
        public StringBuilder tableJoin;
       
    
    }
}
