using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomizedControl
{
    public partial class CusPicBox : PictureBox
    {
        public event EventHandler ImageChanged;
        public CusPicBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public virtual new Image Image
        {
            get
            {
                return base.Image;
            }
            set
            {
                base.Image = value;
                if (this.ImageChanged != null)
                    this.ImageChanged(this, new EventArgs());
            }
        }
    }
}
