using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace GolfMemberSys
{
    class MemberTypes
    {
        //Member Type variables
        private String typeID;
        private String typeName;
        private decimal typePrice;


        //GETTER
        public String getTypeID()
        {
            return typeID;
        }

        public String getTypeName()
        {
            return typeName;
        }

        public decimal getTypePrice()
        {
            return typePrice;
        }


        //SETTERS
        public void setTypeID(String typeID)
        {
            this.typeID = typeID;
        }

        public void setTypeName(String typeName)
        {
            this.typeName = typeName;
        }

        public void setTypePrice(decimal typePrice)
        {
            this.typePrice = typePrice;
        }

        public void addMemberType()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "INSERT INTO MEMBERTYPES (TYPEID, TYPENAME, TYPEPRICE) VALUES ('" +
                this.typeID + "', '" + this.typeName + "', " + this.typePrice + ")";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getMemberTypes()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM MEMBERTYPES ORDER BY TYPEID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "MEMBERTYPES");
                

            //Close database connection
            conn.Close();

            return ds;
        }

        public int getTypeCount(String typeID)
        {

            int typeCount = 0;

            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Open Database Connection
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT COUNT(*) FROM GOLFMEMBERSLOG  WHERE TYPEID = '" + typeID + "' GROUP BY TYPEID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Reader
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if(dr == null || !dr.HasRows)
            {
                typeCount = 0;
            }else
            {
                typeCount = dr.GetInt32(0);
            }
                

            conn.Close();

            return typeCount;

        }

        public decimal getTypeRevenue(String id)
        {

            decimal typeRevenue = 0;

            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Open Database Connection
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT TYPEPRICE FROM MEMBERTYPES  WHERE TYPEID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Reader
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            typeRevenue = dr.GetDecimal(0);

            conn.Close();

            if (typeRevenue == 0)
                return 0;
            else
                return typeRevenue;

        }

        public static DataSet getTypePrices()
        {
            //define Sql Query
            String strSQL = "SELECT TYPEID, TYPEPRICE FROM MEMBERTYPES";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "MEMBERTYPES");

            //Close database connection
            conn.Close();

            return ds;
        }

    }
}
