using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewCSharp
{   
    /// <summary>
    /// Class containing the Data for the Application
    /// </summary>
    public class Data
    {
        public static Int32 idTask = 0;
        public static List<Task> listTask = new List<Task>();
        public static List<String> listDev = new List<String> { "Dev1", "Dev2", "Dev3" };
        public enum enumStatus {
            Ouvert = 0,
            Fermé,
            Annulé
        };
    }
}
