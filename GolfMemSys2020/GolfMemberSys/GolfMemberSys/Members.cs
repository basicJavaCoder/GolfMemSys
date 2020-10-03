using System;
using System.Data;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace GolfMemberSys
{
    class Members
    {
        private int memberID;
        private String firstName;
        private String lastName;
        private String street;
        private String town;
        private String county;
        private String mobile;
        private String email;
        private String memberStatus;
        private String typeID;
        private String paid;

        //GETTERS
        public int getMemberID()
        {
            return memberID;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String getStreet()
        {
            return street;
        }

        public String getTown()
        {
            return town;
        }

        public String getCounty()
        {
            return county;
        }

        public String getMobile()
        {
            return mobile;
        }

        public String getEmail()
        {
            return email;
        }

        public String getMemberStatus()
        {
            return memberStatus;
        }

        public String getTypeID()
        {
            return typeID;
        }

        public String getPaid()
        {
            return paid;
        }

        //SETTERS
        public void setMemberID(int memberID)
        {
            this.memberID = memberID;
        }

        public void setMemberFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void setMemberLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }

        public void setMobile(String mobile)
        {
            this.mobile = mobile;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setMemberStatus(String memberStatus)
        {
            this.memberStatus = memberStatus;
        }

        public void setTypeID(String typeID)
        {
            this.typeID = typeID;
        }


        public void setPaid(String paid)
        {
            this.paid = paid;
        }



        //**************ADD MEMBER************************************
        //GET NEXT MEMBER ID
        public static int getNextMemberID()
        {
            int nextMemberID;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT MAX(MEMBERID) FROM GOLFMEMBERSLOG";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr[0] == DBNull.Value)
                nextMemberID = 1;
            else
                nextMemberID = Convert.ToInt32(dr[0]) + 1;

            conn.Close();

            return nextMemberID;
        }

        //ADD MEMBERS
        public void addMember()
        {
            int RenewalID = Renewals.getNextRenewalID();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "INSERT INTO GOLFMEMBERSLOG (MEMBERID, FIRSTNAME, LASTNAME, STREET, TOWN, COUNTY, MOBILE, EMAIL, MEMBERSTATUS, SIGNUPDATE, TYPEID, PAID) VALUES (" +
                this.memberID + ", '" + this.firstName + "', '" + this.lastName + "', '" + this.street + "', '" + this.town + "', '" + this.county + "', '" + this.mobile + "', '" + 
                this.email + "', '" + this.memberStatus + "', SYSDATE " + ", '" + this.typeID + "', 'n')";

            //Make a blank payment to allow the renewals to work
            String strSQL2 = "INSERT INTO RENEWALS(RENEWALID, MEMBERID, AMOUNTPAID, DATEPAID) VALUES('" + RenewalID + "','" + this.memberID + "'," + 0 + ",SYSDATE)";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleCommand cmd2 = new OracleCommand(strSQL2, conn);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            conn.Close();

        }

        //**************END ADD MEMBER************************************


        //**************View Member***************************************

        public static DataSet getMembers()
        {
            //define Sql Query
            String strSQL = "SELECT * FROM GOLFMEMBERSLOG";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getMembers(String sortOrder)
        {

            //define Sql Query
            String strSQL = "SELECT * FROM GOLFMEMBERSLOG ORDER BY " + sortOrder;

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

            //Close database connection
            conn.Close();

            return ds;

        }

        //**************End View Member***********************************

        //**************Update Members************************************

        public void getSingleMember(int ID)
        {

            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Open Database Connection
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM GOLFMEMBERSLOG WHERE MEMBERID = " + ID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Reader
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            //Instantiate Object Variables
            this.memberID = dr.GetInt32(0);
            this.firstName = dr.GetString(1);
            this.lastName = dr.GetString(2);
            this.street = dr.GetString(3);
            this.town = dr.GetString(4);
            this.county = dr.GetString(5);
            this.mobile = dr.GetString(6);
            this.email = dr.GetString(7);
            this.memberStatus = dr.GetString(8);
            this.typeID = dr.GetString(10);
            this.paid = dr.GetString(11);
      
            conn.Close();

        }

        public static DataSet getSummaryMembers()
        {
            //define Sql Query
            String strSQL = "SELECT MEMBERID, FIRSTNAME, LASTNAME FROM GOLFMEMBERSLOG ORDER BY MEMBERID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getExpiredMembers()
        {
            var currentDate = DateTime.Now;
            var backDate = currentDate.AddYears(-1);
            String alterdate = backDate.ToString("dd-MMM-y"); 

            String strSQL= "SELECT m.MEMBERID, m.FIRSTNAME, m.LASTNAME, m.PAID, r.AMOUNTPAID, t.TYPEID, " +
                            "t.TYPENAME, t.TYPEPRICE " +
                            "FROM RENEWALS r " +
                            "INNER JOIN GOLFMEMBERSLOG m " +
                            "ON r.MEMBERID = m.MEMBERID " +
                            "INNER JOIN MEMBERTYPES t " +
                            "ON m.TYPEID = t.TYPEID " +
                            "WHERE m.SIGNUPDATE >= '" + alterdate + "' AND m.MEMBERSTATUS NOT LIKE 'Removed'"; 

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

           
            //Close database connection
            conn.Close();

            return ds;

        }
       
        public void updateMember()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Open Database Connection
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE GOLFMEMBERSLOG SET MEMBERID = " + this.memberID +
                            ", FIRSTNAME = '" + this.firstName +
                            "', LASTNAME = '" + this.lastName +
                            "', STREET = '" + this.street +
                            "', TOWN = '" + this.town +
                            "', COUNTY = '" + this.county +
                            "', MOBILE = '" + this.mobile +
                            "', EMAIL = '" + this.email +
                            "', MEMBERSTATUS = '" + this.memberStatus +
                            "', TYPEID = '" + this.typeID +
                            "', PAID = '" + this.paid +
                            "' WHERE MEMBERID = " + this.memberID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Database Connection
            conn.Close();
        }

        //**************End Update Members********************************

        //**************Start Remove Member********************************

        public static DataSet getNonRemovedMembers()
        {

            //define Sql Query
            String strSQL = "SELECT * FROM GOLFMEMBERSLOG WHERE MEMBERSTATUS != 'Removed'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

            //Close database connection
            conn.Close();

            return ds;

        }

        public void removeMember()
        {
            //Define Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Open Database Connection
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE GOLFMEMBERSLOG SET MEMBERID = " + this.memberID +
                            ", MEMBERSTATUS = '" + this.memberStatus +
                            "' WHERE MEMBERID = " + this.memberID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Database Connection
            conn.Close();
        }

        //**************End Remove Members********************************

        //*******BEGIN RECORD PAYMENT***************

        public static DataSet getMembersWithTypeID()
        {
            //define Sql Query
            String strSQL = "SELECT MEMBERID, FIRSTNAME, LASTNAME, TYPEID, PAID FROM GOLFMEMBERSLOG WHERE MEMBERSTATUS != 'Removed' ORDER BY MEMBERID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

            //Close database connection
            conn.Close();

            return ds;
        }

        public void updatePaidStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "UPDATE GOLFMEMBERSLOG SET PAID = 'y' WHERE MEMBERID = " + this.memberID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        //*******END RECORD PAYMENT****************


        //Get members from selected Type (used in frmMemberTypeAnalysis)
        public static DataSet getMembersFromType(String memID)
        {
            //define Sql Query
            String strSQL = "SELECT MEMBERID, FIRSTNAME, LASTNAME, MOBILE FROM GOLFMEMBERSLOG WHERE TYPEID = '" + memID + "'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GOLFMEMBERSLOG");

            //Close database connection
            conn.Close();

            return ds;
        }

        //Validate Email address for frmUpdateMember and frmAddMember
        public static bool validateEmail(String email)
        {
            if (Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))"+@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }else
            {
                return false;
            }
        }

        //Validate Text boxes for frmUpdateMember and frmAddMember
        public static bool validateTextBox(String textIn)
        {
            if(Regex.IsMatch(textIn, @"[A-Z][a-zA-Z\s\'-]*"))
            {
                return true;
            } else
            {
                return false;
            }
        }

    }

} //end Class
