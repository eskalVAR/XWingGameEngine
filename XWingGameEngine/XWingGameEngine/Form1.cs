using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWingGameEngine
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
    }
    static class Upgrades
    {
        public enum Elite
        {
        }
        public enum Astromech
        {
        }
        public enum Torpedoes
        {
        }
        public enum Missiles
        {
        }
        public enum Cannon
        {
        }
        public enum Turret
        {
        }
        public enum Bomb
        {
        }
        public enum Crew
        {
        }
        public enum Salvaged_Astromechs
        {
        }
        public enum System
        {
        }
        public enum Title
        {
        }
        public enum Modification
        {
        }
        public enum Illicit
        {
        }
        public enum Cargo
        {
        }
        public enum Hardpoint
        {
        }
        public enum Team
        {      
        }
        public enum Tech
        {
        }
    }
    static class Ship_Util
    {
        public enum Rebel
        {

        }
        public enum Imperial
        {

        }
        public enum Scum
        {

        }
    }
    abstract class ShipMove
    {
        public abstract void Move();
    }
    class Ship
    {
        ShipMove _shipmove;
        public string name;
        
        Ship(string name)
        {
            this.name = name;

        }

    }
}
