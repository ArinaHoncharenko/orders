using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop8_orders
{
    public partial class MainForm : Form
    {
        // Клас для представлення замовлення
        public class Order
        {
            public int OrderNumber { get; set; }
            public string CustomerName { get; set; }
            public string ContactPhone { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string OrderStatus { get; set; }
        }

        // Список для зберігання замовлень
        private List<Order> orders;

        public MainForm()
        {
            InitializeComponent();

            // Ініціалізація списку та додавання вигаданих замовлень
            orders = new List<Order>
            {
                new Order { OrderNumber = 1, CustomerName = "Клішина Ольга Володимирівна", ContactPhone = "+0676755483", City = "Київ", PostalCode = "23", OrderStatus = "В обробці" },
                new Order { OrderNumber = 2, CustomerName = "Цимбал Олена Олексіївна", ContactPhone = "+0936578478", City = "Львів", PostalCode = "78", OrderStatus = "Відправлено" },
                new Order { OrderNumber = 3, CustomerName = "Гибало Андрій Станіславович", ContactPhone = "+0967856454", City = "Одеса", PostalCode = "59", OrderStatus = "Доставлено" },
                new Order { OrderNumber = 4, CustomerName = "Доценко Максим Іванович", ContactPhone = "+0663655478", City = "Харків", PostalCode = "12", OrderStatus = "В обробці" }
            };

            // Заповнення таблиці даними при завантаженні форми
            PopulateTable();
        }

        private void PopulateTable()
        {
            // Очищення таблиці перед заповненням
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Header", "Номер замовлення");
            dataGridView1.Columns.Add("Header", "ПІБ клієнта");
            dataGridView1.Columns.Add("Header", "Номер телефону");
            dataGridView1.Columns.Add("Header", "Місто");
            dataGridView1.Columns.Add("Header", "Номер пошти");
            dataGridView1.Columns.Add("Header", "Статус");

            // Додавання замовлень до таблиці
            foreach (var order in orders)
            {
                dataGridView1.Rows.Add(
                    order.OrderNumber,
                    order.CustomerName,
                    order.ContactPhone,
                    order.City,
                    order.PostalCode,
                    order.OrderStatus
                );
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
