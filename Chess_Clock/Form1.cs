using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Clock
{
    public partial class Form1 : Form
    {
        Color color_active1 = Color.LightPink;  // Для игры используется 2 таймера с разными цветами
        Color color_active2 = Color.LightBlue;  //Цвет деактивации таймера 
        Color color_passive = Color.LightGray;
        Clock clock1;
        Clock clock2;
        public Form1()
        {
            InitializeComponent();
            clock1 = new Clock(0,0,0);      //создание двух таймеров
            clock2 = new Clock(0,0,0);
        }
        /// <summary>
        /// Событие включения таймера , при задевании мышкой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clock_label1_MouseEnter(object sender, EventArgs e)
        {
            clock1.PlayClock();                //Один таймер включается , другой останавливается
            clock2.StopClock();
            Clock_label1.BackColor = color_active1;     //Смена цветов таймера
            Clock_label2.BackColor = color_passive; 
        }
        /// <summary>
        /// Событие включения таймера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clock_label2_MouseEnter(object sender, EventArgs e)
        {
            clock2.PlayClock();
            clock1.StopClock(); 
            Clock_label2.BackColor = color_active2;
            Clock_label1.BackColor = color_passive;
        }
        /// <summary>
        /// Событие постановки таймера на паузу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clock_label2_MouseClick(object sender, MouseEventArgs e)
        {
            clock1.StopClock();
            clock2.StopClock(); 
            Clock_label2.BackColor = color_passive;
            Clock_label1.BackColor = color_passive;
        }
        /// <summary>
        /// Системный таймер , который не подходит для расчета секунд обновляет значения таймера , где описан метод вычисления , удовлетворяющий нашим требованиям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            Clock_label1.Text = clock1.ShowClock();
            Clock_label2.Text = clock2.ShowClock();
        }
        /// <summary>
        /// Инициализация нашего таймера
        /// </summary>
        /// <param name="h"></param>
        /// <param name="m"></param>
        private void InitClock(int h , int m)
        {
            clock1.Set_Time(h, m,0);
            clock2.Set_Time(h, m, 0);
            clock1.StopClock();
            clock2.StopClock();
        }
        /// <summary>
        /// Событие , устанавливающее значения для таймера при выборе атрибута из MenuStrio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool2min_Click(object sender, EventArgs e)
        {
            InitClock(0, 2);
        }
        /// <summary>
        /// Событие , устанавливающее значения для таймера при выборе атрибута из MenuStrio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool5min_Click(object sender, EventArgs e)
        {
            InitClock(0, 5);
        }
        /// <summary>
        /// Событие , устанавливающее значения для таймера при выборе атрибута из MenuStrio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool1h_Click(object sender, EventArgs e)
        {
            InitClock(1, 0);
        }
    }
}
