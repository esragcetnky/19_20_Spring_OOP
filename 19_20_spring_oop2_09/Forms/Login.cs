using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _19_20_spring_oop2_09.Forms
{
    public partial class Login : Form
    {
        internal static List<Classes.User> arrayUser = new List<Classes.User>();
        //login form'unun yapıcı fonk.
        public Login()
        {
            Height = 400;
            Width = 600;
            Text = "Login Page";
            Classes.CsvToArray.csvToarray("UserInformation","UserManagement");
            InitializeComponent();
            password.PasswordChar = '*';
            userName.Text = _19_20_spring_oop2_09.Properties.Settings.Default.UserName;
            password.Text = _19_20_spring_oop2_09.Properties.Settings.Default.Password;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            //kullanıcı isminin var olup olmadıgını kontrol etmek için kullanılan boolean 
            Boolean userNameContains = false;
            foreach (Classes.User item in arrayUser)
            {
                //kullanıcı ismi varsa if'in içine girer. boolean true olur.
                if (userName.Text == item.getName())
                {
                    userNameContains = true;
                    string hashcode = Classes.ComputeSha256Hash_.ComputeSha256Hash(password.Text);
                    //girilen text'in hashcode'u dosyadaki hashcode'a eşitse if'e girer.Login yapar.
                    if (hashcode == item.getHashCode())
                    {
                        if (rememberMe.Checked == true)
                        {
                            item.setRememberMe(true);
                            _19_20_spring_oop2_09.Properties.Settings.Default.UserName = userName.Text;
                            _19_20_spring_oop2_09.Properties.Settings.Default.Password = password.Text;
                            _19_20_spring_oop2_09.Properties.Settings.Default.Save();
                        }
                        Label succes = new Label();
                        succes.SetBounds(380, 230, 200, 60);
                        succes.Text = "Login success";
                        succes.ForeColor = Color.Green;
                        Controls.Add(succes);
                        Task.Delay(3000).Wait();
                        Controls.Remove(succes);
                        this.Hide();
                        //login oldugundan yeni form açılır.
                        string name = item.getName();
                        string l_pass = password.Text;
                        
                        if (item.getUserType() == "Admin")
                        {
                            //Eğer giren kişi admin ise AdminPage açılır.
                            Forms.AdminPage form1 = new Forms.AdminPage(name, l_pass);
                            form1.Show();
                        }
                        else
                        {
                            //Eger giren kişi normal kullanıcı ise UserPage açılır.
                            
                            Forms.UserPage form2 = new Forms.UserPage(name,l_pass);
                            form2.Show();

                        }                  
                        
                    }
                    //girilen text'in hashcode'u dosyadaki hashcode'a eşitse else'e girer.hatalı şifre yazısını yazar.
                    else
                    {
                        Label denial = new Label();
                        denial.Text = "Wrong Password";
                        denial.ForeColor = Color.Red;
                        denial.SetBounds(380, 230, 200, 60);
                        Controls.Add(denial);
                        Task.Delay(1000).Wait();
                        Controls.Remove(denial);
                    }
                }
            }
            //boolean false kalmış ise kullanıcı ismi dosyada yok demektir.kullanıcı yok yazar.
            if (userNameContains == false)
            {
                Label result = new Label();
                result.SetBounds(380, 230, 200, 60);
                result.Text = "There is no user in this user name";
                Controls.Add(result);
                Task.Delay(1000).Wait();
                Controls.Remove(result);
            }
        }
        //kayıt butonunun fonk.
        private void Register_Click(object sender, EventArgs e)
        {
            Boolean a=false;
            foreach (Classes.User item in arrayUser)
            {
                if (userName.Text == item.getName())
                {
                    a = true;
                }
            }
            if ( userName.Text == null|| password.Text==null|| password.Text==""||userName.Text=="")
            {
                MessageBox.Show("Please enter the username and password properly to register!!");
            }
            else
            {
                if (a != true)
                {
                    Classes.User yeni = new Classes.User();
                    try
                    {
                        yeni.setName(userName.Text);
                        yeni.setHashCode(Classes.ComputeSha256Hash_.ComputeSha256Hash(password.Text));
                        Login.arrayUser.Add(yeni);
                        StringWriter csv = new StringWriter();
                        //textbox'daki girdileri dosyaya yazar.
                        csv.WriteLine(string.Format("{0},{1},defname,defsurname,defemail,defphone,defadress,defsalary", yeni.getName(), yeni.getHashCode()));
                        File.AppendAllText(Classes.GetPath.getPath("UserInformation"), csv.ToString());
                        StringWriter deneme = new StringWriter();
                        if (yeni.getName() == arrayUser[0].getName())
                        {
                            string ab = "Admin";
                            yeni.setUserType(ab);
                            deneme.WriteLine(string.Format("{0},{1}", yeni.getName(), yeni.getUserType()));
                            File.AppendAllText(Classes.GetPath.getPath("UserManagement"), deneme.ToString());
                        }
                        else
                        {
                            string ac = "User";
                            yeni.setUserType(ac);
                            deneme.WriteLine(string.Format("{0},{1}", yeni.getName(), yeni.getUserType()));
                            File.AppendAllText(Classes.GetPath.getPath("UserManagement"), deneme.ToString());
                        }
                        MessageBox.Show("Register Successful");
                    }
                    catch
                    {
                        MessageBox.Show("Register Unsuccessful");
                    }
                }
                else
                {
                    MessageBox.Show("There is a user in that name!!Please choose another user name!!");
                }
            }
            
        }
        private void Login_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;


            if (MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
            {
                e.Cancel = false;
            }
        }
    }
}
