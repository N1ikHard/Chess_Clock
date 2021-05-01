using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Clock
{
    class Clock
    {
        int hms;               // Сколько времени осталось до конца тайма
        public bool paused;    //Флаг для паузы таймера
        long now;               //Переменная для

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public Clock(int hours, int minutes, int seconds)       //При инициализации конструктора происходит
        {                                                       //Установка значений для работы таймера
            Set_Time(hours, minutes, seconds);
        }
        /// <summary>
        /// Установка времени для таймера
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void Set_Time(int hours, int minutes, int seconds)
        {
            hms = 10 * (hours * 3600 + minutes * 60 + seconds); //Сколько всего секунд на игру
            paused = true;                                      //Ставим на паузу
            SetNow();                                           //Установка текущее время для будущих расчетов
        }
        /// <summary>
        /// Метод постановки таймера на паузу
        /// </summary>
        public void StopClock()
        {
            if (!paused) TikTakClock();             //Если  нет паузы , то срабатывает  метод подсчета времени
            paused = true;                          //Ставится пауза
        }
        /// <summary>
        /// Метод продолжения работы таймера , если  стоит пауза , то происходит подсчет времени , пауза отменяется
        /// </summary>
        public void PlayClock()
        {
            if (paused) SetNow();
            paused = false;
        }
        /// <summary>
        /// Метод , записывающий текущее время в тысячных долях тиков?
        /// </summary>
        private void SetNow()       
        {
            now = DateTime.Now.Ticks / 1000 / 1000;
        }
        /// <summary>
        /// Подобие таймера
        /// </summary>
        public void TikTakClock()
        {
            if (paused) return;    
            long old = now;                 //Переменная времени начала игры
            SetNow();                       //Установка нового значения 
            int delta = Convert.ToInt32(now - old);   //Сколько прошло времени от начала до текущего момента
            hms -= delta;                           //Отнимаем от времени игры дельту
            if (hms < 0) hms = 0;                   //Если время кончилось - оно равно 0
        }
        /// <summary>
        /// Метод возвращает строчное представления времени
        /// </summary>
        /// <returns></returns>
        public string ShowClock()
        {
            TikTakClock();    //Метод рассчитывает время в тысячных долях тиков  
            int h, m, s , ms;           
            ms = hms % 10;          //десятые доли секунды
            s = hms/10 % 60;        //Секунды
            m = hms /10% 3600/60;   //Минуты
            h = hms/10 / 3600;      //Часы
            return (h == 0 ? "" :h.ToString()+":")+  m.ToString("00") + ":" + s.ToString("00")+"."+ms.ToString();            
        }
    }
}
