using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Serialization;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AMA1_Serilazation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialization_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Department = txtDepatment.Text,
                    DoB = dtp1.Value,
                    Salary = Convert.ToInt32(txtSalary.Text),
                };

                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);

                using (fsout)
                {
                    xs.Serialize(fsout, emp);
                    MessageBox.Show("Serileþtirme gerçekleþti");
                    txtDepatment.Text = "";
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtSalary.Text = "";

                }
            }
            catch
            {
                MessageBox.Show("Serileþtirme gerçekleþmedi");
            }

        }

        private void btnDeserialization_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);

                using (fsin)
                {
                    emp = (Employee)xs.Deserialize(fsin);
                    txtDepatment.Text = emp.Department;
                    txtName.Text = emp.Name;
                    txtPhone.Text = emp.Phone;
                    txtSalary.Text = Convert.ToString(emp.Salary);
                    MessageBox.Show("Deserialize iþlemi gerçekleþti");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Deserialize iþlemi gerçekleþmedi: " + ex.Message.ToString());

            }

        }

        private void btnJsonCreat_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.ProductName = txtProductName.Text;
                product.Description = txtDescription.Text;
                product.Price = Convert.ToDouble(txtPrice.Text);
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(@"C:\Users\remzi\source\repos\AMA1_Serilazation\AMA1_Serilazation\bin\Debug\net9.0-windows\product.json"))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    serializer.Serialize(jw, product);
                    txtDescription.Text = "";
                    txtProductName.Text = "";
                    txtPrice.Text = "";

                    MessageBox.Show("Serileþtirme baþarýlý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var: " + ex.Message.ToString());
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                JsonSerializer serializer = new JsonSerializer();
                
                using (StreamReader sr = new StreamReader(@"C:\Users\remzi\source\repos\AMA1_Serilazation\AMA1_Serilazation\bin\Debug\net9.0-windows\product.json")) 
                {
                    string json = sr.ReadToEnd();
                    product = JsonConvert.DeserializeObject<Product>(json);

                    

                    txtDescription.Text = product.Description;
                    txtProductName.Text = product.ProductName;
                    txtPrice.Text = Convert.ToString(product.Price);

                    MessageBox.Show("Deserialize baþarýlý");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var: " + ex.Message.ToString());
            }
        }
    }
}
