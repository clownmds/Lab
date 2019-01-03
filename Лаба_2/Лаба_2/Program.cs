using System.Windows.Forms;
using MyIndustry.Model;
using MyIndustry.MVVM;

namespace MyIndustry
{
    class Program
    {
        static void Main(string[] args)
        {
            var industry =new Industry("Завод") ;
            industry.AddItemMetalWorking(10000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IndustryMainForm(new MainFormViewModel(industry)));
        }
    }
}
