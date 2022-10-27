using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class Picture : Form
    {
        private byte[] array;
        public Picture(byte[] array)
        {
            InitializeComponent();
            this.array = array;
        }

        private void Picture_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromStream(new MemoryStream(array));
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
