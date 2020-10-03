using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace GolfMemberSys
{
    class Renewals
    {

        public int renewalID;
        public int memberID;
        public decimal amountPaid;

        public int getRenewalID()
        {
            return renewalID;
        }

        public int getMemberID()
        {
            return memberID;
        }

        public decimal getAmountPaid()
        {
            return amountPaid;
        }

        public void setRenewalID(int renewalID)
        {
            this.renewalID = renewalID;
        }

        public void setMemberID(int memberID)
        {
            this.memberID = memberID;
        }

        public void setAmountPaid(decimal amountPaid)
        {
            this.amountPaid = amountPaid;
        }

        //**********Record Payments**********

        //GET NEXT MEMBER ID
        public static int getNextRenewalID()
        {
            int nextRenewalID;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT MAX(RENEWALID) FROM RENEWALS";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr[0] == DBNull.Value)
                nextRenewalID = 1;
            else
                nextRenewalID = Convert.ToInt32(dr[0]) + 1;

            conn.Close();

            return nextRenewalID;
        }


        public void recordNewPayment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "INSERT INTO RENEWALS (RENEWALID, MEMBERID, AMOUNTPAID, DATEPAID) VALUES ('" +
                this.renewalID + "', '" + this.memberID + "', " + this.amountPaid + ", SYSDATE)";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getRecordPaymentInformation()
        {
            //define Sql Query
            String strSQL = "SELECT m.MEMBERID, m.FIRSTNAME, m.LASTNAME, m.PAID, r.AMOUNTPAID, t.TYPEID, " +
                            "t.TYPENAME, t.TYPEPRICE " +
                            "FROM RENEWALS r " +
                            "INNER JOIN GOLFMEMBERSLOG m " +
                            "ON r.MEMBERID = m.MEMBERID " +
                            "INNER JOIN MEMBERTYPES t " +
                            "ON m.TYPEID = t.TYPEID " +
                            "WHERE m.MEMBERSTATUS NOT LIKE 'Removed'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet dst = new DataSet();

            da.Fill(dst);

            //Close database connection
            conn.Close();

            return dst;
        }

        //**********End Record Payments**********

    }
}
