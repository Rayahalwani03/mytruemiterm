using System.Reflection;
using System.Xml.Linq;

namespace mytruemiterm
{
    public partial class MainPage : ContentPage
    {
  
        List<ChildClass> child = new List<ChildClass>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void ADD_Clicked(object sender, EventArgs e)
        {

 

        }

        private void SHOW_Clicked(object sender, EventArgs e)
        {


            string gender = MaleBtn.IsChecked ? MaleBtn.Content.ToString() : FemaleBtn.Content.ToString();

            child.Add(new ChildClass(
                nname.Text,
                lastname.Text,
                Day.Text,
                Month.Text,
                Year.Text,
                gender
            ));

            Child_List_View.ItemsSource = null;
            Child_List_View.ItemsSource = child;
        }


    }

}
