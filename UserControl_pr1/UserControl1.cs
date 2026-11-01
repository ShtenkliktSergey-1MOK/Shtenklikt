using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UserControl_pr1.FolderforModel; // Подключаем нашу созданную модель БД

namespace UserControl_pr1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // Метод, который будет брать одну строчку из базы данных и заполнять плитку
        public void Fill(Table_Motorbike motorbike)
        {
            // Заполняем текстовые поля данными из базы
            labelBrandData.Text = motorbike.Brand;
            labelModelData.Text = motorbike.Model;
            labelPriceData.Text = motorbike.Price.ToString() + " руб.";
            labelMileageData.Text = motorbike.Mileage.ToString() + " км";
            labelHorsepowerData.Text = motorbike.Horsepower.ToString(); // Исправленный баг методички!

            // Проверяем, существует ли картинка мотоцикла в папке проекта
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            string imagePath = Path.Combine(imagesFolder, motorbike.Picture);

            if (File.Exists(imagePath))
            {
                pictureBoxMotorbike.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Если картинка не найдена, очищаем поле, чтобы не было ошибки
                pictureBoxMotorbike.Image = null;
            }
        }
    }
}
