using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LogTable
    {
        private int idLog, idReservation, idRestaurant, operationType;
        private string username;
        private DateTime operationDate;

        public int IdLog
        {
            get { return idLog; }
            set { idLog = value; }
        }

        public int IdReservation
        {
            get { return idReservation; }
            set { idReservation = value; }
        }

        public int IdRestaurant
        {
            get { return idRestaurant; }
            set { idRestaurant = value; }
        }

        public int OperationType
        {
            get { return operationType; }
            set { operationType = value; }

        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public DateTime OperationDate
        {
            get { return operationDate; }
            set { operationDate = value; }
        }

        public LogTable()
        {
            IdLog = 0;
            IdReservation = 0;
            IdRestaurant = 0;
            OperationType = 0;
            Username = string.Empty;
            OperationDate = DateTime.Now;
        }

        public LogTable(int idLog, int idReservation, int idRestaurant, int operationType, string username, DateTime operationDate)
        {
            IdLog = idLog;
            IdReservation = idReservation;
            IdRestaurant = idRestaurant;
            OperationType = operationType;
            Username = username;
            OperationDate = operationDate;
        }
    }
}
