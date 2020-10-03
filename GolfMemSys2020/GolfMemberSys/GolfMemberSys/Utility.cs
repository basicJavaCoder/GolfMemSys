using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace GolfMemberSys
{
    class Utility
    {
        //Used to fill MemberID combobox in frmRecordPayment
        public static Array getMemberIDs()
        {
            //define Sql Query
            String strSQL = "SELECT MEMBERID FROM GOLFMEMBERSLOG WHERE MEMBERSTATUS != 'Removed'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds);

            //Close database connection
            conn.Close();

            string[] idArray = new string[ds.Tables[0].Rows.Count];

            //for(int i = 0; i <DataSet.)

            foreach (DataTable table in ds.Tables)
            {
                int i = 0;

                foreach (DataRow dr in table.Rows)
                {
                    idArray[i] = dr["MEMBERID"].ToString();
                    i++;
                }
            }

            //return ds;
            return idArray;
        }

        public static Array getTypePrice()
        {
            //define Sql Query
            String priceQuery = "SELECT TYPEPRICE FROM MEMBERTYPES";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(priceQuery, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds);

            //Close database connection
            conn.Close();

            string[] priceArray = new string[ds.Tables[0].Rows.Count];

            //for(int i = 0; i <DataSet.)

            foreach (DataTable table in ds.Tables)
            {
                int i = 0;

                foreach (DataRow dr in table.Rows)
                {
                    priceArray[i] = dr["TYPEPRICE"].ToString();
                    i++;
                }
            }

            //return ds;
            return priceArray;
        }

        public static Array getMemberTypes()
        {

            //define Sql Query
            String priceQuery = "SELECT TYPEID FROM MEMBERTYPES";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(priceQuery, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds);

            //Close database connection
            conn.Close();

            string[] typeArray = new string[ds.Tables[0].Rows.Count];

            //for(int i = 0; i <DataSet.)

            foreach (DataTable table in ds.Tables)
            {
                int i = 0;

                foreach (DataRow dr in table.Rows)
                {
                    typeArray[i] = dr["TYPEID"].ToString();
                    i++;
                }
            }

            //return ds;
            return typeArray;

        }

        public static Array getCountyList()
        {

            //define Sql Query
            String priceQuery = "SELECT * FROM COUNTYLIST";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(priceQuery, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds);

            //Close database connection
            conn.Close();

            string[] countyArray = new string[ds.Tables[0].Rows.Count];

            //for(int i = 0; i <DataSet.)

            foreach (DataTable table in ds.Tables)
            {
                int i = 0;

                foreach (DataRow dr in table.Rows)
                {
                    countyArray[i] = dr["COUNTY"].ToString();
                    i++;
                }
            }

            //return ds;
            return countyArray;

        }


        public static Array getMemberStatuses()
        {

            //define Sql Query
            String priceQuery = "SELECT * FROM MEMBERSTATUS";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(priceQuery, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds);

            //Close database connection
            conn.Close();

            string[] statusArray = new string[ds.Tables[0].Rows.Count];

            //for(int i = 0; i <DataSet.)

            foreach (DataTable table in ds.Tables)
            {
                int i = 0;

                foreach (DataRow dr in table.Rows)
                {
                    statusArray[i] = dr["MEMBERSTATUS"].ToString();
                    i++;
                }

            }

            return statusArray;

        }


        public static DataSet getRenewalsByDate(String date1, String date2)
        {

            //define Sql Query
            String strSQL = "SELECT * FROM RENEWALS WHERE DATEPAID BETWEEN '" + date1 + "' AND '" + date2 + "'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "RENEWALS");

            //Close database connection
            conn.Close();

            return ds;

        }
        
    }
}
