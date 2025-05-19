using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    internal class FormMethods
    {
        private Form1 _Form;
        private Graphics _FormGraphics;

        public FormMethods(Form1 form, Graphics formgraphics)
        {
            _Form = form;
            _FormGraphics = formgraphics;
        }

        public Form1 Form { get => _Form; set => _Form = value; }
        public Graphics FormGraphics { get => _FormGraphics; set => _FormGraphics = value; }

        public void SetupBaseForm()
        {

            //Setting Up ALl Variables

            //Sizes
            int PositionX;
            int PositionY;
            int CoordinateSize = Form.Height / 12;
            int ExtraVerticalSpace = Form.Width - (CoordinateSize * 20);
            int ExtraHorizontalSpace = Form.Height - (CoordinateSize * 10);
            int BottomBarHeight = Convert.ToInt32(ExtraHorizontalSpace * 0.60);
            int TopBarHeight = ExtraHorizontalSpace - BottomBarHeight;
            int LeftBarWidth = Convert.ToInt32(ExtraVerticalSpace * 0.1);

            //Colours
            SolidBrush CoordinateColour = new SolidBrush(Color.FromArgb(81, 164, 219));

            //Background
            SolidBrush Colour = new SolidBrush(Color.FromArgb(26,26,26));
            Rectangle Background = new Rectangle(0,0,Form.Width, Form.Height);
            FormGraphics.FillRectangle(Colour, Background);
            //Adding Buttons/Coordinates
            for (int ColumnCount = 0; ColumnCount < 10; ColumnCount++)
            {
                PositionY = TopBarHeight + (CoordinateSize * ColumnCount);
                PositionX = LeftBarWidth;
                for (int RowCount = 0; RowCount < 10; RowCount++)
                {
                    Rectangle CoordinateSquare = new Rectangle(PositionX, PositionY, CoordinateSize, CoordinateSize);
                    FormGraphics.FillRectangle(CoordinateColour, CoordinateSquare);
                    PositionX += CoordinateSize;
                }
            }
        }
        public void ResizeForm()
        {

        }

        public void SetupBaseFormVariables()
        {

        }
    }
}
