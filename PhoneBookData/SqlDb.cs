﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookModels;
using System.Data.SqlClient;


namespace PhoneBookData
{
    public class SqlDb
    {
        string connection = "Data Source =DESKTOP-ORNPSN0\\SQLEXPRESS; Initial Catalog = PhoneBookManagement; Integrated Security = True;";

        SqlConnection sqlConnection;

        public SqlDb()
        {
            sqlConnection = new SqlConnection(connection);
        }
        public List<Contacts> GetUsers()
        {
            string SELECT = "SELECT * FROM pbook";

            SqlCommand selcom = new SqlCommand(SELECT, sqlConnection);

            sqlConnection.Open();
            List<Contacts> cont = new List<Contacts>();

            SqlDataReader re = selcom.ExecuteReader();

            while (re.Read())
            {
                string name = re["Name"].ToString();
                string num = re["Number"].ToString();
                string em = re["Email"].ToString();
                string add = re["Address"].ToString();

                Contacts readContacts = new Contacts();
                readContacts.c_name = name;
                readContacts.c_num = num;
                readContacts.c_email = em;
                readContacts.c_add = add;

                cont.Add(readContacts);

            }
            sqlConnection.Close();

            return cont;
        }

        public int AddContact(string name, string num, string email, string add)
        {
            int success;

            string INSERT = "INSERT INTO pbook VALUES(@Name, @Number, @Email, @Address)";

            SqlCommand incom = new SqlCommand(INSERT, sqlConnection);

            incom.Parameters.AddWithValue("@Name", name);
            incom.Parameters.AddWithValue("@Number", num);
            incom.Parameters.AddWithValue("@Email", email);
            incom.Parameters.AddWithValue("@Address", add);
            sqlConnection.Open() ;

            success = incom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
        public int UpdateContact(string name, string num, string email, string add)
        {
            int success;

            string UPDATE = $"UPDATE pbook SET Number = @Number, Email = @Email, Address = @Address WHERE Name = @Name";

            SqlCommand upcom = new SqlCommand(UPDATE, sqlConnection);

            upcom.Parameters.AddWithValue("@Number", num);
            upcom.Parameters.AddWithValue("@Email",email);
            upcom.Parameters.AddWithValue("@Address", add);
            upcom.Parameters.AddWithValue("@Name", name);
            sqlConnection.Open();

            success = upcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }
        public int DeleteContact(string name)
        {
            int success;

            string DELETE = $"DELETE FROM pbook WHERE Name = @Name";
            SqlCommand delcom = new SqlCommand(DELETE, sqlConnection);
            sqlConnection.Open();

            delcom.Parameters.AddWithValue("@Name", name);

            success = delcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

    }
}
