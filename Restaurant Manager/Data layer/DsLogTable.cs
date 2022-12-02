using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class DsLogTable
    {
        //Tutti i tipi di operazioni saranno degli "insert" nella tabella "LogTable"

        public void Create(LogTable log)
        {

        }

        public void Update(LogTable log, DbData dbData)
        {
            string query = $"insert into LogTable values({log.IdReservation}, {log.IdRestaurant}, '{log.Username}', " +
                $"convert(datetime,'{log.OperationDate}',103), {log.OperationType}, '{log.OperationDescription}')";

            dbData.UpdateTrans(query); 
        }

        public void Delete(LogTable log)
        {

        }

    }
}
