﻿using Foundation;
using MyFirstProject.Models;
using MyFirstProject.Patterns.Repositories;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(MyFirstProject.iOS.SQLiteIOS))]
namespace MyFirstProject.iOS
{
    public class SQLiteIOS : ISQLite
    {
        SQLiteConnection con;

        public SQLiteConnection GetConnectionWithCreateDatabase()
        {
            string fileName = "Vacation.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentPath, fileName);
            con = new SQLiteConnection(path);
            con.CreateTable<Vacation>();

            return con;
        }

        public List<Vacation> GetVacation()
        {
            string sql = "SELECT * FROM Vacation";
            List<Vacation> vacations = con.Query<Vacation>(sql);
            return vacations;
        }

        public bool SaveVacation(Vacation vacation)
        {
            bool res = false;
            try
            {
                con.Insert(vacation);
                res = true;
            }
            catch
            {
                res = false;
            }
            return res;
        }

        public bool UpdateVacation(Vacation vacation)
        {
            bool res = false;
            try
            {
                //$ is short-hand for String.Format, used with
                //string interpolations (e.g. {0}).
                //Used in C# 6.0
                string sql = $"UPDATE Vacation " +
                             $"SET Country = '{vacation.Country}', " +
                             $"City = '{vacation.City}', " +
                             $"Visited = '{vacation.Visited}' " +
                             $"WHERE Id = {vacation.ID}";
                con.Execute(sql);
                res = true;
            }
            catch
            {

            }
            return res;
        }

        public void DeleteVacation(int Id)
        {
            string sql = $"DELETE FROM Vacation WHERE Id = {Id}";
            con.Execute(sql);
        }
    }
}