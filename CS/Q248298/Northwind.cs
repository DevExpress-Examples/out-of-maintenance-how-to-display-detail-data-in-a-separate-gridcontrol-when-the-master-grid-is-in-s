using System;
using DevExpress.Xpo;

namespace Northwind {

    public class Categories : XPBaseObject {
        int fCategoryID;
        [Key(true)]
        public int CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<int>("CategoryID", ref fCategoryID, value); }
        }
        string fCategoryName;
        [Size(15)]
        public string CategoryName {
            get { return fCategoryName; }
            set { SetPropertyValue<string>("CategoryName", ref fCategoryName, value); }
        }
        [Association("Category-Products", typeof(Products))]
        public XPCollection<Products> Products { get { return GetCollection<Products>("Products"); } }
        public Categories(Session session) : base(session) { }
        public Categories() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Products : XPLiteObject {
        int fProductID;
        [Key(true)]
        public int ProductID {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        Categories fCategoryID;
        [Association("Category-Products")]
        public Categories CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<Categories>("CategoryID", ref fCategoryID, value); }
        }
        public Products(Session session) : base(session) { }
        public Products() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
