using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Reflection.Emit;

namespace A2G_RTE
{
    public class Club : Game, INotifyPropertyChanged
    {
        public static string BaseAddress = "0x403850";
        public string Offset = string.Empty;

        int _PlayerCount = 0;
        public int PlayerCount { get { return _PlayerCount; } set { _PlayerCount = value; NotifyPropertyChanged("PlayerCount"); } }

        public void UpdateValues(Mem memory)
        {
            PlayerCount = memory.ReadByte($"{memory.mProc.MainModule.ModuleName}+{Club.BaseAddress},{SumHex(new string[] { "E6", Offset })}");
        }

        public void ApplyChanges(Mem memory)
        {
            // Placeholder, changing Club attributes like Money is still in the TODO list
            // memory.WriteMemory(GetAddress(memory, "E6"), "int", PlayerCount.ToString());
        }
    }
}
