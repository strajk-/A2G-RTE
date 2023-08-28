using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A2G_RTE
{
    public class Game : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Member
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion

        public Process process { get; set; }
        bool _IsRunning = false;
        public bool IsRunning { get { return _IsRunning; } set { _IsRunning = value; NotifyPropertyChanged("IsRunning"); } }

        public string SumHex(string[] hexValues)
        {
            int output = 0;

            foreach (string hex in hexValues) {
                if (string.IsNullOrEmpty(hex)) continue;
                output += Convert.ToInt32(hex, 16);
            }

            return output.ToString("X");
        }

        public string GetAddress(Mem memory, string BaseOffset)
        {
            string output = string.Empty;

            if(this is Player p) {
                output = $"{memory.mProc.MainModule.ModuleName}+{Player.BaseAddress},{SumHex(new string[] { BaseOffset, p.Offset })}";
            }
            if (this is Club c) {
                output = $"{memory.mProc.MainModule.ModuleName}+{Club.BaseAddress},{SumHex(new string[] { BaseOffset, c.Offset })}";
            }

            return (output);
        }
    }
}
