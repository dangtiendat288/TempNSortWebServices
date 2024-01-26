using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SortService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string sort(string s)
        {
            string[] numbersArray = s.Split(' ');
            float[] numbersFloat = new float[numbersArray.Length];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersFloat[i] = float.Parse(numbersArray[i]);
            }

            Array.Sort(numbersFloat);

            string sortedNumbersString = "";
            for (int i = 0; i < numbersFloat.Length; i++)
            {
                sortedNumbersString += numbersFloat[i].ToString() + ", ";
            }

            sortedNumbersString = sortedNumbersString.Substring(0, sortedNumbersString.Length - 2);
            return sortedNumbersString;
        }

        
    }
}
