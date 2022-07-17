using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AnimalInheritance
{
    class Animal
    {
        //instance variables
        protected String name;
        protected SoundPlayer p1;
        //get method
        public virtual void SetName()
        {
            this.name = "Animal";
        }
        public virtual String GetName()
        {
            return name;
        }
        public virtual void PlaySound()
        {
            p1 = new SoundPlayer(@"D:\Rohit 1225\AnimalInheritance\AnimalInheritance\Sounds\baboon_monkey.wav");
            p1.Play();
        }
    }
    class Cat : Animal
    {
        public override void SetName()
        {
            name = "Cat";
        }
        public override void PlaySound()
        {
            p1 = new SoundPlayer(@"D:\Rohit 1225\AnimalInheritance\AnimalInheritance\Sounds\cat_y.wav");
        }
    }
    class Dog : Animal
    {
        public override void SetName()
        {
            name = "Dog";
        }
        public override void PlaySound()
        {
            p1 = new SoundPlayer(@"D:\Rohit 1225\AnimalInheritance\AnimalInheritance\Sounds\dog_y4.wav");
        }
    }
    class Cow : Animal
    {
        public override void SetName()
        {
            name = "Cow";
        }
        public override void PlaySound()
        {
            p1 = new SoundPlayer(@"D:\Rohit 1225\AnimalInheritance\AnimalInheritance\Sounds\cow3_y.wav");
        }
    }
}
