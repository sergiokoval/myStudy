using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myStudy.WinForms.DecoratorPatternTest
{
    public class myPhoto: Form
    {
        Image _image = null;

        public myPhoto()
        {
            _image = new Bitmap("c:\\WP_20150124_017.jpg");
            ((Bitmap)_image).SetResolution(1000, 1000);
            this.Paint += Draw;
            
            
        }

        public virtual void Draw(object sender, PaintEventArgs e)
        {          
            e.Graphics.DrawImage(_image,new Point(0,0));
        }

        public Size GetImageSize()
        {
            return _image.Size;   
        }
    }
}
