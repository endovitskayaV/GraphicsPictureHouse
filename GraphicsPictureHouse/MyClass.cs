using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsPictureHouse
{
   public  class MyClass
    {
        public static void Draw(Graphics gBitmap)
        {

            Color cl = Color.FromArgb(255, 255, 255);
            gBitmap.Clear(cl);

            gBitmap.SmoothingMode = SmoothingMode.AntiAlias;
            
            int x = 660 / 2 - 80;//250
            int y = 600 / 2;

            //дым

            Pen pen = new Pen(Color.FromArgb(209, 207, 205), 5);


            Point[] p = {new Point() {X=384,Y=136},
                          new Point() {X=371,Y=115},
                          new Point() {X=379,Y=100},
                          new Point() {X=407,Y=92},
                         new Point() {X=416,Y=69}};
           

            gBitmap.DrawCurve(pen, p, 3);
         

            //труба
            //тень

            Color сolorShadow = Color.FromArgb(205, 170, 125);
             pen = new Pen(сolorShadow, 5);
            Rectangle rec = new Rectangle(x + 115, y- 150, 43, 90);
            gBitmap.DrawRectangle(pen, rec);

            //основа тpубы
            сolorShadow = Color.FromArgb(222, 184, 135);
            Color сolorLight = Color.FromArgb(238, 197, 145);
            LinearGradientBrush gradientbrush = new LinearGradientBrush(new Point(x + 115, y- 150), new Point(x +158, y -60), сolorLight, сolorShadow);
            gBitmap.FillRectangle(gradientbrush, rec);

            //верх трубы
            Color сolorFrame = Color.FromArgb(139, 115, 85);
            rec = new Rectangle(x + 110, y -165, 55, 18);
            gradientbrush = new LinearGradientBrush(new Point(x + 110, y-165), new Point(x + 165, y -132), Color.FromArgb(224, 224, 224), сolorFrame);
             gBitmap.FillRectangle(gradientbrush, rec);
           SolidBrush  brush = new SolidBrush(сolorFrame);
            gBitmap.FillRectangle(gradientbrush, rec);

            //тень крыши
            Point[] triangle ={new Point() {X=x-10,Y=y+5},
                         new Point() {X=x+83,Y=y-145},
                         new Point() {X=x+180,Y=y+5},
                        };

            pen = new Pen(сolorFrame, 12);
            gBitmap.DrawPolygon(pen, triangle);



            //основа дома
            //рамка основы
            Rectangle rect = new Rectangle(x, y, 170, 170);
            pen = new Pen(сolorFrame, 5);
            gBitmap.DrawRectangle(pen, rect);

            //тень основы
            rect = new Rectangle(x + 2, y - 2, 167, 170);
            brush = new SolidBrush(сolorShadow);
            gBitmap.FillRectangle(brush, rect);

            //центральная светлая часть основы
            rect = new Rectangle(x + 22, y - 2, 130, 170);
            brush = new SolidBrush(сolorLight);
            gBitmap.FillRectangle(brush, rect);

            //крыша
            //тень

            Point[] triangle1 ={new Point() {X=x,Y=y},
                         new Point() {X=x+83,Y=y-141},
                         new Point() {X=x+170,Y=y},
                        };
            brush = new SolidBrush(сolorShadow);
            gBitmap.FillPolygon(brush, triangle1);

            //центральная светлая часть крыши
            Point[] triangle2 ={new Point() {X=x+22,Y=y},
                         new Point() {X=x+83,Y=y-120},
                         new Point() {X=x+151,Y=y},
                        };
            Color сolorLight2 = Color.FromArgb(128, сolorLight);
            brush = new SolidBrush(сolorLight2);

            gBitmap.FillPolygon(brush, triangle2);

            // красная обводка крыши

            //левая линия
            Color сolorFrameUp = Color.FromArgb(139, 35, 35);
            pen = new Pen(сolorFrameUp, 15);
            gBitmap.DrawLine(pen, new Point(x - 27, y + 7), new Point(x+86, y-174));

            //правая линия
            gradientbrush = new LinearGradientBrush(new Point(x+81, y -174), new Point(x + 196, y + 6), сolorFrameUp, Color.FromArgb(255, 64, 64));
            pen = new Pen(gradientbrush, 15);
            gBitmap.DrawLine(pen, new Point(x +80, y-174), new Point(x +196, y + 6));
            
            //дверь
            //обводка
            rect = new Rectangle(x +56, y+14, 60, 153);
            pen = new Pen(сolorFrame, 5);
            gBitmap.DrawRectangle(pen, rect);

            //центральная светловатая часть
            rect = new Rectangle(x +58, y + 16, 57, 150);
            TextureBrush textureBrush = new TextureBrush(new Bitmap("tree.bmp"));
            gBitmap.FillRectangle(textureBrush, rect);

            // ручка
            //контур
            rect = new Rectangle(x +104, y +87, 7, 7);
            pen = new Pen(Color.FromArgb(139, 69, 19));
            gBitmap.DrawEllipse(pen, rect);

            //заливка ручки
            brush = new SolidBrush(Color.FromArgb(139, 69, 19));
            gBitmap.FillEllipse(brush, rect);

            //окно
            //рама
            rect = new Rectangle(x +62, y-70, 46, 46);
            textureBrush = new TextureBrush(new Bitmap("tree.bmp"));
            gBitmap.FillRectangle(textureBrush, rect);

            //стекла
            сolorShadow = Color.FromArgb(58, 95, 205);
            сolorLight = Color.FromArgb(202, 225, 255);
            rect = new Rectangle(x+66, y -66, 16 ,16);
            gradientbrush = new LinearGradientBrush(new Point(x +66, y - 66), new Point(x +82, y -50), сolorShadow, сolorLight);
            gBitmap.FillRectangle(gradientbrush, rect);

            rect = new Rectangle(x +88, y -66, 16, 16);
            gradientbrush = new LinearGradientBrush(new Point(x+88, y - 66), new Point(x +104, y -50), сolorShadow, сolorLight);
            gBitmap.FillRectangle(gradientbrush, rect);

            rect = new Rectangle(x +88, y -44, 16, 16);
            gradientbrush = new LinearGradientBrush(new Point(x +88, y -44), new Point(x + 104, y -28), сolorShadow, сolorLight);
            gBitmap.FillRectangle(gradientbrush, rect);

            rect = new Rectangle(x+66, y -44, 16, 16);
            gradientbrush = new LinearGradientBrush(new Point(x +66, y-44), new Point(x +82, y-28), сolorShadow, сolorLight);
            gBitmap.FillRectangle(gradientbrush, rect);

            //text
             
           Font myFont = new Font("Times New Roman", 18, FontStyle.Bold | FontStyle.Underline);
            rect = new Rectangle(300,5, 200, myFont.Height * 5);
            String s = "Home";
            gBitmap.DrawString(s, myFont, Brushes.Black, rect);

            myFont = new Font("Times New Roman", 14, FontStyle.Italic);
            rect = new Rectangle(280, 28, 200, myFont.Height * 5);
            s = "It`s comfortable" +Environment.NewLine+ "It`s beautiful"; 
            gBitmap.DrawString(s, myFont, Brushes.Black, rect);

         
            myFont.Dispose();



        }
    }
}
