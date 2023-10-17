using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZhdanovaAA.Sprint2.TaskReview.V5.Lib
{
    public class DataService
    {
        public bool CheckDot(double x, double y)
        {
            bool res;
            if (((y <= Math.Pow(Math.E,x)) && (y <= (Math.Pow(Math.E, -x)))) && (y >= Math.Pow(x,2)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}  
