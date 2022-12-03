using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class BsLogTable
    {

        private enum operationType
        {
            Edit = 0,
            Add = 1,
            Delete = 2
        }

        private string GetOperationType(int type)
        {
            operationType description;

            description = (operationType)type;

            return description.ToString();
        }

        public LogTable CreateEntity(int idReservation, int idRestaurant,int operationType, string username, DateTime operationDate)
        {
            LogTable logTable = new LogTable(idReservation,idRestaurant,operationType,username,GetOperationType(operationType),operationDate);

            return logTable;
        }

        //I nomi dei metodi riguardano i 3 tipi di operazioni eseguibili su un qualsiasi oggetto del gestionale (Creazione, Aggiornamento, Eliminazione), non sul log (che sarà sempre creato)
        public void Update(LogTable log, DbData dbData)
        {
            DsLogTable logTableData = new DsLogTable();
            logTableData.Update(log,dbData);
        }

        public void Create(LogTable log, DbData dbData)
        {

        }

        public void Delete(LogTable log, DbData dbData) 
        { 
        
        }

    }
}
