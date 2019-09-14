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
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ajoutxt
{
    public class DB_Helper
    {
        public int Conv_ID { get; set; }

        public string Partners { get; set; }
        public string Associations { get; set; }
        public string intitule_projet { get; set; }
        public decimal Montant { get; set; }
        public string objectifs { get; set; }

        private static string sqlConnectionString = @"server = localhost; user id = root; persistsecurityinfo = True; database = Assistant_DB; pwd=Faty.2000; port=3306";

        //This method gets all infos from contrat_infos table    
        private static List<DB_Helper> FindAll()
        {
            List<DB_Helper> infos = new List<DB_Helper>();
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                infos = connection.Query<DB_Helper>("SELECT * FROM conv_infos").ToList();
                connection.Close();
            }

            return infos;
        }

        public static DB_Helper FindSingle(string id)
        {
            DB_Helper record = null;
            string NewGUID = System.Guid.NewGuid().ToString();

            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                record = connection.QuerySingle<DB_Helper>("SELECT * FROM conv_infos WHERE NewGUID=@NewGUID", new { ConvID = id });
                connection.Close();
            }

            return record;
        }

        //This method inserts a contrat_infos record in database    
        public static int Insert(DB_Helper infos)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute("Insert into Contrat_infos (Partners, Associations, intitule_projet, objectifs) values (@Partners, @Associations , @intitule_projet, @objectifs)", new { Partners = infos.Partners, Associations = infos.Associations, intitule_projet = infos.intitule_projet, objectifs = infos.objectifs });
                connection.Close();
                return affectedRows;
            }
        }

        //This method update infos record in database    
         public static int Update(DB_Helper infos)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute("Update conv_infos set (Partners, Associations, intitule_projet, objectifs) values (@Partners, @Associations , @intitule_projet, @objectifs)", new { Partners = infos.Partners, Associations = infos.Associations, intitule_projet = infos.intitule_projet, objectifs = infos.objectifs });
                connection.Close();
                return affectedRows;
            }
        }

        //This method deletes an infos record from database    
         public static int Deleteinfos(DB_Helper infos)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute("Delete from conv_infos (Partners, Associations, intitule_projet, objectifs) values (@Partners, @Associations , @intitule_projet, @objectifs)", new { Partners = infos.Partners, Associations = infos.Associations, intitule_projet = infos.intitule_projet, objectifs = infos.objectifs });
                connection.Close();
                return affectedRows;
            }
        } 

    }
}
