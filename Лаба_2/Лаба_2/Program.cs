using System.Windows.Forms;
using MyIndustry.Model;
using System.IO;

namespace MyIndustry
{
    class Program
    {
        static void Main(string[] args)
        {
            var _industry =new Industry("Завод") ;
            _industry.AddItemMetalWorking(10000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormIndystry(new MainFormViewModelIndustry(_industry)));
        }
    }
}
