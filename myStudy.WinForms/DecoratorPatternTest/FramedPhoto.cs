using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myStudy.WinForms.DecoratorPatternTest
{
    public class FramedPhoto: myPhoto
    {
        myPhoto _photo;

        public FramedPhoto(myPhoto myPhoto)
        {
            _photo = myPhoto;
        }

        public  FramedPhoto()
        {

        }

        public override void Draw(object sender, PaintEventArgs e)
        {
            //_photo.Draw(sender, e);
            base.Draw(sender, e);
            e.Graphics.DrawRectangle(System.Drawing.Pens.Black, 0, 0, 
                this.GetImageSize().Width/10, 
                this.GetImageSize().Height/10);
        }
    }
}
