using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Calc.Calc
{
    public interface ICalc // интерфейс, в котором один метод
    {
        double DoMath(double tmp1, double tmp2);
    }
}
