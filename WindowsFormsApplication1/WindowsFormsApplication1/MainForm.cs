using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            positionArray[0, 0] = (int)peicePresidence.Pawn;
        }
        //6 represents empty space
        int[,] positionArray = new int[8, 8] { 
            { 1, 2, 3, 4, 5, 3, 2, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0 }, 
            { 6, 6, 6, 6, 6, 6, 6, 6 },
            { 6, 6, 6, 6, 6, 6, 6, 6 },
            { 6, 6, 6, 6, 6, 6, 6, 6 },
            { 6, 6, 6, 6, 6, 6, 6, 6 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 2, 3, 5, 4, 3, 2, 1 } };
        enum peicePresidence { Pawn, Castle, Knight, Bishop, Queen, King};
    }
}
