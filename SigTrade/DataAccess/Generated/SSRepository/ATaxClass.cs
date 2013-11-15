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
	/// Strongly-typed collection for the ATaxClass class.
	/// </summary>
    [Serializable]
	public partial class ATaxClassCollection : RepositoryList<ATaxClass, ATaxClassCollection>
	{	   
		public ATaxClassCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ATaxClassCollection</returns>
		public ATaxClassCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ATaxClass o = this[i];
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
	/// This is an ActiveRecord class which wraps the ATaxClass table.
	/// </summary>
	[Serializable]
	public partial class ATaxClass : RepositoryRecord<ATaxClass>, IRecordBase
	{
		#region .ctors and Default Settings
		
		public ATaxClass()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ATaxClass(bool useDatabaseDefaults)
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
				TableSchema.Table schema = new TableSchema.Table("ATaxClass", TableType.Table, DataService.GetInstance("SSRepository"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarClaRecID = new TableSchema.TableColumn(schema);
				colvarClaRecID.ColumnName = "ClaRecID";
				colvarClaRecID.DataType = DbType.Int32;
				colvarClaRecID.MaxLength = 0;
				colvarClaRecID.AutoIncrement = false;
				colvarClaRecID.IsNullable = false;
				colvarClaRecID.IsPrimaryKey = true;
				colvarClaRecID.IsForeignKey = false;
				colvarClaRecID.IsReadOnly = false;
				colvarClaRecID.DefaultSetting = @"";
				colvarClaRecID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaRecID);
				
				TableSchema.TableColumn colvarClaPhyRecID = new TableSchema.TableColumn(schema);
				colvarClaPhyRecID.ColumnName = "ClaPhyRecID";
				colvarClaPhyRecID.DataType = DbType.Int32;
				colvarClaPhyRecID.MaxLength = 0;
				colvarClaPhyRecID.AutoIncrement = false;
				colvarClaPhyRecID.IsNullable = true;
				colvarClaPhyRecID.IsPrimaryKey = false;
				colvarClaPhyRecID.IsForeignKey = false;
				colvarClaPhyRecID.IsReadOnly = false;
				colvarClaPhyRecID.DefaultSetting = @"";
				colvarClaPhyRecID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaPhyRecID);
				
				TableSchema.TableColumn colvarClaName = new TableSchema.TableColumn(schema);
				colvarClaName.ColumnName = "ClaName";
				colvarClaName.DataType = DbType.String;
				colvarClaName.MaxLength = 30;
				colvarClaName.AutoIncrement = false;
				colvarClaName.IsNullable = true;
				colvarClaName.IsPrimaryKey = false;
				colvarClaName.IsForeignKey = false;
				colvarClaName.IsReadOnly = false;
				colvarClaName.DefaultSetting = @"";
				colvarClaName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaName);
				
				TableSchema.TableColumn colvarClaRecStatus = new TableSchema.TableColumn(schema);
				colvarClaRecStatus.ColumnName = "ClaRecStatus";
				colvarClaRecStatus.DataType = DbType.String;
				colvarClaRecStatus.MaxLength = 1;
				colvarClaRecStatus.AutoIncrement = false;
				colvarClaRecStatus.IsNullable = true;
				colvarClaRecStatus.IsPrimaryKey = false;
				colvarClaRecStatus.IsForeignKey = false;
				colvarClaRecStatus.IsReadOnly = false;
				colvarClaRecStatus.DefaultSetting = @"";
				colvarClaRecStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaRecStatus);
				
				TableSchema.TableColumn colvarClaGroup = new TableSchema.TableColumn(schema);
				colvarClaGroup.ColumnName = "ClaGroup";
				colvarClaGroup.DataType = DbType.String;
				colvarClaGroup.MaxLength = 50;
				colvarClaGroup.AutoIncrement = false;
				colvarClaGroup.IsNullable = true;
				colvarClaGroup.IsPrimaryKey = false;
				colvarClaGroup.IsForeignKey = false;
				colvarClaGroup.IsReadOnly = false;
				colvarClaGroup.DefaultSetting = @"";
				colvarClaGroup.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaGroup);
				
				TableSchema.TableColumn colvarClaOrder = new TableSchema.TableColumn(schema);
				colvarClaOrder.ColumnName = "ClaOrder";
				colvarClaOrder.DataType = DbType.Int32;
				colvarClaOrder.MaxLength = 0;
				colvarClaOrder.AutoIncrement = false;
				colvarClaOrder.IsNullable = true;
				colvarClaOrder.IsPrimaryKey = false;
				colvarClaOrder.IsForeignKey = false;
				colvarClaOrder.IsReadOnly = false;
				colvarClaOrder.DefaultSetting = @"";
				colvarClaOrder.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaOrder);
				
				TableSchema.TableColumn colvarClaAdded = new TableSchema.TableColumn(schema);
				colvarClaAdded.ColumnName = "ClaAdded";
				colvarClaAdded.DataType = DbType.DateTime;
				colvarClaAdded.MaxLength = 0;
				colvarClaAdded.AutoIncrement = false;
				colvarClaAdded.IsNullable = true;
				colvarClaAdded.IsPrimaryKey = false;
				colvarClaAdded.IsForeignKey = false;
				colvarClaAdded.IsReadOnly = false;
				colvarClaAdded.DefaultSetting = @"";
				colvarClaAdded.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaAdded);
				
				TableSchema.TableColumn colvarClaModified = new TableSchema.TableColumn(schema);
				colvarClaModified.ColumnName = "ClaModified";
				colvarClaModified.DataType = DbType.DateTime;
				colvarClaModified.MaxLength = 0;
				colvarClaModified.AutoIncrement = false;
				colvarClaModified.IsNullable = true;
				colvarClaModified.IsPrimaryKey = false;
				colvarClaModified.IsForeignKey = false;
				colvarClaModified.IsReadOnly = false;
				colvarClaModified.DefaultSetting = @"";
				colvarClaModified.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaModified);
				
				TableSchema.TableColumn colvarClaByWho = new TableSchema.TableColumn(schema);
				colvarClaByWho.ColumnName = "ClaByWho";
				colvarClaByWho.DataType = DbType.Int32;
				colvarClaByWho.MaxLength = 0;
				colvarClaByWho.AutoIncrement = false;
				colvarClaByWho.IsNullable = true;
				colvarClaByWho.IsPrimaryKey = false;
				colvarClaByWho.IsForeignKey = false;
				colvarClaByWho.IsReadOnly = false;
				colvarClaByWho.DefaultSetting = @"";
				colvarClaByWho.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClaByWho);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SSRepository"].AddSchema("ATaxClass",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ClaRecID")]
		[Bindable(true)]
		public int ClaRecID 
		{
			get { return GetColumnValue<int>(Columns.ClaRecID); }
			set { SetColumnValue(Columns.ClaRecID, value); }
		}
		  
		[XmlAttribute("ClaPhyRecID")]
		[Bindable(true)]
		public int? ClaPhyRecID 
		{
			get { return GetColumnValue<int?>(Columns.ClaPhyRecID); }
			set { SetColumnValue(Columns.ClaPhyRecID, value); }
		}
		  
		[XmlAttribute("ClaName")]
		[Bindable(true)]
		public string ClaName 
		{
			get { return GetColumnValue<string>(Columns.ClaName); }
			set { SetColumnValue(Columns.ClaName, value); }
		}
		  
		[XmlAttribute("ClaRecStatus")]
		[Bindable(true)]
		public string ClaRecStatus 
		{
			get { return GetColumnValue<string>(Columns.ClaRecStatus); }
			set { SetColumnValue(Columns.ClaRecStatus, value); }
		}
		  
		[XmlAttribute("ClaGroup")]
		[Bindable(true)]
		public string ClaGroup 
		{
			get { return GetColumnValue<string>(Columns.ClaGroup); }
			set { SetColumnValue(Columns.ClaGroup, value); }
		}
		  
		[XmlAttribute("ClaOrder")]
		[Bindable(true)]
		public int? ClaOrder 
		{
			get { return GetColumnValue<int?>(Columns.ClaOrder); }
			set { SetColumnValue(Columns.ClaOrder, value); }
		}
		  
		[XmlAttribute("ClaAdded")]
		[Bindable(true)]
		public DateTime? ClaAdded 
		{
			get { return GetColumnValue<DateTime?>(Columns.ClaAdded); }
			set { SetColumnValue(Columns.ClaAdded, value); }
		}
		  
		[XmlAttribute("ClaModified")]
		[Bindable(true)]
		public DateTime? ClaModified 
		{
			get { return GetColumnValue<DateTime?>(Columns.ClaModified); }
			set { SetColumnValue(Columns.ClaModified, value); }
		}
		  
		[XmlAttribute("ClaByWho")]
		[Bindable(true)]
		public int? ClaByWho 
		{
			get { return GetColumnValue<int?>(Columns.ClaByWho); }
			set { SetColumnValue(Columns.ClaByWho, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ClaRecIDColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaPhyRecIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaRecStatusColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaGroupColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaOrderColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaAddedColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaModifiedColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ClaByWhoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ClaRecID = @"ClaRecID";
			 public static string ClaPhyRecID = @"ClaPhyRecID";
			 public static string ClaName = @"ClaName";
			 public static string ClaRecStatus = @"ClaRecStatus";
			 public static string ClaGroup = @"ClaGroup";
			 public static string ClaOrder = @"ClaOrder";
			 public static string ClaAdded = @"ClaAdded";
			 public static string ClaModified = @"ClaModified";
			 public static string ClaByWho = @"ClaByWho";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}