using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque
{
    class Util
    {
        public Util()
        {

        }

        public void Slider(System.Windows.Forms.Control pn, int height, int width)
        {
            pn.Height = height;
            pn.Width = width;
        }

        public void Slider(System.Windows.Forms.Control pn, System.Windows.Forms.GroupBox gb, System.Windows.Forms.Button btn, int height, int width)
        {
            if (gb.Height == 28)
            {
                Slider(gb, height, width);
                Slider(pn, height, width);
                btn.Image = prjEstoque.Properties.Resources.icons8_triangle_arrow_14;
            }
            else
            {
                Slider(gb, 28, width);
                Slider(pn, 65, width);
                btn.Image = prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            }
        }
    }
}
