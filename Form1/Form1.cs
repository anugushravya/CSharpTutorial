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

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string typeName = txtTypeName.Text;
            Type t = Type.GetType(typeName);
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();
            MethodInfo[] methods = t.GetMethods();
            foreach(MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }

            PropertyInfo[] properties = t.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }

            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.ToString());
            }


        }


        private void listMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}


//Late Binding:  do not show any errors in compile time but show in runtime: mostly late binding will use when objects are not available at compile time.
//public class Program

//{

//    public static void Main()
//    {

//        Assembly executingAssembly = Assembly.GetExecutingAssembly();
//        Type customerType = executingAssembly.GetType("CSharpTutorial.Customer");
//        object customerInstance = Activator.CreateInstance(customerType);
//        MethodInfo method = customerType.GetMethod("GetFullName");

//        string[] parameters = new string[2];
//        parameters[0] = "Sunil";
//        parameters[1] = "Gaddam";
//        string fullName = (string)method.Invoke(customerInstance, parameters);
//        Console.WriteLine("Full Name = {0}", fullName);
//        Console.ReadLine();


//    }


//}

//public class Customer
//{
//    public string GetFullName(string fn, string ln)
//    {
//        return fn + " " + ln;
//    }
//}





//    }


//Equals- Equals override method. if you oveeride equlas method you should also oveeride gethashcode method to get same code for both objects(equals).
//public class Program

//{

//    public static void Main()

//    {

//        Customer c1 = new Customer();
//        c1.Firstname = "Shravya";
//        c1.Lastname = "Anugu";

//        Customer c2 = new Customer();
//        c2.Firstname = "Shravya";
//        c2.Lastname = "Anugu";

//        Console.WriteLine(c1.Equals(c2));
//        Console.ReadLine();



//    }

//}

//public class Customer
//{
//    public string Firstname { get; set; }
//    public string Lastname { get; set; }

//    public override bool Equals(object obj)
//    {
//        if (obj == null)
//        {
//            return false;
//        }

//        if (!(obj is Customer))
//        {
//            return false;
//        }

//        return this.Firstname == ((Customer)obj).Firstname &&
//            this.Lastname == ((Customer)obj).Lastname;

//    }

//    public override int GetHashCode()
//    {
//        return this.Firstname.GetHashCode() ^ this.Lastname.GetHashCode();
//    }


//}


