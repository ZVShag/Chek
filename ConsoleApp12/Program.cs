using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Text.RegularExpressions;
namespace ConsoleApp12
{
    class chek
    {
        public double pay_day { get; set; }
        public double over_pay_day { get; set; }
        public int day_count { get; set; }
        public int over_day_count { get; set; }

        public static bool serial = false;
        public double pay;
        public double pay_shtraf;
        public double all_pay;
        chek() { }
        chek(double pd, double opd, int dc, int odc)
        {
            this.pay_day = pd;
            this.over_pay_day = opd;
            this.day_count = dc;
            this.over_day_count = odc;

        }
        chek(double pd, double opd, int dc, int odc, bool sr)
        {
            this.pay_day = pd;
            this.over_pay_day = opd;
            this.day_count = dc;
            this.over_day_count = odc;
            serial = sr;
        }
        private void All_pay() { all_pay = pay_shtraf + pay_day; }
        private void Pay() { pay = pay_day + day_count; }
        private void Pay_shtraf() {pay_shtraf = pay_shtraf + over_day_count; }

        public override string ToString()
        {
            return $"Общая сумма к оплате: {all_pay} рублей. \nВ том числе: \nЗа расчетный период   {pay} рублей,\nШтраф   {pay_shtraf} рублей.";
        }

        class Program
        {

            static void Main(string[] args)
            {
                chek a = new chek();
                WriteLine(a);

            }
        }
    }
}
