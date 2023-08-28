using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2G_RTE
{
    public class Player : Game, INotifyPropertyChanged
    {
        public static string BaseAddress = "0x4267D0";
        public string Offset = string.Empty;
        public string Firstname { get { return _Firstname; } set { _Firstname = value; NotifyPropertyChanged("Firstname"); } }
        string _Firstname = string.Empty;
        public string Surname { get { return _Surname; } set { _Surname = value; NotifyPropertyChanged("Surname"); } }
        string _Surname = string.Empty;
        public int SkinColor { get { return _SkinColor; } set { _SkinColor = value; NotifyPropertyChanged("SkinColor"); } }
        int _SkinColor = 0;
        public int HairColor { get { return _HairColor; } set { _HairColor = value; NotifyPropertyChanged("HairColor"); } }
        int _HairColor = 0;
        public int Age { get { return _Age; } set { _Age = value; NotifyPropertyChanged("Age"); } }
        int _Age = 0;
        public int Level { get { return _Level; } set { _Level = value; NotifyPropertyChanged("Level"); } }
        int _Level = 0;
        public int Position { get { return _Position; } set { _Position = value; NotifyPropertyChanged("Position"); } }
        int _Position = 0;
        public int Position2 { get { return _Position2; } set { _Position2 = value; NotifyPropertyChanged("Position2"); } }
        int _Position2 = 0;
        public int Position3 { get { return _Position3; } set { _Position3 = value; NotifyPropertyChanged("Position3"); } }
        int _Position3 = 0;
        public int TeamId { get { return _TeamId; } set { _TeamId = value; NotifyPropertyChanged("TeamId"); } }
        int _TeamId = 0;
        public int CurrentForm { get { return _CurrentForm; } set { _CurrentForm = value; NotifyPropertyChanged("CurrentForm"); } }
        int _CurrentForm = 0;
        public int PreviousForm { get { return _PreviousForm; } set { _PreviousForm = value; NotifyPropertyChanged("PreviousForm"); } }
        int _PreviousForm = 0;
        public int SpecialAbilities { get { return _SpecialAbilities; } set { _SpecialAbilities = value; NotifyPropertyChanged("SpecialAbilities"); } }
        int _SpecialAbilities = 0;
        public int MentalAttribute { get { return _MentalAttribute; } set { _MentalAttribute = value; NotifyPropertyChanged("MentalAttribute"); } }
        int _MentalAttribute = 0;
        public int MentalAttribute2 { get { return _MentalAttribute2; } set { _MentalAttribute2 = value; NotifyPropertyChanged("MentalAttribute2"); } }
        int _MentalAttribute2 = 0;
        public int PhysicalAttribute { get { return _PhysicalAttribute; } set { _PhysicalAttribute = value; NotifyPropertyChanged("PhysicalAttribute"); } }
        int _PhysicalAttribute = 0;
        public int Condition { get { return _Condition; } set { _Condition = value; NotifyPropertyChanged("Condition"); } }
        int _Condition = 0;
        public int Freshness { get { return _Freshness; } set { _Freshness = value; NotifyPropertyChanged("Freshness"); } }
        int _Freshness = 0;
        public int Unhappy { get { return _Unhappy; } set { _Unhappy = value; NotifyPropertyChanged("Unhappy"); } }
        int _Unhappy = 0;
        public int Unhappy2 { get { return _Unhappy2; } set { _Unhappy2 = value; NotifyPropertyChanged("Unhappy2"); } }
        int _Unhappy2 = 0;
        public int Happy { get { return _Happy; } set { _Happy = value; NotifyPropertyChanged("Happy"); } }
        int _Happy = 0;
        public int Nationality { get { return _Nationality; } set { _Nationality = value; NotifyPropertyChanged("Nationality"); } }
        int _Nationality = 0;
        public int ShirtNumber { get { return _ShirtNumber; } set { _ShirtNumber = value; NotifyPropertyChanged("ShirtNumber"); } }
        int _ShirtNumber = 0;
        public int InjuredDays { get { return _InjuredDays; } set { _InjuredDays = value; NotifyPropertyChanged("InjuredDays"); } }
        int _InjuredDays = 0;
        public int InjuredMonths { get { return _InjuredMonths; } set { _InjuredMonths = value; NotifyPropertyChanged("InjuredMonths"); } }
        int _InjuredMonths = 0;
        public int InjuredSlightly { get { return _InjuredSlightly; } set { _InjuredSlightly = value; NotifyPropertyChanged("InjuredSlightly"); } }
        int _InjuredSlightly = 0;
        public int CardsYellow { get { return _CardsYellow; } set { _CardsYellow = value; NotifyPropertyChanged("CardsYellow"); } }
        int _CardsYellow = 0;
        public int CardsYellowAccumulation { get { return _CardsYellowAccumulation; } set { _CardsYellowAccumulation = value; NotifyPropertyChanged("CardsYellowAccumulation"); } }
        int _CardsYellowAccumulation = 0;
        public int CardsRed { get { return _CardsRed; } set { _CardsRed = value; NotifyPropertyChanged("CardsRed"); } }
        int _CardsRed = 0;
        public int Goals { get { return _Goals; } set { _Goals = value; NotifyPropertyChanged("Goals"); } }
        int _Goals = 0;
        public int GoalsCupNational { get { return _GoalsCupNational; } set { _GoalsCupNational = value; NotifyPropertyChanged("GoalsCupNational"); } }
        int _GoalsCupNational = 0;
        public int GoalsCupInternational { get { return _GoalsCupInternational; } set { _GoalsCupInternational = value; NotifyPropertyChanged("GoalsCupInternational"); } }
        int _GoalsCupInternational = 0;
        public int GoalsTotal { get { return _GoalsTotal; } set { _GoalsTotal = value; NotifyPropertyChanged("GoalsTotal"); } }
        int _GoalsTotal = 0;
        public int Assists { get { return _Assists; } set { _Assists = value; NotifyPropertyChanged("Assists"); } }
        int _Assists = 0;
        public int Caps { get { return _Caps; } set { _Caps = value; NotifyPropertyChanged("Caps"); } }
        int _Caps = 0;
        public int CapsJoker { get { return _CapsJoker; } set { _CapsJoker = value; NotifyPropertyChanged("CapsJoker"); } }
        int _CapsJoker = 0;
        public int PenaltiesScored { get { return _PenaltiesScored; } set { _PenaltiesScored = value; NotifyPropertyChanged("PenaltiesScored"); } }
        int _PenaltiesScored = 0;
        public int PenaltiesTotal { get { return _PenaltiesTotal; } set { _PenaltiesTotal = value; NotifyPropertyChanged("PenaltiesTotal"); } }
        int _PenaltiesTotal = 0;
        public int FreekicksScored { get { return _FreekicksScored; } set { _FreekicksScored = value; NotifyPropertyChanged("FreekicksScored"); } }
        int _FreekicksScored = 0;
        public int FreekicksTotal { get { return _FreekicksTotal; } set { _FreekicksTotal = value; NotifyPropertyChanged("FreekicksTotal"); } }
        int _FreekicksTotal = 0;

        public void UpdateValues(Mem memory)
        {

            Firstname = memory.ReadString(GetAddress(memory, "2"), "", 32, true, Encoding.Latin1);
            Surname = memory.ReadString(GetAddress(memory, "C"), "", 32, true, Encoding.Latin1);
            SkinColor = memory.ReadByte(GetAddress(memory, "1C"));
            HairColor = memory.ReadByte(GetAddress(memory, "1D"));
            Age = memory.ReadByte(GetAddress(memory, "1E"));
            Level = memory.ReadByte(GetAddress(memory, "1F"));
            Position = memory.ReadByte(GetAddress(memory, "20"));
            Position2 = memory.ReadByte(GetAddress(memory, "21"));
            Position3 = memory.ReadByte(GetAddress(memory, "22"));
            TeamId = memory.ReadByte(GetAddress(memory, "23"));
            CurrentForm = memory.ReadByte(GetAddress(memory, "25"));
            PreviousForm = memory.ReadByte(GetAddress(memory, "26"));
            SpecialAbilities = memory.ReadByte(GetAddress(memory, "28"));
            MentalAttribute = memory.ReadByte(GetAddress(memory, "2C"));
            MentalAttribute2 = memory.ReadByte(GetAddress(memory, "2E"));
            PhysicalAttribute = memory.ReadByte(GetAddress(memory, "2F"));
            Condition = memory.ReadByte(GetAddress(memory, "30"));
            Freshness = memory.ReadByte(GetAddress(memory, "31"));
            Unhappy = memory.ReadByte(GetAddress(memory, "34"));
            Unhappy2 = memory.ReadByte(GetAddress(memory, "35"));
            Happy = memory.ReadByte(GetAddress(memory, "36"));
            Nationality = memory.ReadByte(GetAddress(memory, "38"));
            ShirtNumber = memory.ReadByte(GetAddress(memory, "3A"));
            InjuredDays = memory.ReadByte(GetAddress(memory, "44"));
            InjuredMonths = memory.ReadByte(GetAddress(memory, "45"));
            InjuredSlightly = memory.ReadByte(GetAddress(memory, "47"));
            CardsRed = memory.ReadByte(GetAddress(memory, "48"));
            CardsYellow = memory.ReadByte(GetAddress(memory, "4A"));
            CardsYellowAccumulation = memory.ReadByte(GetAddress(memory, "4C"));
            Goals = memory.ReadByte(GetAddress(memory, "56"));
            GoalsCupNational = memory.ReadByte(GetAddress(memory, "57"));
            GoalsCupInternational = memory.ReadByte(GetAddress(memory, "58"));
            GoalsTotal = memory.ReadByte(GetAddress(memory, "5A"));
            Assists = memory.ReadByte(GetAddress(memory, "6B"));
            Caps = memory.ReadByte(GetAddress(memory, "77"));
            CapsJoker = memory.ReadByte(GetAddress(memory, "6C"));
            PenaltiesScored = memory.ReadByte(GetAddress(memory, "6F"));
            PenaltiesTotal = memory.ReadByte(GetAddress(memory, "70"));
            FreekicksScored = memory.ReadByte(GetAddress(memory, "71"));
            FreekicksTotal = memory.ReadByte(GetAddress(memory, "72"));
        }

        public void ApplyChanges(Mem memory)
        {
            memory.WriteMemory(GetAddress(memory, "2"), "string", Firstname, "", Encoding.Latin1);
            memory.WriteMemory(GetAddress(memory, "C"), "string", Surname, "", Encoding.Latin1);
            memory.WriteMemory(GetAddress(memory, "1C"), "int", SkinColor.ToString());
            memory.WriteMemory(GetAddress(memory, "1D"), "int", HairColor.ToString());
            memory.WriteMemory(GetAddress(memory, "1E"), "int", Age.ToString());
            memory.WriteMemory(GetAddress(memory, "1F"), "int", Level.ToString());
            memory.WriteMemory(GetAddress(memory, "20"), "int", Position.ToString());
            memory.WriteMemory(GetAddress(memory, "21"), "int", Position2.ToString());
            memory.WriteMemory(GetAddress(memory, "22"), "int", Position3.ToString());
            memory.WriteMemory(GetAddress(memory, "23"), "int", TeamId.ToString());
            memory.WriteMemory(GetAddress(memory, "25"), "int", CurrentForm.ToString());
            memory.WriteMemory(GetAddress(memory, "26"), "int", PreviousForm.ToString());
            memory.WriteMemory(GetAddress(memory, "28"), "int", SpecialAbilities.ToString());
            memory.WriteMemory(GetAddress(memory, "2C"), "int", MentalAttribute.ToString());
            memory.WriteMemory(GetAddress(memory, "2E"), "int", MentalAttribute2.ToString());
            memory.WriteMemory(GetAddress(memory, "2F"), "int", PhysicalAttribute.ToString());
            memory.WriteMemory(GetAddress(memory, "30"), "int", Condition.ToString());
            memory.WriteMemory(GetAddress(memory, "31"), "int", Freshness.ToString());
            memory.WriteMemory(GetAddress(memory, "34"), "int", Unhappy.ToString());
            memory.WriteMemory(GetAddress(memory, "35"), "int", Unhappy2.ToString());
            memory.WriteMemory(GetAddress(memory, "36"), "int", Happy.ToString());
            memory.WriteMemory(GetAddress(memory, "38"), "int", Nationality.ToString());
            memory.WriteMemory(GetAddress(memory, "3A"), "int", ShirtNumber.ToString());
            memory.WriteMemory(GetAddress(memory, "44"), "int", InjuredDays.ToString());
            memory.WriteMemory(GetAddress(memory, "45"), "int", InjuredMonths.ToString());
            memory.WriteMemory(GetAddress(memory, "47"), "int", InjuredSlightly.ToString());
            memory.WriteMemory(GetAddress(memory, "48"), "int", CardsRed.ToString());
            memory.WriteMemory(GetAddress(memory, "4A"), "int", CardsYellow.ToString());
            memory.WriteMemory(GetAddress(memory, "4C"), "int", CardsYellowAccumulation.ToString());
            memory.WriteMemory(GetAddress(memory, "56"), "int", Goals.ToString());
            memory.WriteMemory(GetAddress(memory, "57"), "int", GoalsCupNational.ToString());
            memory.WriteMemory(GetAddress(memory, "58"), "int", GoalsCupInternational.ToString());
            memory.WriteMemory(GetAddress(memory, "5A"), "int", GoalsTotal.ToString());
            memory.WriteMemory(GetAddress(memory, "6B"), "int", Assists.ToString());
            memory.WriteMemory(GetAddress(memory, "77"), "int", Caps.ToString());
            memory.WriteMemory(GetAddress(memory, "6C"), "int", CapsJoker.ToString());
            memory.WriteMemory(GetAddress(memory, "6F"), "int", PenaltiesScored.ToString());
            memory.WriteMemory(GetAddress(memory, "70"), "int", PenaltiesTotal.ToString());
            memory.WriteMemory(GetAddress(memory, "71"), "int", FreekicksScored.ToString());
            memory.WriteMemory(GetAddress(memory, "72"), "int", FreekicksTotal.ToString());
        }

        public override string ToString()
        {
            return Firstname + " " + Surname;
        }
    }

}
