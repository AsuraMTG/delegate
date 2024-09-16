using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate int MyDelegate(int x, int y); //DELEGATE01

        public MyDelegate del = new MyDelegate(osszeg);


        public static int osszeg(int x, int y)
        {
            return x + y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eredmeny = del(6, 9);

            Func<int, int> név = szám => (szám * 5) - 2;

            int a = név(5);

            string[] words = { "papa", "mama", "gyerekek" };

            int minh = words.Min(vevé => vevé.Length);

            int[] szamok = { 17, 21, 33, 45, 55, 69 };
            int x = 3;
            IEnumerable<int> lek = 
                from num in szamok 
                where num % x == 0
                orderby num
                select num;

            label1.Text = lek.ToString();
        }
    }
}
