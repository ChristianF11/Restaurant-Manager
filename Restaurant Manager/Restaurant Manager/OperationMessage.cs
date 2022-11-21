using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    public class OperationMessage
    {
        public void GetGenericMessage()
        {
            MessageBox.Show("Operazione andata a buon fine", "Esito operazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GetGenericError()
        {
            MessageBox.Show("Qualcosa è andato storto", "Esito operazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void GetCustomMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GetCustomError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void GetGenericQuestion()
        {
            MessageBox.Show("Sicuro di voler confermare l'operazione?", "Conferma operazione", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void GetCustomQuestion(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
