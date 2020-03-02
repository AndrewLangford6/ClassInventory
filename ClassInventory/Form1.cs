using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects

        List<Player> inventoryOb = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 
            Player newPlayer = new Player();

            newPlayer.name = c.Text;

            newPlayer.age = ageInput.Text;

            newPlayer.team = teamInput.Text;

            newPlayer.position = positionInput.Text;
            // TODO - create object with gathered information
// TODO - add object to global list


            inventoryOb.Add(newPlayer);


            // TODO - display message to indicate addition made

            label1.Text = "New Player Added!!!";
        }

        public void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object is in list remove it
            string egg = removeInput.Text;
            int index = inventoryOb.FindIndex(n => n.name == removeInput.Text);

            if (index >= 0)
            {
                inventoryOb.RemoveAt(index);
            }



            // TODO - display message to indicate deletion made
            label1.Text = egg + " Player REMOVED!!!";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object entered exists in list show it
            Player search = inventoryOb.Find(x => x.name == textBox1.Text);
            if(search == null )
                
                {
                label1.Text = "no johns";

            }
            else
            {
                label1.Text = "\n" + "\n" + search.name + "\n" + search.age + "\n" + search.team + "\n" + search.position;
            }

            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - show all objects in list

            label1.Text = "";

            foreach(Player p in inventoryOb)
            {
                label1.Text = "\n" + "\n" + p.name + "\n" + p.age + "\n" + p.team + "\n" + p.position;
            }
            
        }
    }
}
