using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianroulette
{
    class Class1
    {
       public void load_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\useR\source\repos\russianroulette\Gun+Reload.wav");
            player.Play();
        }
       public void spin_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\useR\source\repos\russianroulette\spin.wav");
            player.Play();
        }
       public void shot_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\useR\source\repos\russianroulette\gun-gunshot-01.wav");
            player.Play();
        }
       public void PointAway_sound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\useR\source\repos\russianroulette\gun-gunshot-01.wav");
            player.Play();
        }

    }

}

  
