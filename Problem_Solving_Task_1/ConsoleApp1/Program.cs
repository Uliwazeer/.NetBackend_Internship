/*
 * Task Type >>> Problem Solving 
 * Requirements for task >>(C# V:12, .NET V:8.0, Visual Studio)
 * EFG Hermes Company
 * Under Supervision >>>>>> Eng/ Mohamed Bayoumi
 * Author >>>>>> Ali Wazeer
 * Task About 
 * "عندنا شخص أسمه أحمد راح البنك يوم 4 يونيو 2024 عمل شهادة 24% بمبلغ 100,000 ج لمدة 3 سنوات بتوزع أرباحها مرتين سنوياً 
و موعد استحقاق الفلوس يعني هياخد الـ 100,000 ج في نهاية المدة يوم 4 يونيو 2027
كده معناه انه هياخد الأرباح كل 6 شهور 12,000 ج و في آخر المدة هياخد 100,000 ج
REQUIREMENTS
لو كل المعلومات اللي فاتت دي عبارة عن متغيرات
Issue Date = Start Date = 4 June 2024
Maturity Date = End Date = 4 June 2027
Tenor = number of years = 3 years
Freq = count of coupons = 2 times a year
المتطلبات

تعرفوا تقولوا تواريخ الكوبونات ؟

تواريخ الأرباح ؟

و لو قولتلك النهارده يوم 7 أغسطس هيبقي آخر مرة خد أرباح يوم كام .؟ و المرة الجاية هتبقي يوم كام .؟

عايزكم تكملوا الـ class ده ف الكود ده "
*/
using System;

namespace EFG.AMS.BondsEquation.ProtoType.Helpers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the variables
            DateTime issueDate = new DateTime(2024, 6, 4); // Issue Date = Start Date = 4 June 2024
            DateTime maturityDate = new DateTime(2027, 6, 4); // Maturity Date = End Date = 4 June 2027
            double tenor = 3; // Tenor = number of years = 3 years
            double freq = 2; // Frequency = count of coupons = 2 times a year
            DateTime todayDate = new DateTime(2024, 8, 7); // Today's date

            // Bond instance
            Bond bond = new Bond(issueDate, maturityDate, tenor, freq, todayDate);

            // Calculate coupon periods
            CouponPeriod couponPeriod = MonthlyCouponFrequencyCalculator.CouponPeriodCalculation(bond);

            // Display results
            Console.WriteLine("Coupon Dates (Profit Dates):");
            foreach (var date in MonthlyCouponFrequencyCalculator.GetCouponDates(bond))
            {
                Console.WriteLine($"- {date:MM/dd/yyyy}");
            }
            Console.WriteLine();
            Console.WriteLine($"Last Profit Date: {couponPeriod.LastCouponDate:MM/dd/yyyy}");
            Console.WriteLine($"Next Profit Date: {couponPeriod.NextCouponDate:MM/dd/yyyy}");
        }
    }

    public static class MonthlyCouponFrequencyCalculator
    {
        public static DateTime GetNextCoupon(Bond bond)
        {
            DateTime nextCouponDate = bond.IssueDate;

            while (nextCouponDate <= bond.TodayDate && nextCouponDate < bond.MaturityDate)
            {
                nextCouponDate = nextCouponDate.AddMonths(6);
            }

            return nextCouponDate <= bond.MaturityDate ? nextCouponDate : DateTime.MinValue;
        }

        public static DateTime GetLastCoupon(Bond bond)
        {
            DateTime lastCouponDate = bond.IssueDate;

            while (lastCouponDate.AddMonths(6) <= bond.TodayDate && lastCouponDate.AddMonths(6) <= bond.MaturityDate)
            {
                lastCouponDate = lastCouponDate.AddMonths(6);
            }

            return lastCouponDate;
        }

        public static CouponPeriod CouponPeriodCalculation(Bond bond)
        {
            var lastCouponDate = GetLastCoupon(bond);
            var nextCouponDate = GetNextCoupon(bond);

            return new CouponPeriod
            {
                LastCouponDate = lastCouponDate,
                NextCouponDate = nextCouponDate
            };
        }

        public static DateTime[] GetCouponDates(Bond bond)
        {
            var couponDates = new System.Collections.Generic.List<DateTime>();
            DateTime couponDate = bond.IssueDate;

            while (couponDate <= bond.MaturityDate)
            {
                couponDates.Add(couponDate);
                couponDate = couponDate.AddMonths(6);
            }

            return couponDates.ToArray();
        }
    }

    public class CouponPeriod
    {
        public DateTime LastCouponDate { get; set; }
        public DateTime NextCouponDate { get; set; }
    }

    public class Bond
    {
        public DateTime IssueDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public double Tenor { get; set; }
        public double Freq { get; set; }
        public DateTime TodayDate { get; set; }

        public Bond(DateTime issueDate, DateTime maturityDate, double tenor, double freq, DateTime todayDate)
        {
            IssueDate = issueDate;
            MaturityDate = maturityDate;
            Tenor = tenor;
            Freq = freq;
            TodayDate = todayDate;
        }
    }
}
