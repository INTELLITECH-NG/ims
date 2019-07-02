using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    class Connectionstring
    {
       // public string DBcon = @"Data Source=.\Sqlexpress;Initial Catalog=CRM_DB;Integrated Security=True";
         public string DBcon= "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\CRM_DB.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
