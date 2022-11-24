using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    static class OperationMessage
    {
        public static void GetGenericMessage()
        {
            MessageBox.Show("Operazione andata a buon fine", "Esito operazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void GetGenericError()
        {
            MessageBox.Show("Qualcosa è andato storto", "Esito operazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GetCustomMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void GetCustomError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GetCustomWarning(string message, string title)
        {
            MessageBox.Show(message,title,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult GetGenericQuestion()
        {
            DialogResult res;

            res = MessageBox.Show("Sicuro di voler confermare l'operazione?", "Conferma operazione", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return res;
        }

        public static DialogResult GetCustomQuestion(string message, string title)
        {
            DialogResult res;

            res = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return res;
        }

        public static void GetIsEmpty()
        {
            MessageBox.Show("Nessun elemento in lista. Impossibile effettuare l'operazione", "Errore operazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
