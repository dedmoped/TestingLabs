using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public bool CheckIsPossibleToCreate(int A_Side, int B_Side, int C_Side)
        {


            return (A_Side >= 0 && B_Side >= 0 && C_Side >= 0 && (A_Side + B_Side > C_Side && B_Side + C_Side > A_Side && A_Side + C_Side > B_Side));

        }
    }
}
