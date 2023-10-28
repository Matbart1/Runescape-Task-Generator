using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runescape_Task_Generator
{
    public partial class RSGenerator : Form
    {
        public RSGenerator()
        {
            InitializeComponent();
        }
    }

    public class MonsterInfo
    {

    }

    public class MonsterInfoArray
    {
        public MonsterInfo[] fullInfo { get; set; }
    }
}
