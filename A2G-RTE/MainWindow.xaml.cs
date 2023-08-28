using Memory;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Wpf.Ui.Controls;

namespace A2G_RTE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UiWindow, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Member
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion

        bool Shutdown = false;
        public Game A2G = new Game();

        public ObservableCollection<Player> PlayerList { get; protected set; } = new ObservableCollection<Player>();

        Mem memory = new Mem();

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();

            this.Closing += (s, e) => {
                Shutdown = true;
            };

            // Do not check for running A2G Process, instead generate own data for debugging purposes
            if (App.DoOffline) {
                for (int i = 0; i < 10; i++) {
                    Player p = new Player();
                    p.Firstname = $"Player{i}";
                    p.Surname = $"Sur{i}";
                    PlayerList.Add(p);
                }
                return;
            }

            // Starts WatchDog Thread that automatically binds to the first A2G Instance it finds
            Thread gameWatchdog = new Thread(WatchDog);
            gameWatchdog.Start();
        }

        private void WatchDog()
        {
            while (!Shutdown) {
                Process p = Process.GetProcesses().FirstOrDefault(pi => pi.MainWindowTitle.ToLower().StartsWith("anstoss"));
                if (p != null) {
                    Dispatcher.Invoke(new Action(() => {
                        if (A2G.process == null || A2G.process.Id != p.Id) {
                            A2G.process = p;
                            A2G.IsRunning = true;
                            memory.OpenProcess(p.Id);
                        }
                    }));
                } else {
                    Dispatcher.Invoke(new Action(() => {
                        A2G.process = null;
                        A2G.IsRunning = false;
                    }));
                }

                Thread.Sleep(1000);
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateAction()) return;

            PlayerList.Clear();

            Club club = new Club();
            club.UpdateValues(memory);

            while (PlayerList.Count < club.PlayerCount) {
                Player p = new Player();
                if (PlayerList.Count > 0) {
                    p.Offset = A2G.SumHex(new string[] { PlayerList.Last().Offset, "178" });
                }
                p.UpdateValues(memory);
                PlayerList.Add(p);
            }
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateAction()) return;

            foreach (Player p in PlayerList) {
                p.ApplyChanges(memory);
            }
        }

        private bool ValidateAction()
        {
            if (memory.mProc.Process == null) {
                System.Windows.MessageBox.Show(this, "Anstoss 2 Gold Process not found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
    }
}