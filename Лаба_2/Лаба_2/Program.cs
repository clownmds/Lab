using System.Windows.Forms;

namespace MyIndustry
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var _industry = new Model.Industry("Завод");
            _industry.AddItemMetalWorking( 20000);
            Application.Run(new MainFormIndystry(new MainFormViewModelIndustry(_industry)));            
        }
    }
}
