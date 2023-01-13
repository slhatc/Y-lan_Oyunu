﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Yılan_Oyunu
{
    class Yilan
    {
        Yilan_parcalari[] yilan_Parcalari;
        int yilan_buyuklugu;
        Yon yonumuz;
        public Yilan()
        {
            yilan_Parcalari = new Yilan_parcalari[3];
            yilan_buyuklugu = 3;
            yilan_Parcalari[0] = new Yilan_parcalari(150,150);
            yilan_Parcalari[1] = new Yilan_parcalari(160, 150);
            yilan_Parcalari[2] = new Yilan_parcalari(170, 150);

        }
        public void İlerle(Yon yon)
        {
            yonumuz = yon;
            if (yon._x == 0 && yon._y == 0)
            {

            }
            else
            {

                for (int i = yilan_Parcalari.Length - 1; i > 0; i--)
                {
                    yilan_Parcalari[i] = new Yilan_parcalari(yilan_Parcalari[i - 1].x_, yilan_Parcalari[i - 1].y_);
                }
                yilan_Parcalari[0] = new Yilan_parcalari(yilan_Parcalari[0].x_ + yon._x, yilan_Parcalari[0].y_ + yon._y);
            }
     
        }
        public void Buyu()
        {
            Array.Resize(ref yilan_Parcalari, yilan_Parcalari.Length + 1);
            yilan_Parcalari[yilan_Parcalari.Length - 1] = new Yilan_parcalari(yilan_Parcalari[yilan_Parcalari.Length - 2].x_ -yonumuz._x, yilan_Parcalari[yilan_Parcalari.Length - 2].y_ -yonumuz._y);
            yilan_buyuklugu++;
        }
        public Point GetPos(int number)
        {
            return new Point(yilan_Parcalari[number].x_, yilan_Parcalari[number].y_);
        }
        public int Yilan_buyuklugu
        {
            get
            {
                return yilan_buyuklugu;
            }
        }
    }
    class Yilan_parcalari
    {
        public int x_;
        public int y_;
        public readonly int size_x;
        public readonly int size_y;
        public Yilan_parcalari(int x, int y)
        {
            x_ = x;
            y_ = y;
            size_x = 10;
            size_y = 10;
        }
    }
    class Yon
    {
        public readonly int _x;
        public readonly int _y;
        public Yon(int x,int y)
        {
            _x = x;
            _y = y;
        }
    }
}
