using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3laba
{
    class Program
    {
        public static string Firstname
        {
            get; 
            private set; 
        }
        partial class Customer : IComparable
        {
        private int id = 0;
        private string surname = "";
        private string firstname = "";
        private string patronymic = "";
        private string address = "";
        private long credit_card_number = 0;
        private int balance = 0;
        private readonly int ID; //поле только для чтения
        private const double KOEF = 4.5; //поле-константа
        public static int ch = 0; //Статическое поле
        private static string about = "Класс Customer"; //Статическое поле
        public static string About { get { return about; } } //Статическое свойство класса
        public static string GetInfo() { return about; } //Статический метод класса
                                                         
        static float error;

            public int CompareTo(object o)
            {
                Customer p = o as Customer;
                if (p != null)
                    return this.firstname.CompareTo(p.Firstname);
                else
                    throw new Exception("Невозможно сравнить два объекта");
            }
            public int Iden
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public string Firstname
        {
                get{ return this.firstname; }
                set{ this.firstname = value; }
        }

        public string Patronymic
        {
            get { return this.patronymic; }
            set { this.patronymic = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public long CreditCard
        {
            get { return this.credit_card_number; }
            set { this.credit_card_number = value; }

        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }
        
        public Customer() //конструктор без параметров
        {
            this.id = 0;
            this.surname = "N/A";
            this.firstname = "N/A";
            this.patronymic = "N/A";
            this.address = "N/A";
            this.credit_card_number = 0;
            this.balance = 0;
            this.ID = id.GetHashCode();
        }

        public Customer(int iden, string srn, string frs, string ptr, string adr, long card, int blnc) //с параметрами
        {
            this.id = iden;
            this.surname = srn;
            this.firstname = frs;
            this.patronymic = ptr;
            this.address = adr;
            this.credit_card_number = card;
            this.balance = blnc;
            this.ID = id.GetHashCode();
            ch++;
        }

        public Customer(int iden, string frs, string srn = "")//параметр по умолчанию
        {
            this.id = iden;
            this.surname = srn;
            this.firstname = frs;
            this.patronymic = "N/A";
            this.address = "N/A";
            this.credit_card_number = 0;
            this.balance = 0;
            this.ID = id.GetHashCode();
        }
        static Customer() //статический конструктор
        {
            error = 0.001f;
        }
        private Customer(int resultr) { } //закрытый конструктор

        public void Enrollment() //метод зачисления //ref
        {
            int enrll;
            string enrl;
            Console.WriteLine("Введите сумму для зачисления: ");
            enrl = Console.ReadLine();
            enrll = Convert.ToInt32(enrl);
            this.balance = balance + enrll;
            Console.WriteLine("Итоговый баланс: " + balance);
        }
        public void Debit() //метод списания //out
        {
            int debit;
            string dbt;
            Console.WriteLine("Введите сумму для списания: ");
            dbt = Console.ReadLine();
            debit = Convert.ToInt32(dbt);
            this.balance = balance - debit;
            Console.WriteLine("Итоговый баланс: " + balance);
        }

        //public void GetInfor()//метод вывода информации
        //{
        //        Console.WriteLine("----------------------------------------");
        //        Console.WriteLine("ID: " + ID + "\nФамилия: " + surname + "\nИмя: " + firstname + "\nОтчество: " + patronymic + "\nАдрес: " + address + "\nНомер кредитной карты: " + credit_card_number + "\nБаланс: " + balance);
        //        Console.WriteLine("----------------------------------------");
        //}

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
    public class NewClass : System.Object//унаследование
    {
            
        public override bool Equals(object obj)//переопределение метода
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return base.Equals(obj);//ссылка  на родителя
        }
    }
        static void Main(string[] args)
        {
            Customer p1 = new Customer(15, "Kulakova", Firstname = "Tatyana", "Valerevna", "Zhlobin", 1597457836988742, 14154 );
            Customer p2 = new Customer(109, "Abramova", Firstname = "Ekaterina", "Sergeevna", "Mogilev", 4586135711665874, 263);
            Customer p3 = new Customer(5, "Sushkova", Firstname = "Polina", "Urevna", "Chashniki", 5987899817321523, 18000);
            Customer p4 = new Customer(69, "Yurkevich", Firstname = "Kirill", "Andreevich", "Zhodino", 8894321444239782, 999);
            Customer p5 = new Customer(2, "Horuzhai", Firstname = "Anastasia", "Sergeevna", "Borisov", 6342588512123344, 1020);
            Customer p6 = new Customer(1504, "Solodushenko", Firstname = "Olga", "Vladimirovna", "Baranovichi", 8779234522104736, 450);
            Customer[] customer = new Customer[] { p1, p2, p3, p4, p5, p6 };

            Console.WriteLine(Customer.About);//Вывод в консоль информации о классе Student
            Console.WriteLine("количество созданных объектов: " + Customer.ch);
            foreach (Customer p in customer)//вывод информации
            {
                Console.WriteLine(p.Iden + " " + p.Surname + " " + p.Firstname + " " + p.Patronymic + " " + p.Address + " " + p.CreditCard + " " + p.Balance);
            }
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Список  покупателей в алфавитном порядке:");
            Array.Sort(customer); // сортировка имён в алфавитном порядке
            foreach (Customer p in customer)
            {
                Console.WriteLine($"{p.Firstname}");
            }
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine("Список  покупателей, у которых номер кредитной карточки находится в заданном интервале:");
            foreach (Customer p in customer) //сортировка в заданном интервале
            {
                if (p.CreditCard > 7000000000000000)
                {

                    Console.WriteLine(p.Surname + " - " + p.CreditCard + "\t");

                }   
            }
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Зачисление средств на счёт Kulakova:");
            Console.WriteLine("Баланс на данный момент: " + p1.Balance);
            p1.Enrollment();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Списание средств со счёта Kulakova:");
            Console.WriteLine("Баланс на данный момент: " + p1.Balance);
            p1.Debit();
            Console.WriteLine("_________________________________________");
            Console.ReadKey();
        }
    }
}
