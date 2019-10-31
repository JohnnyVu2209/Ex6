using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Book
    {
        private string Name;
        private Author[] Authors;
        private double _Price;
        private int _Qty ;
        //cach 2
        public Book(string name, Author[] authors,double price,int qty = 0)
        {
            this.Name = name;
            this.Authors = authors;
            this._Price = price;
            this._Qty = qty;
        }
        //cach 1 khong bi trung lap
        //public Book(string name, Author author,double price,int qty)
        //    :this(name,author,price)
        //{
        //    this.Qty = qty;
        //}
        public string GetName()
        {
            return Name;
        }
        public Author[] GetAuthors()
        {
            return this.Authors;
        }
        public double Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this._Price = value;
            }
        }
        public int Qty
        {
            get
            {
                return this._Qty;
            }
            set
            {
                this._Qty = value;
            }
        }
        public override string ToString()
        {
            string[] strAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
                strAuthors[i] = this.Authors[i].ToString();

            return String.Format("Book[name={0}, authors={{{1}}}, price ={2}, qty = {3}]",this.Name,String.Join(",",strAuthors),this._Price,this._Qty);
        }
        public string GetAuthorNames()
        {
            string[] strAuthorNames = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                strAuthorNames[i] = this.Authors[i].GetName();
            }
            return String.Join(",", strAuthorNames);
        }
        //public string GetAuthorName(){ return this.Authors.GetName(); }
        //public string GetAuthorEmail() { return this.Authors.Email; }
        //public char GetAuthorGender() { return this.Authors.GetGender(); }
    }
}
