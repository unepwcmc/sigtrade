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
namespace SignificantTradeSS
{
	/// <summary>
	/// Strongly-typed collection for the AGenu class.
	/// </summary>
    [Serializable]
	public partial class AGenuCollection : ActiveList<AGenu, AGenuCollection>
	{	   
		public AGenuCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AGenuCollection</returns>
		public AGenuCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AGenu o = this[i];
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
	/// This is an ActiveRecord class which wraps the AGenus table.
	/// </summary>
	[Serializable]
	public partial class AGenu : ActiveRecord<AGenu>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AGenu()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AGenu(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AGenu(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AGenu(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
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
				TableSchema.Table schema = new TableSchema.Table("AGenus", TableType.Table, DataService.GetInstance("SignificantTradeSS"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarGenRecID = new TableSchema.TableColumn(schema);
				colvarGenRecID.ColumnName = "GenRecID";
				colvarGenRecID.DataType = DbType.Int32;
				colvarGenRecID.MaxLength = 0;
				colvarGenRecID.AutoIncrement = false;
				colvarGenRecID.IsNullable = true;
				colvarGenRecID.IsPrimaryKey = false;
				colvarGenRecID.IsForeignKey = false;
				colvarGenRecID.IsReadOnly = false;
				colvarGenRecID.DefaultSetting = @"";
				colvarGenRecID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenRecID);
				
				TableSchema.TableColumn colvarGenFamRecID = new TableSchema.TableColumn(schema);
				colvarGenFamRecID.ColumnName = "GenFamRecID";
				colvarGenFamRecID.DataType = DbType.Int32;
				colvarGenFamRecID.MaxLength = 0;
				colvarGenFamRecID.AutoIncrement = false;
				colvarGenFamRecID.IsNullable = true;
				colvarGenFamRecID.IsPrimaryKey = false;
				colvarGenFamRecID.IsForeignKey = false;
				colvarGenFamRecID.IsReadOnly = false;
				colvarGenFamRecID.DefaultSetting = @"";
				colvarGenFamRecID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenFamRecID);
				
				TableSchema.TableColumn colvarGenName = new TableSchema.TableColumn(schema);
				colvarGenName.ColumnName = "GenName";
				colvarGenName.DataType = DbType.String;
				colvarGenName.MaxLength = 50;
				colvarGenName.AutoIncrement = false;
				colvarGenName.IsNullable = true;
				colvarGenName.IsPrimaryKey = false;
				colvarGenName.IsForeignKey = false;
				colvarGenName.IsReadOnly = false;
				colvarGenName.DefaultSetting = @"";
				colvarGenName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenName);
				
				TableSchema.TableColumn colvarGenAuthor = new TableSchema.TableColumn(schema);
				colvarGenAuthor.ColumnName = "GenAuthor";
				colvarGenAuthor.DataType = DbType.String;
				colvarGenAuthor.MaxLength = 50;
				colvarGenAuthor.AutoIncrement = false;
				colvarGenAuthor.IsNullable = true;
				colvarGenAuthor.IsPrimaryKey = false;
				colvarGenAuthor.IsForeignKey = false;
				colvarGenAuthor.IsReadOnly = false;
				colvarGenAuthor.DefaultSetting = @"";
				colvarGenAuthor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenAuthor);
				
				TableSchema.TableColumn colvarGenStatus = new TableSchema.TableColumn(schema);
				colvarGenStatus.ColumnName = "GenStatus";
				colvarGenStatus.DataType = DbType.String;
				colvarGenStatus.MaxLength = 1;
				colvarGenStatus.AutoIncrement = false;
				colvarGenStatus.IsNullable = true;
				colvarGenStatus.IsPrimaryKey = false;
				colvarGenStatus.IsForeignKey = false;
				colvarGenStatus.IsReadOnly = false;
				colvarGenStatus.DefaultSetting = @"";
				colvarGenStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenStatus);
				
				TableSchema.TableColumn colvarGenNoSpecies = new TableSchema.TableColumn(schema);
				colvarGenNoSpecies.ColumnName = "GenNoSpecies";
				colvarGenNoSpecies.DataType = DbType.Int32;
				colvarGenNoSpecies.MaxLength = 0;
				colvarGenNoSpecies.AutoIncrement = false;
				colvarGenNoSpecies.IsNullable = true;
				colvarGenNoSpecies.IsPrimaryKey = false;
				colvarGenNoSpecies.IsForeignKey = false;
				colvarGenNoSpecies.IsReadOnly = false;
				colvarGenNoSpecies.DefaultSetting = @"";
				colvarGenNoSpecies.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenNoSpecies);
				
				TableSchema.TableColumn colvarGenAdded = new TableSchema.TableColumn(schema);
				colvarGenAdded.ColumnName = "GenAdded";
				colvarGenAdded.DataType = DbType.DateTime;
				colvarGenAdded.MaxLength = 0;
				colvarGenAdded.AutoIncrement = false;
				colvarGenAdded.IsNullable = true;
				colvarGenAdded.IsPrimaryKey = false;
				colvarGenAdded.IsForeignKey = false;
				colvarGenAdded.IsReadOnly = false;
				colvarGenAdded.DefaultSetting = @"";
				colvarGenAdded.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenAdded);
				
				TableSchema.TableColumn colvarGenModified = new TableSchema.TableColumn(schema);
				colvarGenModified.ColumnName = "GenModified";
				colvarGenModified.DataType = DbType.DateTime;
				colvarGenModified.MaxLength = 0;
				colvarGenModified.AutoIncrement = false;
				colvarGenModified.IsNullable = true;
				colvarGenModified.IsPrimaryKey = false;
				colvarGenModified.IsForeignKey = false;
				colvarGenModified.IsReadOnly = false;
				colvarGenModified.DefaultSetting = @"";
				colvarGenModified.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenModified);
				
				TableSchema.TableColumn colvarGenByWho = new TableSchema.TableColumn(schema);
				colvarGenByWho.ColumnName = "GenByWho";
				colvarGenByWho.DataType = DbType.Int32;
				colvarGenByWho.MaxLength = 0;
				colvarGenByWho.AutoIncrement = false;
				colvarGenByWho.IsNullable = true;
				colvarGenByWho.IsPrimaryKey = false;
				colvarGenByWho.IsForeignKey = false;
				colvarGenByWho.IsReadOnly = false;
				colvarGenByWho.DefaultSetting = @"";
				colvarGenByWho.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGenByWho);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SignificantTradeSS"].AddSchema("AGenus",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("GenRecID")]
		[Bindable(true)]
		public int? GenRecID 
		{
			get { return GetColumnValue<int?>(Columns.GenRecID); }
			set { SetColumnValue(Columns.GenRecID, value); }
		}
		  
		[XmlAttribute("GenFamRecID")]
		[Bindable(true)]
		public int? GenFamRecID 
		{
			get { return GetColumnValue<int?>(Columns.GenFamRecID); }
			set { SetColumnValue(Columns.GenFamRecID, value); }
		}
		  
		[XmlAttribute("GenName")]
		[Bindable(true)]
		public string GenName 
		{
			get { return GetColumnValue<string>(Columns.GenName); }
			set { SetColumnValue(Columns.GenName, value); }
		}
		  
		[XmlAttribute("GenAuthor")]
		[Bindable(true)]
		public string GenAuthor 
		{
			get { return GetColumnValue<string>(Columns.GenAuthor); }
			set { SetColumnValue(Columns.GenAuthor, value); }
		}
		  
		[XmlAttribute("GenStatus")]
		[Bindable(true)]
		public string GenStatus 
		{
			get { return GetColumnValue<string>(Columns.GenStatus); }
			set { SetColumnValue(Columns.GenStatus, value); }
		}
		  
		[XmlAttribute("GenNoSpecies")]
		[Bindable(true)]
		public int? GenNoSpecies 
		{
			get { return GetColumnValue<int?>(Columns.GenNoSpecies); }
			set { SetColumnValue(Columns.GenNoSpecies, value); }
		}
		  
		[XmlAttribute("GenAdded")]
		[Bindable(true)]
		public DateTime? GenAdded 
		{
			get { return GetColumnValue<DateTime?>(Columns.GenAdded); }
			set { SetColumnValue(Columns.GenAdded, value); }
		}
		  
		[XmlAttribute("GenModified")]
		[Bindable(true)]
		public DateTime? GenModified 
		{
			get { return GetColumnValue<DateTime?>(Columns.GenModified); }
			set { SetColumnValue(Columns.GenModified, value); }
		}
		  
		[XmlAttribute("GenByWho")]
		[Bindable(true)]
		public int? GenByWho 
		{
			get { return GetColumnValue<int?>(Columns.GenByWho); }
			set { SetColumnValue(Columns.GenByWho, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varGenRecID,int? varGenFamRecID,string varGenName,string varGenAuthor,string varGenStatus,int? varGenNoSpecies,DateTime? varGenAdded,DateTime? varGenModified,int? varGenByWho)
		{
			AGenu item = new AGenu();
			
			item.GenRecID = varGenRecID;
			
			item.GenFamRecID = varGenFamRecID;
			
			item.GenName = varGenName;
			
			item.GenAuthor = varGenAuthor;
			
			item.GenStatus = varGenStatus;
			
			item.GenNoSpecies = varGenNoSpecies;
			
			item.GenAdded = varGenAdded;
			
			item.GenModified = varGenModified;
			
			item.GenByWho = varGenByWho;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int? varGenRecID,int? varGenFamRecID,string varGenName,string varGenAuthor,string varGenStatus,int? varGenNoSpecies,DateTime? varGenAdded,DateTime? varGenModified,int? varGenByWho)
		{
			AGenu item = new AGenu();
			
				item.Id = varId;
			
				item.GenRecID = varGenRecID;
			
				item.GenFamRecID = varGenFamRecID;
			
				item.GenName = varGenName;
			
				item.GenAuthor = varGenAuthor;
			
				item.GenStatus = varGenStatus;
			
				item.GenNoSpecies = varGenNoSpecies;
			
				item.GenAdded = varGenAdded;
			
				item.GenModified = varGenModified;
			
				item.GenByWho = varGenByWho;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn GenRecIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn GenFamRecIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn GenNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn GenAuthorColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn GenStatusColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn GenNoSpeciesColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn GenAddedColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn GenModifiedColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn GenByWhoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string GenRecID = @"GenRecID";
			 public static string GenFamRecID = @"GenFamRecID";
			 public static string GenName = @"GenName";
			 public static string GenAuthor = @"GenAuthor";
			 public static string GenStatus = @"GenStatus";
			 public static string GenNoSpecies = @"GenNoSpecies";
			 public static string GenAdded = @"GenAdded";
			 public static string GenModified = @"GenModified";
			 public static string GenByWho = @"GenByWho";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
