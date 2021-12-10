using EntityFrameworkProject.DAL.ORM.Context;
using EntityFrameworkProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            Category category = new Category();
            product.Added_Date = DateTime.Now;
            product.Name = tbProductName.Text;
            product.UnitPrice = decimal.Parse(tbPrice.Text);
            product.UnitsinStock = short.Parse(tbStocks.Text);
            product.Quantity = tbQuantity.Text;
            product.isActive = true;
            category.Description = tbDescription.Text;

            ProjectContext db = new ProjectContext();
            db.Products.Add(product);
            db.Categories.Add(category);
            db.SaveChanges();

            MessageBox.Show("Your data entry was successful","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
    }
}
