using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // Обязательно для работы фильтрации LINQ!
using System.Windows.Forms;
using UserControl_pr1.FolderforModel; // Подключение нашей модели БД

namespace UserControl_pr1
{
    public partial class Form1 : Form
    {
        // Глобальные переменные для работы с базой данных
        public static ModelDB DB = new ModelDB();

        // Список мотоциклов, который отображается в данный момент (может фильтроваться)
        List<Table_Motorbike> Motorbikes = new List<Table_Motorbike>();

        // Индекс первой отображаемой плитки на экране
        int AccNumber = 0;

        public Form1()
        {
            InitializeComponent();

            // Принудительно связываем события без использования дизайнера:
            this.Load += new System.EventHandler(this.Form1_Load);
            buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
        }

        // Событие загрузки формы (первичная настройка данных)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Загружаем все данные из базы при старте приложения
            ResetFilters();

            // Настраиваем ComboBox для выбора брендов (выбираем уникальные марки из БД)
            var brands = DB.Table_Motorbike.Select(m => m.Brand).Distinct().ToList();
            brands.Insert(0, "Все бренды"); // Добавляем дефолтный вариант в начало списка
            comboBoxBrand.DataSource = brands;
        }

        // Метод отрисовки элементов на форме
        private void Loading()
        {
            // Проверяем, есть ли вообще элементы для отображения после фильтрации
            if (Motorbikes.Count == 0)
            {
                MessageBox.Show("Мотоциклы по заданным критериям не найдены.");
                return;
            }

            // Заполнение 1-го User Control данными
            userControl11.Fill(Motorbikes[AccNumber]);

            // Проверяем, есть ли второй элемент в списке, чтобы не выйти за границы массива
            if (AccNumber + 1 < Motorbikes.Count)
            {
                userControl12.Visible = true;
                userControl12.Fill(Motorbikes[AccNumber + 1]); // Заполнение 2-го User Control
            }
            else
            {
                // Если мотоцикл остался всего один, скрываем вторую плитку, чтобы не дублировать
                userControl12.Visible = false;
            }
        }

        // Перегрузка метода Loading для перелистывания вперед/назад
        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber += 2; // Листаем вперед на 2 элемента
            else if (Incr == false && 0 <= AccNumber - 2)
                AccNumber -= 2; // Листаем назад на 2 элемента
            else
                return;

            Loading();
        }

        // КНОПКА «НАЗАД» (<)
        private void buttonLeft_Click(object sender, EventArgs e) => Loading(false);

        // КНОПКА «ВПЕРЕД» (>)
        private void buttonRight_Click(object sender, EventArgs e) => Loading(true);

        // КНОПКА «ПРИМЕНИТЬ ФИЛЬТР»
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            // Начинаем выборку со всей таблицы мотоциклов
            var query = DB.Table_Motorbike.AsQueryable();

            // 1. Фильтрация по Бренду
            if (comboBoxBrand.SelectedIndex > 0) // Если выбран конкретный бренд, а не "Все бренды"
            {
                string selectedBrand = comboBoxBrand.SelectedItem.ToString();
                query = query.Where(m => m.Brand == selectedBrand);
            }

            // 2. Фильтрация по Максимальной Цене
            if (!string.IsNullOrWhiteSpace(textBoxMaxPrice.Text))
            {
                if (double.TryParse(textBoxMaxPrice.Text, out double maxPrice))
                {
                    query = query.Where(m => m.Price <= maxPrice);
                }
                else
                {
                    MessageBox.Show("Введите корректное число для цены.");
                    return;
                }
            }

            // Сбрасываем индекс на начало списка и записываем отфильтрованный результат
            AccNumber = 0;
            Motorbikes = query.ToList();

            // Перерисовываем элементы на форме
            Loading();
        }

        // КНОПКА «СБРОСИТЬ ФИЛЬТРЫ»
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxBrand.SelectedIndex = 0;
            textBoxMaxPrice.Clear();
            ResetFilters();
        }

        // Вспомогательный метод сброса данных к начальному списку
        private void ResetFilters()
        {
            AccNumber = 0;
            Motorbikes = DB.Table_Motorbike.ToList(); // Копируем заново всю таблицу из БД
            userControl12.Visible = true;
            Loading();
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }
    }
}
