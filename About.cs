using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook_.NET_Framework_v._1._0
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            textBoxAbout.Text = $" Данное приложение выполнено в учебных целях. \r\n Справка: \r\n 1. Для перехода к интересующей дате - кликните по ней правой кнопкой мыши в календаре и выберите пункт 'Перейти к дате'." +
                " \r\n 2. Для создания новой задачи можно воспользоваться комбинацией клавиш Ctrl+N или верхним меню, выбрав 'Файл -> Создать'." +
                "\r\n3. Для редактирования созданной задачи можно воспользоваться верхним меню: 'Правка -> Редактировать' или кликнуть правой кнопкой мыши по нужной строке.";
        }
    }
}
