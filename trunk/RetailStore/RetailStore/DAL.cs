using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using RetailStore.Crystal_Reports;

namespace RetailStore
{
    class DAL
    {

        private static string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../Retailstore.mdb;Persist Security Info=False";
        
        public DataTable executeSelectStmt(string q){
            /*
             This function is used to execute select statements and return set of results back as DataTable
             */
            OleDbConnection conn = new OleDbConnection(connectionString);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(q, conn);
                OleDbDataAdapter adptr = new OleDbDataAdapter(cmd);
                adptr.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return table;
        }

        public void executeNonSelectStmt(string q){
            OleDbConnection conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(q, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void loadTableIntoGrid(string tableName, DataGridView dgv){
            /*
             This function is used to load a table into grid
             */
            string q = string.Format("SELECT * FROM {0}", tableName);
            DataTable results = this.executeSelectStmt(q);
            dgv.DataSource = results;
        }

        public void loadTableIntoGrid(string tableName, string condFieldName, string condValue, DataGridView dgv) { 
            /*
             This function is used to load info from table with a filter criterial 
             */
            string q = string.Format("SELECT * FROM {0} WHERE {1}=\"{2}\"", tableName, condFieldName, condValue);
            DataTable results = this.executeSelectStmt(q);
            dgv.DataSource = results;
        }
        
        public DataTable findRecordsLike(string tableName, string fieldName, string valueLike){
            /*
             This function is used for auto-complete like features
             */
            string q = string.Format("SELECT * FROM {0} WHERE {1} LIKE \"%{2}%\"", tableName, fieldName, valueLike);
            return this.executeSelectStmt(q);
        }

        public DataTable findRecordsLike(string tableName, string condFieldName, string condVale, string fieldName, string valueLike) {
            /*
             This function is used for auto-complete like features with condition 
             */
            string q = string.Format("SELECT * FROM {0} WHERE {1}=\"{2}\" AND {3} LIKE \"%{4}%\"", tableName,condFieldName,condVale,fieldName,valueLike);
            return this.executeSelectStmt(q);
            
        }

        public void loadTablesJoinIntoGrid(string tableName1, string tableName2, string field1, string field2, DataGridView dgv){
            /**
             * This function is used to load a join into datagrid view
             * **/
            string q = string.Format("SELECT * FROM {0} INNER JOIN {1} ON {0}.{2} = {1}.{3}", tableName1, tableName2, field1, field2);
            dgv.DataSource = this.executeSelectStmt(q);
        }

        public void addEntityInfo(string ID, string name, string phone, string email, string role){
            string q = string.Format("INSERT INTO Entity (ID,Name,Phone,Email,Role) VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")", ID, name, phone, email, role);
            this.executeNonSelectStmt(q);
        }

        public void addEntityAddress(string EntityID,string line1,string line2,string line3,string city,string pincode,string state,string country) {
            string q = string.Format("INSERT INTO Address (Entity_ID,Line1,Line2,Line3,City,Pincode,State,Country) VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",{5},\"{6}\",\"{7}\")", EntityID, line1, line2, line3, city, pincode, state, country);
            this.executeNonSelectStmt(q);
        }
        
        public string autoGenerateID(string tableName, string colName, string role)
        {
            string q;
            if (colName.CompareTo("ID")==0)
            {
                q = string.Format("SELECT COUNT(ID) FROM Entity WHERE Role=\"{0}\"", role);
            }
            else
            {
                q = string.Format("SELECT COUNT({0}) FROM {1}",colName,tableName);
            }

            DataTable result = this.executeSelectStmt(q);
            int rows = int.Parse(result.Rows[0][0].ToString());
            string nextID = "";
            switch (role)
                {
                    case "Vendor":
                        nextID = "V-";
                        break;
                    case "Customer":
                        nextID = "C-";
                        break;
                    case "Employee":
                        nextID = "E-";
                        break;
                    case "Product":
                        nextID = "P-";
                        break;
                    case "PO":
                        nextID = "PO-";
                        break;  
                    case "SO":
                        nextID = "SO-";
                        break;
                    case "WH":
                        nextID = "WH-";
                        break;  
                    default:
                        break;
                }
            if(rows<10)
            {
                nextID=nextID+"000"+(rows+1);
            }
            else if (rows < 100)
            {
                nextID = nextID + "00" + (rows + 1);
            }
            else if (rows < 1000)
            {
                nextID = nextID + "0" + (rows + 1);
            }
            else if (rows < 10000)
            {
                nextID = nextID +(rows + 1);
            }
            return nextID;
        }
        
        public void addProductDetails(string id,string name,string description,string attributes)
        {
            /*
                This function adds records into Product_Details table 
            */ 
            string q = string.Format("INSERT INTO Product_Details(Product_ID,Name,description,Attributes) VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\")",id,name,description,attributes);
            this.executeNonSelectStmt(q);
        }

        public void addProductPricelist(string id,string purchaseprice,string sellingprice,DateTime updated)
        {
            /*
                This function adds records into Product_Pricelist table 
            */ 
            string q = string.Format("INSERT INTO Product_Pricelist(Product_ID,Purchase_Price,Sales_Price,Updated) VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\")",id,purchaseprice,sellingprice,updated);
            this.executeNonSelectStmt(q);
        }

        public void addProductStock(string id,string warehouseid,string qty,string reorderlevel,string reorderqty,string status)
        {
            /*
                This function adds records into Product_Stock table 
            */ 
            string q = string.Format("INSERT INTO Product_Stock(Product_ID,WH_ID,Current_Qty,Reorder_Level,Reorder_Qty,Status) VALUES(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\")",id,warehouseid,qty,reorderlevel,reorderqty,status);
            this.executeNonSelectStmt(q);
        }

        public void addWarehouseDetails(string wh_id, string name, string contact, string capacity)
        {
            /*
                This function adds records into Warehouse_Details table 
            */ 
            string q = string.Format("INSERT INTO WH_Details (WH_ID,Name,Contact,Capacity) VALUES (\"{0}\",\"{1}\",\"{2}\",\"{3}\")", wh_id, name, contact, capacity);
            this.executeNonSelectStmt(q);
        }

        public DataTable dataStock()
        {
            /*
                This function get records from Product_Stock table
            */ 
            string q = string.Format("SELECT * FROM Product_Stock");
            return this.executeSelectStmt(q);    
        }

        public DataTable dataPurchase()
        {
            /*
                This function get records from Purchase tables
            */
            string q = string.Format("SELECT  porders_details.po_id,porders_details.vendor_id,porders_items.product_id,porders_items.qty,porders_items.price,porders_details.total,porder_history.po_date FROM porders_details,porders_items,porder_history WHERE (porders_details.po_id=porders_items.po_id) AND (porders_details.po_id=porder_history.po_id)");
            return this.executeSelectStmt(q);
        }

        public DataTable dataProduct()
        {
            /*
                This function get records from Product tables
            */
            string q = string.Format("SELECT product_details.product_id,product_details.name,product_details.description,product_pricelist.purchase_price,product_pricelist.sales_price FROM product_details,product_pricelist WHERE(product_details.product_id=product_pricelist.product_id)");
            return this.executeSelectStmt(q);
        }

        public DataTable dataVendorsCustomers(string role)
        {
            /*
                This function get records from address and entity table for vendors and customers
            */
            string q = string.Format("SELECT entity.id,entity.name,entity.phone,entity.email,address.line1,address.city,address.pincode FROM entity,address WHERE (entity.id=address.entity_id) AND (entity.role='"+role+"')");
            return this.executeSelectStmt(q);
        }
       
        public DataTable dataWarehouse()
        {
            /*
                This function get records from warehouse and address table
            */
            string q = string.Format("SELECT wh_details.wh_id,wh_details.name,wh_details.contact,wh_details.capacity,address.line1,address.city,address.pincode FROM wh_details,address WHERE (wh_details.wh_id=address.entity_id)");
            return this.executeSelectStmt(q);
        }

        public DataTable dataSales()
        {
            /*
               This function get records from Sales tables
           */
            string q = string.Format("SELECT  sorders_details.so_id,sorders_details.cust_id,sorders_items.product_id,sorders_items.qty,sorders_items.price,sorders_details.total,sorder_history.so_date FROM sorders_details,sorders_items,sorder_history WHERE (sorders_details.so_id=sorders_items.so_id) AND (sorders_details.so_id=sorder_history.so_id)");
            return this.executeSelectStmt(q);
        }

        public DataTable populateCombo(string tablename, string columname)
        {
            /*
              This function fills combobox with data
          */
            string q = string.Format("SELECT {0} FROM {1}", columname, tablename);
            return this.executeSelectStmt(q);
        }

        public DataTable findRecords(string tableName, string columnName, string condCol, string condText)
        {
            /*
              This function fills combobox with data
          */
            string q = string.Format("SELECT {0} FROM {1} WHERE {2}='{3}'", columnName, tableName, condCol, condText);
            return this.executeSelectStmt(q);
        }

        public void loadTablesJoinIntoGrid(string tableName1, string tableName2, string colName1, string colName2, string field1, string valueLike1, string field2, string valueLike2, string field3, string valueLike3, DataGridView dgv)
        {
            // Loads The DATAGRIDVIEW by Filtering the DATAGRIDVIEW Data according valueLike arguments
            string q = string.Format("SELECT * FROM {0} INNER JOIN {1} ON {0}.{2} = {1}.{3} WHERE {0}.{4} LIKE \"%{5}%\" AND {0}.{6} LIKE \"%{7}%\"  AND {1}.{8} LIKE \"%{9}%\"  ", tableName1, tableName2, colName1, colName2, field1, valueLike1, field2, valueLike2, field3, valueLike3);
            dgv.DataSource = this.executeSelectStmt(q);
        }
    }

}
