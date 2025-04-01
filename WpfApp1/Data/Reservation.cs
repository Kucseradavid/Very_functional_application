using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Data
{
    public class Reservation
    {
        public string nev {  get; set; }
        public string kezddat { get; set; }
        public string vegdat { get; set; }

        public string _fizess;
        public int fizess
        {
            get
            {
                if (_fizess == "Kártya")
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            set
            {
                if (value == 0)
                {
                    _fizess = "Kártya";
                }
                else
                {
                    _fizess = "Készpénz";
                }
            }
        }

        private int _szsz;
        public string szsz
        {
            get
            {
                return _szsz.ToString();
            }
            set
            {
                try
                {
                    _szsz = Convert.ToInt32(value);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Érvénytelen érték a személyek számának megadásánál!", "Hiba");
                    _szsz = 0;
                }
            }
        }

        public void mentes()
        {
            string sor = $"{nev};{kezddat};{vegdat};{_fizess};{_szsz}";

            /*StreamWriter adatok = new StreamWriter("../../../adatok.txt");
            adatok.WriteLine(sor);
            adatok.Close();*/

            MessageBox.Show(sor, "Sikeres mentés!");
        }
    }
}
