﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace kurwa1
{
    /// <summary>
    /// Логика взаимодействия для SingInWindow.xaml
    /// </summary>
    public partial class SingInWindow : Window
    {
        public SingInWindow()
        {
            InitializeComponent();
            DataTable dtUser = ConnectToDatabase("SELECT * FROM [dbo].[users];");

        }
        private void CloseB_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinusB_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private DataTable ConnectToDatabase(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");

            try
            {
                SqlConnection sqlConnection = new SqlConnection("server=СЕМЬЯ-ПК;Trusted_Connection=Yes;DataBase=usersDatabase;");
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = selectSQL;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных.");
                return dataTable;
            };

        }

        private bool IsUserExists(DataTable dataTable, string username, string password)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (username == (string)dataTable.Rows[i][0])
                {
                    if (password == (string)dataTable.Rows[i][0])
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Неправильный пароль.");
                        return false;
                    }
                }
                else if (i < dataTable.Rows.Count)
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует.");
                    return false;
                }
            }

            return false;
        }
        /*
        private void Check(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;
            DataTable dtUser = ConnectToDatabase("SELECT * FROM [dbo].[users];");

            if(IsUserExists(dtUser, username, password))
            {
                MessageBox.Show("URAAAA");
            }
        }*/
    }
}
