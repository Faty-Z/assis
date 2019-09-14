using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using Dapper;
using MySql.Data;

namespace ajoutxt
{
    public class DBHelper
    {
        public string Conv_ID { get; set; }

        public string Partners { get; set; }
        public string Associations { get; set; }
        public string intitule_projet { get; set; }
        public decimal Montant { get; set; }
        public string objectifs { get; set; }

      //  MySql.Data.MySqlClient.MyMySqlConnection sqlConnectionString;
        private static string sqlConnectionString = @"server=127.0.0.1;uid=root;pwd=Faty.2000;database=assistant_DB";//port=3306;

        //This method gets all infos from contrat_infos table    
        private static List<DBHelper> FindAll()
        {
            List<DBHelper> infos = new List<DBHelper>();
            using (var connection = new MySqlConnection(sqlConnectionString))
            {
                connection.Open();
                infos = connection.Query<DBHelper>("SELECT * FROM conv_infos").ToList();
                connection.Close();
            }

            return infos;
        }

        public static DBHelper FindSingle(string id)
        {
            DBHelper record = null;
            string NewGUID = System.Guid.NewGuid().ToString();

            using (var connection = new MySqlConnection(sqlConnectionString))
            {
                connection.Open();
                record = connection.QuerySingle<DBHelper>("SELECT * FROM conv_infos WHERE NewGUID=@NewGUID", new { ConvID = id });
                connection.Close();
            }

            return record;
        }

        //This method inserts a contrat_infos record in database    
        public static int Insert(DBHelper infos)
        {
            using (var connection = new MySqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute("Insert into Contrat_infos (Partners, Associations, intitule_projet, objectifs) values (@Partners, @Associations , @intitule_projet, @objectifs)", new { Partners = infos.Partners, Associations = infos.Associations, intitule_projet = infos.intitule_projet, objectifs = infos.objectifs });
                connection.Close();
                return affectedRows;
            }
        }

        //This method update infos record in database    
         public static int Update(DBHelper infos)
        {
            using (var connection = new MySqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute("Update conv_infos set (Partners, Associations, intitule_projet, objectifs) values (@Partners, @Associations , @intitule_projet, @objectifs)", new { Partners = infos.Partners, Associations = infos.Associations, intitule_projet = infos.intitule_projet, objectifs = infos.objectifs });
                connection.Close();
                return affectedRows;
            }
        }

        //This method deletes an infos record from database    
         public static int Deleteinfos(DBHelper infos)
        {
            using (MySqlConnection connection = new MySqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute("Delete from conv_infos (Partners, Associations, intitule_projet, objectifs) values (@Partners, @Associations , @intitule_projet, @objectifs)", new { Partners = infos.Partners, Associations = infos.Associations, intitule_projet = infos.intitule_projet, objectifs = infos.objectifs });
                connection.Close();
                return affectedRows;
            }
        } 

    }
}
