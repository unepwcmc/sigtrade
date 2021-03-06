using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace SignificantTradeSSRepository
{
	/// <summary>
	/// Strongly-typed collection for the ATaxPhylum class.
	/// </summary>
    [Serializable]
	public partial class ATaxPhylumCollection : RepositoryList<ATaxPhylum, ATaxPhylumCollection>
	{	   
		public ATaxPhylumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ATaxPhylumCollection</returns>
		public ATaxPhylumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ATaxPhylum o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the ATaxPhylum table.
	/// </summary>
	[Serializable]
	public partial class ATaxPhylum : RepositoryRecord<ATaxPhylum>, IRecordBase
	{
		#region .ctors and Default Settings
		
		public ATaxPhylum()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ATaxPhylum(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("ATaxPhylum", TableType.Table, DataService.GetInstance("SSRepository"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPhyRecID = new TableSchema.TableColumn(schema);
				colvarPhyRecID.ColumnName = "PhyRecID";
				colvarPhyRecID.DataType = DbType.Int32;
				colvarPhyRecID.MaxLength = 0;
				colvarPhyRecID.AutoIncrement = false;
				colvarPhyRecID.IsNullable = false;
				colvarPhyRecID.IsPrimaryKey = true;
				colvarPhyRecID.IsForeignKey = false;
				colvarPhyRecID.IsReadOnly = false;
				colvarPhyRecID.DefaultSetting = @"";
				colvarPhyRecID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyRecID);
				
				TableSchema.TableColumn colvarPhyName = new TableSchema.TableColumn(schema);
				colvarPhyName.ColumnName = "PhyName";
				colvarPhyName.DataType = DbType.String;
				colvarPhyName.MaxLength = 30;
				colvarPhyName.AutoIncrement = false;
				colvarPhyName.IsNullable = true;
				colvarPhyName.IsPrimaryKey = false;
				colvarPhyName.IsForeignKey = false;
				colvarPhyName.IsReadOnly = false;
				colvarPhyName.DefaultSetting = @"";
				colvarPhyName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyName);
				
				TableSchema.TableColumn colvarPhyKgmRecID = new TableSchema.TableColumn(schema);
				colvarPhyKgmRecID.ColumnName = "PhyKgmRecID";
				colvarPhyKgmRecID.DataType = DbType.Int32;
				colvarPhyKgmRecID.MaxLength = 0;
				colvarPhyKgmRecID.AutoIncrement = false;
				colvarPhyKgmRecID.IsNullable = true;
				colvarPhyKgmRecID.IsPrimaryKey = false;
				colvarPhyKgmRecID.IsForeignKey = false;
				colvarPhyKgmRecID.IsReadOnly = false;
				colvarPhyKgmRecID.DefaultSetting = @"";
				colvarPhyKgmRecID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyKgmRecID);
				
				TableSchema.TableColumn colvarPhyRecStatus = new TableSchema.TableColumn(schema);
				colvarPhyRecStatus.ColumnName = "PhyRecStatus";
				colvarPhyRecStatus.DataType = DbType.String;
				colvarPhyRecStatus.MaxLength = 1;
				colvarPhyRecStatus.AutoIncrement = false;
				colvarPhyRecStatus.IsNullable = true;
				colvarPhyRecStatus.IsPrimaryKey = false;
				colvarPhyRecStatus.IsForeignKey = false;
				colvarPhyRecStatus.IsReadOnly = false;
				colvarPhyRecStatus.DefaultSetting = @"";
				colvarPhyRecStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyRecStatus);
				
				TableSchema.TableColumn colvarPhyOrder = new TableSchema.TableColumn(schema);
				colvarPhyOrder.ColumnName = "PhyOrder";
				colvarPhyOrder.DataType = DbType.Int32;
				colvarPhyOrder.MaxLength = 0;
				colvarPhyOrder.AutoIncrement = false;
				colvarPhyOrder.IsNullable = true;
				colvarPhyOrder.IsPrimaryKey = false;
				colvarPhyOrder.IsForeignKey = false;
				colvarPhyOrder.IsReadOnly = false;
				colvarPhyOrder.DefaultSetting = @"";
				colvarPhyOrder.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyOrder);
				
				TableSchema.TableColumn colvarPhyAdded = new TableSchema.TableColumn(schema);
				colvarPhyAdded.ColumnName = "PhyAdded";
				colvarPhyAdded.DataType = DbType.DateTime;
				colvarPhyAdded.MaxLength = 0;
				colvarPhyAdded.AutoIncrement = false;
				colvarPhyAdded.IsNullable = true;
				colvarPhyAdded.IsPrimaryKey = false;
				colvarPhyAdded.IsForeignKey = false;
				colvarPhyAdded.IsReadOnly = false;
				colvarPhyAdded.DefaultSetting = @"";
				colvarPhyAdded.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyAdded);
				
				TableSchema.TableColumn colvarPhyModified = new TableSchema.TableColumn(schema);
				colvarPhyModified.ColumnName = "PhyModified";
				colvarPhyModified.DataType = DbType.DateTime;
				colvarPhyModified.MaxLength = 0;
				colvarPhyModified.AutoIncrement = false;
				colvarPhyModified.IsNullable = true;
				colvarPhyModified.IsPrimaryKey = false;
				colvarPhyModified.IsForeignKey = false;
				colvarPhyModified.IsReadOnly = false;
				colvarPhyModified.DefaultSetting = @"";
				colvarPhyModified.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyModified);
				
				TableSchema.TableColumn colvarPhyByWho = new TableSchema.TableColumn(schema);
				colvarPhyByWho.ColumnName = "PhyByWho";
				colvarPhyByWho.DataType = DbType.Int32;
				colvarPhyByWho.MaxLength = 0;
				colvarPhyByWho.AutoIncrement = false;
				colvarPhyByWho.IsNullable = true;
				colvarPhyByWho.IsPrimaryKey = false;
				colvarPhyByWho.IsForeignKey = false;
				colvarPhyByWho.IsReadOnly = false;
				colvarPhyByWho.DefaultSetting = @"";
				colvarPhyByWho.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyByWho);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SSRepository"].AddSchema("ATaxPhylum",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("PhyRecID")]
		[Bindable(true)]
		public int PhyRecID 
		{
			get { return GetColumnValue<int>(Columns.PhyRecID); }
			set { SetColumnValue(Columns.PhyRecID, value); }
		}
		  
		[XmlAttribute("PhyName")]
		[Bindable(true)]
		public string PhyName 
		{
			get { return GetColumnValue<string>(Columns.PhyName); }
			set { SetColumnValue(Columns.PhyName, value); }
		}
		  
		[XmlAttribute("PhyKgmRecID")]
		[Bindable(true)]
		public int? PhyKgmRecID 
		{
			get { return GetColumnValue<int?>(Columns.PhyKgmRecID); }
			set { SetColumnValue(Columns.PhyKgmRecID, value); }
		}
		  
		[XmlAttribute("PhyRecStatus")]
		[Bindable(true)]
		public string PhyRecStatus 
		{
			get { return GetColumnValue<string>(Columns.PhyRecStatus); }
			set { SetColumnValue(Columns.PhyRecStatus, value); }
		}
		  
		[XmlAttribute("PhyOrder")]
		[Bindable(true)]
		public int? PhyOrder 
		{
			get { return GetColumnValue<int?>(Columns.PhyOrder); }
			set { SetColumnValue(Columns.PhyOrder, value); }
		}
		  
		[XmlAttribute("PhyAdded")]
		[Bindable(true)]
		public DateTime? PhyAdded 
		{
			get { return GetColumnValue<DateTime?>(Columns.PhyAdded); }
			set { SetColumnValue(Columns.PhyAdded, value); }
		}
		  
		[XmlAttribute("PhyModified")]
		[Bindable(true)]
		public DateTime? PhyModified 
		{
			get { return GetColumnValue<DateTime?>(Columns.PhyModified); }
			set { SetColumnValue(Columns.PhyModified, value); }
		}
		  
		[XmlAttribute("PhyByWho")]
		[Bindable(true)]
		public int? PhyByWho 
		{
			get { return GetColumnValue<int?>(Columns.PhyByWho); }
			set { SetColumnValue(Columns.PhyByWho, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PhyRecIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyKgmRecIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyRecStatusColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyOrderColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyAddedColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyModifiedColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyByWhoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string PhyRecID = @"PhyRecID";
			 public static string PhyName = @"PhyName";
			 public static string PhyKgmRecID = @"PhyKgmRecID";
			 public static string PhyRecStatus = @"PhyRecStatus";
			 public static string PhyOrder = @"PhyOrder";
			 public static string PhyAdded = @"PhyAdded";
			 public static string PhyModified = @"PhyModified";
			 public static string PhyByWho = @"PhyByWho";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
