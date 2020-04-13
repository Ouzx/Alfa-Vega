using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfa_Vega
{
    public class Randomizer
    //if (Producer.dateTime.ToString() != "1.01.0001 00:00:00") this.dateTimePicker1.Value = Producer.dateTime;
    {
        public void GetProducer(Selected.Units _unit, string _name, string _ownerID, bool _done) 
        {
            int delta = DateTime.Now.Hour - 8;
            Random random = new Random();
            int total = random.Next(70, 90);
            int pass = total - random.Next(60,80);
            string _userName = "";
            if (_done)
            {
                DB dB = new DB();
                _userName = dB.GetOwnerName(_unit, _ownerID);
            }
            else _userName = _ownerID;
            int[] production = new int[] { total, total-pass, pass};
            OpenForm.OpnForm(new Producer(_unit,_name,true,delta.ToString("00") + ":00",_userName,
                production,new int[] { random.Next(30,40), random.Next(50,60), random.Next(60,70), random.Next(70,80)},
                new int[] { random.Next(100,900), random.Next(100, 900) , random.Next(100, 900) , random.Next(100, 900),
                            random.Next(100,900),random.Next(100,900),random.Next(100,900)}));
        }
        public void GetProducer(Selected.Units _unit, string _name, string _ownerID, bool _done, DateTime _dateTime)
        {
            int delta = DateTime.Now.Hour - 8;
            Random random = new Random();
            int total = random.Next(70, 90);
            int pass = total - random.Next(60, 80);
            string _userName = "";
            if (_done)
            {
                DB dB = new DB();
                _userName = dB.GetOwnerName(_unit, _ownerID);
            }
            else _userName = _ownerID;
            int[] production = new int[] { total, total - pass, pass };
            OpenForm.OpnForm(new Producer(_unit, _name, true, delta.ToString("00") + ":00", _userName,
                production, new int[] { random.Next(30, 40), random.Next(50, 60), random.Next(60, 70), random.Next(70, 80) },
                new int[] { random.Next(100,900), random.Next(100, 900) , random.Next(100, 900) , random.Next(100, 900),
                            random.Next(100,900),random.Next(100,900),random.Next(100,900)},_dateTime));
        }
    }
}
