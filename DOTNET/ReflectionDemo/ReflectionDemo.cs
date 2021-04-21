using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

namespace ReflectionDemo
{
    public partial class ReflectionDemo : Form
    {
        public ReflectionDemo()
        {
            InitializeComponent();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            //clear the list-boxes
            listProperties.Items.Clear();
            listMethods.Items.Clear();
            listConstructors.Items.Clear();

            //string TypeName = SearchKeyTxt.Text;

            //get the type of the entered search text
            //Type T = Type.GetType(AllNamespacesComboBox.SelectedItem.ToString());

            Type T = Type.GetType(txtSearchKey.Text);

            ConstructorInfo[] constructorInfos =T.GetConstructors();
            MethodInfo[] methodInfos = T.GetMethods();
            PropertyInfo[] propertyInfos = T.GetProperties();

            foreach (MethodInfo methodInfo in methodInfos)
            {
                listProperties.Items.Add(methodInfo.ReturnType + " "+methodInfo.Name);
            }
            
            foreach(PropertyInfo propertyInfo in propertyInfos)
            {
                listMethods.Items.Add(propertyInfo.PropertyType.Name +" "+propertyInfo.Name);
            }
            foreach(ConstructorInfo constructorInfo in constructorInfos)
            {
                listConstructors.Items.Add(constructorInfo.ToString());
            }

        }
    }
}
