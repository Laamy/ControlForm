
using testform.TitleBarSDK;

namespace testform
{
    public partial class Form1 : ControlForm
    {
        public Form1()
        {
            InitializeComponent();

            TitleBar.SetMovable(this, panel1);
        }
    }
}
