using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HXApiTesterCS
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //int check = HXApiCS.HXApi.HXInitialize(0, 192, 168, 226, 133, 3000);
            //Console.WriteLine("Connect : " + check);


            //bool bval = HXApiCS.HXApi.HXGetBit(HXApiCS.HXMap.HX_X, 7, 0);
            //Console.WriteLine(bval);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Base_Form());
        }
    }
}
