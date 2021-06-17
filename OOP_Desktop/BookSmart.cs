using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Desktop
{
    public class BookSmart
    {
        public BookSmart(string query)
        {
            this.query = query + " ";
        }
        private string query;

        public string Query { get => query; set => query = value; }

        public List<string> Field()
        {
            List<string> main = new List<string>();
            int i = 3;
            while (i < Query.Length)
            {
                try
                {
                    if (Query[i - 1] == ' ' && Query[i] == 'a' && Query[i + 1] == 's' && Query[i + 2] == ' ')
                    {
                        int check = i + 2;
                        i -= 2;
                        string var = "";
                        while (Query[i] != ',' && Query[i] != ' ')
                        {
                            var += Query[i];
                            i--;
                        }
                        main.Add(ReverseString(var));
                        i = check;
                    }
                }
                catch(Exception a) { }
                i++;
            }    
            return main;
        }

        public string TableName()
        {
            return query.Substring(query.IndexOf("dbo."), query.Length - query.IndexOf("dbo."));
        }

        public string DeleteQuery(string value)
        {
            string txt = "Delete " + TableName() + " where " + Field()[0] + " = N'";

            return txt + value + "'";
        }
        public string EditQuery(string primary,string varible, string value)
        {
            return "UPDATE " + TableName() + " SET " + varible + " = N'" + value + "' Where " + Field()[0] + " = N'" + primary + "'";
        }

        public string SearchQuery(string txtbox)
        {
            string txt = Query + "Where ";
            string cmdlike = " like N'%%' or ";
            for (int i=0; i < Field().Count; i++)
            {
                txt += Field()[i] + cmdlike.Insert(9, txtbox);
            }
            txt = txt.Remove(txt.Length - 3, 3);
            return txt;

        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr); 
            return new string(arr);
        }

        public void TimKiem()
        {

        }
    }
}
