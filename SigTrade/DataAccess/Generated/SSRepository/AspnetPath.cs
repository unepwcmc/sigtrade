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
	/// Strongly-typed collection for the AspnetPath class.
	/// </summary>
    [Serializable]
	public partial class AspnetPathCollection : RepositoryList<AspnetPath, AspnetPathCollection>
	{	   
		public AspnetPathCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AspnetPathCollection</returns>
		public AspnetPathCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AspnetPath o = this[i];
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
	/// This is an ActiveRecord class which wraps the aspnet_Paths table.
	/// </summary>
	[Serializable]
	public partial class AspnetPath : RepositoryRecord<AspnetPath>, IRecordBase
	{
		#region .ctors and Default Settings
		
		public AspnetPath()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AspnetPath(bool useDatabaseDefaults)
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
				TableSchema.Table schema = new TableSchema.Table("aspnet_Paths", TableType.Table, DataService.GetInstance("SSRepository"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarApplicationId = new TableSchema.TableColumn(schema);
				colvarApplicationId.ColumnName = "ApplicationId";
				colvarApplicationId.DataType = DbType.Guid;
				colvarApplicationId.MaxLength = 0;
				colvarApplicationId.AutoIncrement = false;
				colvarApplicationId.IsNullable = false;
				colvarApplicationId.IsPrimaryKey = false;
				colvarApplicationId.IsForeignKey = true;
				colvarApplicationId.IsReadOnly = false;
				colvarApplicationId.DefaultSetting = @"";
				
					colvarApplicationId.ForeignKeyTableName = "aspnet_Applications";
				schema.Columns.Add(colvarApplicationId);
				
				TableSchema.TableColumn colvarPathId = new TableSchema.TableColumn(schema);
				colvarPathId.ColumnName = "PathId";
				colvarPathId.DataType = DbType.Guid;
				colvarPathId.MaxLength = 0;
				colvarPathId.AutoIncrement = false;
				colvarPathId.IsNullable = false;
				colvarPathId.IsPrimaryKey = true;
				colvarPathId.IsForeignKey = false;
				colvarPathId.IsReadOnly = false;
				
						colvarPathId.DefaultSetting = @"(newid())";
				colvarPathId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPathId);
				
				TableSchema.TableColumn colvarPath = new TableSchema.TableColumn(schema);
				colvarPath.ColumnName = "Path";
				colvarPath.DataType = DbType.String;
				colvarPath.MaxLength = 256;
				colvarPath.AutoIncrement = false;
				colvarPath.IsNullable = false;
				colvarPath.IsPrimaryKey = false;
				colvarPath.IsForeignKey = false;
				colvarPath.IsReadOnly = false;
				colvarPath.DefaultSetting = @"";
				colvarPath.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPath);
				
				TableSchema.TableColumn colvarLoweredPath = new TableSchema.TableColumn(schema);
				colvarLoweredPath.ColumnName = "LoweredPath";
				colvarLoweredPath.DataType = DbType.String;
				colvarLoweredPath.MaxLength = 256;
				colvarLoweredPath.AutoIncrement = false;
				colvarLoweredPath.IsNullable = false;
				colvarLoweredPath.IsPrimaryKey = false;
				colvarLoweredPath.IsForeignKey = false;
				colvarLoweredPath.IsReadOnly = false;
				colvarLoweredPath.DefaultSetting = @"";
				colvarLoweredPath.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLoweredPath);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SSRepository"].AddSchema("aspnet_Paths",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ApplicationId")]
		[Bindable(true)]
		public Guid ApplicationId 
		{
			get { return GetColumnValue<Guid>(Columns.ApplicationId); }
			set { SetColumnValue(Columns.ApplicationId, value); }
		}
		  
		[XmlAttribute("PathId")]
		[Bindable(true)]
		public Guid PathId 
		{
			get { return GetColumnValue<Guid>(Columns.PathId); }
			set { SetColumnValue(Columns.PathId, value); }
		}
		  
		[XmlAttribute("Path")]
		[Bindable(true)]
		public string Path 
		{
			get { return GetColumnValue<string>(Columns.Path); }
			set { SetColumnValue(Columns.Path, value); }
		}
		  
		[XmlAttribute("LoweredPath")]
		[Bindable(true)]
		public string LoweredPath 
		{
			get { return GetColumnValue<string>(Columns.LoweredPath); }
			set { SetColumnValue(Columns.LoweredPath, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (1)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ApplicationIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PathIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PathColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn LoweredPathColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ApplicationId = @"ApplicationId";
			 public static string PathId = @"PathId";
			 public static string Path = @"Path";
			 public static string LoweredPath = @"LoweredPath";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}