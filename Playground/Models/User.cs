using System;
using SQLite;

namespace Playground.Models
{
    public class User
    {
       [PrimaryKey, AutoIncrement]
       public int Id
        {
            get;
            set;
        }
        public string firstName
        {
            get;
            set;
        }
        public string lastName
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public string primaryPosition
        {
            get;
            set;
        }
        public string secondaryPosition
        {
            get;
            set;
        }
        public string hittingSide
        {
            get;
            set;
        }
        public string zipCode
        {
            get;
            set;
        }
        public string school
        {
            get;
            set;
        }
    }
}
