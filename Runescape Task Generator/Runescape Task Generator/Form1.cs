using Runescape_Task_Generator.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Resources;
using System.Windows.Forms;

namespace Runescape_Task_Generator
{
    public partial class RSGenerator : Form
    {
        BindingSource bs = new BindingSource();
        List<Task> tasks = new List<Task>();

        public RSGenerator()
        {
            InitializeComponent();

            PopulateTasks();

            btnHint.Click += BtnHint_Click;

        }

        private void BtnHint_Click(object sender, EventArgs e)
        {
            
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void PopulateTasks()
        {
            Task barrows = new Task("Barrows", 0, "Eastern Mort'ton", "2 hours", "Graceful, Iban's Staff or Better, Ghommal's Hilt 2 or Prayer Potions, Food, Teleports", "Remember to bring a spade and have an emergency teleport out!", 2, false);
            tasks.Add(barrows);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);
            Task t = new Task("", 0, "", "", "", "", 0, false);
            tasks.Add(t);

        }
    }

    // List of Task, each Task will be given "Monster/Skill, Location(s), Time, Gear 
    public class Task
    {
        public string name;
        public int slayerLvl;
        public string Clocation;
        public string time;
        public string gear;
        public string taskHint;
        public int diffSetting;
        public bool skill;

        public Task(string monsterOrSkill, int slayerLevel, string location, string timeLimit, string gearSetup, string hint, int difficulty, bool skilling)
        {
            name = monsterOrSkill;
            slayerLvl = slayerLevel;
            Clocation = location;
            time = timeLimit;
            gear = gearSetup;
            taskHint = hint;
            diffSetting = difficulty;
            skill = skilling;
        }
    }
}
