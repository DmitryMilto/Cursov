using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurceRPVS.Model
{
    public class Phisics
    {
        public Phisics()
        {
            m = 0.1;
            q0 = 10;
            dq0 = 1;
            k = 0.1;
            c = 0.01;

            m_item = 1;
            q0_item = 1;
            dq0_item = 0;
            k_item = 0;
            c_item = 0;

            time = 60;
            time_item = 0;
            time_interval = 1;
            time_interval_item = 0;
        }

        //Вводимые параметры
        public double m { get; set; } // масса 
        public int m_item { get; set; }
        public double q0 { get; set; } //начальное положение 
        public int q0_item { get; set; }
        public double dq0 { get; set; } //начальная скорость 
        public int dq0_item { get; set; }
        public double k { get; set; } // коэфициент жесткости пружины???? 
        public int k_item { get; set; }
        public double c { get; set; } // коэфициент затухания 
        public int c_item { get; set; }

        public double time { get; set; } // время измерения
        public int time_item { get; set; }
        public double time_interval { get; set; } // интервал измерения
        public int time_interval_item { get; set; }

        //Неизвестные
        private double n //
        {
            get
            {
                return c / (2 * m);
            }
        }
        public double w // круговая частота свободного колебания 
        {
            get
            {
                return Math.Sqrt(k / m);
            }
        }

        public double E // параметр затухания
        {
            get
            {
                return c / 2 * m * w;
            }
        }
        private double Wd // частота колебания с затуханием или чаcтота демпфированных колебаний
        {
            get
            {
                return w * Math.Sqrt(1 - Math.Pow(E, 2));
            }
        }
        private double WV
        {
            get
            {
                return w * Math.Sqrt(Math.Pow(E, 2) - 1);
            }
        }

        public double q(double t)  
        {
            double result = 0;
            if (n == w) // критическое затухание 
                result = (q0 * (1 + w * t) + dq0 * t) * Math.Pow(Math.E, -1 * w * t);

            if (n < w) // недодемпфированные системы ( с затуханием ниже критического)
                result = Math.Pow(Math.E, -1 * w * t * E) * (((dq0 + q0 * E * w) / Wd) * Math.Sin(Wd * t) + q0 * Math.Cos(Wd * t));

            if (n > w) // Передемпфированные системы ( с затуханием больше критического)
                result = Math.Pow(Math.E, -1 * w * t * E) * (((dq0 + q0 * E * w) / WV) * sh(WV * t) + q0 * ch(WV * t));

            return result;
        }

        private double sh(double x)
        {
            return (Math.Pow(Math.E, x) - Math.Pow(Math.E, -1 * x)) / 2;
        }
        private double ch(double x)
        {
            return (Math.Pow(Math.E, x) + Math.Pow(Math.E, -1 * x)) / 2;
        }

        //перевод в единицы измерения СИ
        public double CI_mass(double parents, int position )
        {
            if(position == 0)
            {
                parents = parents / 1000;
            }
            return parents;
        }

        public double CI_q0(double parents, int position)
        {
            if (position == 1)
            {
                parents = parents / 100;
            }
            return parents;
        }

        public double CI_dq0(double parents, int position)
        {
            if (position == 0)
            {
                parents = parents * 1000 / 3600;
            }
            return parents;
        }
        public double CI_time(double parents, int position)
        {
            if (position == 1)
            {
                parents = parents * 60;
            }
            return parents;
        }

        public double CI_timeInterval(double parents, int position)
        {
            if (position == 1)
            {
                parents = parents * 60;
            }
            return parents;
        }

        //перевод из единиц измерения СИ
        public double NoCI_mass(int position)
        {
            if (position == 0)
            {
                m = m * 1000;
            }
            return m;
        }

        public double NoCI_q0(int position)
        {
            if (position == 1)
            {
                q0 = q0 * 100;
            }
            return q0;
        }

        public double NoCI_dq0(int position)
        {
            if (position == 0)
            {
                dq0 = dq0 / 1000 * 3600;
            }
            return dq0;
        }
        public double NoCI_time(int position)
        {
            if (position == 1)
            {
                time = time / 60;
            }
            return time;
        }

        public double NoCI_timeInterval(int position)
        {
            if (position == 1)
            {
                time_interval = time_interval / 60;
            }
            return time_interval;
        }
    }
}
