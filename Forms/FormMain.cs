using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace MS_Lab1
{
    public partial class FormMain : Form
    {
        float t0 = 0; // стартовое время системы (мин)
        float dt = 0; // приращение времени  (мин)

        const float t1 = 5; // время для 1 детали (мин)
        const float t2 = 20; // время для 2 детали (мин)
        const float t3 = 10; // время для сборки (мин)

        const int N1 = 5; // шт. деталей выплевывается из 1 блока
        const int N2 = 20; // шт. деталей выплевывается из 2 блока
        const int N3 = 10;  // шт. деталей надо для конвейера

        // Инициализация главной формы
        public FormMain()
        {
            InitializeComponent();

            // Сортируем времена по возрастанию
            List<float> list = new List<float>();
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);
            list.Sort();

            dt = list[0] / 10; // делим наименьшее время на 10 (так надо)
        }
        // Обработка кнопки "Выход" на 1 вкладке
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Конец модуляции наступает, когда пройдут 1 сутки
        // 24 часа * 60 мин
        float isTimeOut = 24f*60f;

        float _t1 = t1;
        float _t2 = t2;
        float _t3 = t3;

        // Начать моделирование
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Обнуление переменных
            t0 = 0; // стартовое время системы (мин)

            _t1 = 5; // время для 1 детали (мин)
            _t2 = 20; // время для 2 детали (мин)
            _t3 = 10; // время для сборки (мин)

            // Очередь 1
            int queue1 = 0;
            // Очередь 2
            int queue2 = 0;
            // Комплектация 
            int equipment = 0;
            // Наличие деталей в 1 секции 
            int countSection1 = 0;
            // Наличие деталей во 2 секции 
            int countSection2 = 0;
            // Сборка свободна
            bool isEquipmentFree = true;
            // Время завершения сборки
            float tFinish = 0;

            //////////////////
            ///
            /// Показатели работы:
            ///
            //////////////////

            // Таймер
            var timer = Stopwatch.StartNew();
            // Средняя производительность конвейера
            float avgMakeDetal = 0;
            // Полное время простоя конвейера из-за незаполненности секций
            float fullIdleTimeConveyor = 0;
            // Средние и максимальное очереди по каждому типу изделия
            float avgQueue1 = 0;
            float maxQueue1 = 0;
            float minQueue1 = 0;
            float avgQueue2 = 0;
            float maxQueue2 = 0;
            float minQueue2 = 0;
            // Для среднего значения:
            List<int> queue1Elems = new List<int>();
            List<int> queue2Elems = new List<int>();

            // Начало модуляции
            while (t0 <= isTimeOut)
            {
                // УЗ 1
                if (t0 >= _t1)
                {
                    // Суем в очередь изготовленные детали 1 типа
                    queue1 += N1;
                    // Считаем следующее время для изготовление детали 1 типа
                    _t1 = t0 + t1;
                }
                // УЗ 2
                if (t0 >= _t2)
                {
                    // Суем в очередь изготовленные детали 1 типа
                    queue2 += N2;
                    // Считаем следующее время для изготовление детали 1 типа
                    _t2 = t0 + t2;
                }
                // УЗ 3
                if ((queue1 > 0 && countSection1 < N3) || (queue2 > 0 &&  countSection2 < N3))
                {
                    // Если в очереди 1 есть что-то и в конвейере меньше N3 деталей, то кидаем детали в конвейер
                    if (queue1 > 0 && countSection1 < N3)
                    {
                        do
                        {
                            ++countSection1;
                            --queue1;
                        } while (queue1 > 0 && countSection1 != N3);
                    }
                    // Если в очереди 2 есть что-то и в конвейере меньше N3 деталей, то кидаем детали в конвейер
                    if (queue2 > 0 && countSection2 < N3)
                    {
                        do
                        {
                            ++countSection2;
                            --queue2;
                        } while (queue2 > 0 && countSection2 != N3);
                    }
                }
                // УЗ 4
                if (countSection1 == N3 && countSection2 == N3 && isEquipmentFree)
                {
                    // Сборка занята
                    isEquipmentFree = false;
                    // Рассчет времени завершения
                    tFinish = t0 + t3;
                    // Забираем все детали из конвейера
                    countSection1 = 0;
                    countSection2 = 0;
                }
                // УЗ 5
                if (tFinish >= t0 && tFinish < (t0 + dt) && t0 != 0f)
                {
                    // Создаем новую вещь
                    ++equipment;
                    // Сборка свободна
                    isEquipmentFree = true;
                }
                // Вычисление простоя конвейера
                if (countSection1 == 0 || countSection2 == 0)
                {
                    fullIdleTimeConveyor += dt;
                }
                // Вычисление max/min/avg очередей
                if (countSection1 == N3)
                {
                    maxQueue1 = Math.Max(maxQueue1, queue1);
                    minQueue1 = Math.Min(minQueue1, queue1);
                    queue1Elems.Add(queue1);
                }
                if (countSection2 == N3)
                {
                    maxQueue2 = Math.Max(maxQueue2, queue2);
                    minQueue2 = Math.Min(minQueue2, queue2);
                    queue2Elems.Add(queue2);
                }

                // добавление в dgv инфы
                int rowNumber = dgv.Rows.Add();
                dgv.Rows[rowNumber].Cells["time"].Value = t0;
                dgv.Rows[rowNumber].Cells["queue1"].Value = queue1;
                dgv.Rows[rowNumber].Cells["queue2"].Value = queue2;
                dgv.Rows[rowNumber].Cells["countSection1"].Value = countSection1;
                dgv.Rows[rowNumber].Cells["countSection2"].Value = countSection2;
                dgv.Rows[rowNumber].Cells["isEquipmentFree"].Value = !isEquipmentFree;
                dgv.Rows[rowNumber].Cells["equipment"].Value = equipment;

                // Прибавление времени
                t0 += dt;
            }
            // Остановка таймера
            timer.Stop();
            // Показ на форме
            textBoxTime.Text = String.Format("{0:0.00}", ((float)timer.ElapsedMilliseconds) / 1000 / 60); // в минутах

            // Средняя производительность конвейера
            avgMakeDetal = (float)equipment / (t0 / 60f / 24f); // деталей в сутки
            // Запись на форму
            textBoxAvgSpeed.Text = avgMakeDetal.ToString();

            // Полное время простоя конвейера
            textBoxConeyorIdle.Text = fullIdleTimeConveyor.ToString();

            // Средние и максимальное очереди по каждому типу изделия
            textBoxMaxTimeIdleQueue1.Text = maxQueue1.ToString();
            textBoxMaxTimeIdleQueue2.Text = maxQueue2.ToString();
            textBoxMinTimeIdleQueue1.Text = minQueue1.ToString();
            textBoxMinTimeIdleQueue2.Text = minQueue2.ToString();
            // Среднее значение:
            foreach (int q in queue1Elems)
            {
                avgQueue1 += q;
            }
            foreach (int q in queue2Elems)
            {
                avgQueue2 += q;
            }
            avgQueue1 /= (float)queue1Elems.Count;
            avgQueue2 /= (float)queue1Elems.Count;
            // Вывод в форму
            textBoxAvgSpeedQueue1.Text = avgQueue1.ToString();
            textBoxAvgSpeedQueue2.Text = avgQueue2.ToString();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
