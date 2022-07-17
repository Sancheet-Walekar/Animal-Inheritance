using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalInheritance
{
    public partial class Form1 : Form
    {
        Animal[] animals;
        public Form1()
        {
            //instantiate of array
            InitializeComponent();
            animals = new Animal[4];
            //assign object
            animals[0] = new Animal();
            animals[1] = new Cat();
            animals[2] = new Dog();
            animals[3] = new Cow();
            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].SetName();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                cmvAnimal.Items.Add(animals[i].GetName());
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            animals[cmvAnimal.SelectedIndex].PlaySound();
        }
    }
}
