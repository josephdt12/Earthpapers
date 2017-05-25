using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Earthpapers {
    public class Program {
        public static void Main() {
            // Attempting Reddit POST
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "3t_-WJLzczPgpA:_JaZMwTVcjGpNoDialnkLecFoX8");

            Application.Run(new MainWindow());
        }
    }
}