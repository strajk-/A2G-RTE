using System.Configuration;
using System.Data;
using System.Windows;

namespace A2G_RTE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static String[] mArgs;
        public static bool IsDebug;
        public static bool DoOffline;

        protected override void OnStartup(StartupEventArgs e)
        {
            mArgs = e.Args;
            foreach (Param param in GetParams(e.Args)) {
                switch (param.Name.ToLower()) {
                    case "debug":
                    case "d":
                        IsDebug = true;
                        break;
                    case "offline":
                    case "o":
                        DoOffline = true;
                        break;
                }
            }
        }

        public IEnumerable<Param> GetParams(string[] Args)
        {
            string mergeParams = string.Join(" ", Args);
            string[] paramSplit = mergeParams.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string param in paramSplit) {
                string[] parts = param.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0) {
                    Param p = new Param();
                    p.Name = parts.First();
                    if (parts.Length > 1) p.Value = parts.Last();
                    yield return p;
                }
            }
        }

        public class Param
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }

}
