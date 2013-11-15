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
	/// Strongly-typed collection for the MessageLog class.
	/// </summary>
    [Serializable]
	public partial class MessageLogCollection : RepositoryList<MessageLog, MessageLogCollection>
	{	   
		public MessageLogCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MessageLogCollection</returns>
		public MessageLogCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MessageLog o = this[i];
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
	/// This is an ActiveRecord class which wraps the MessageLog table.
	/// </summary>
	[Serializable]
	public partial class MessageLog : RepositoryRecord<MessageLog>, IRecordBase
	{
		#region .ctors and Default Settings
		
		public MessageLog()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MessageLog(bool useDatabaseDefaults)
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
				TableSchema.Table schema = new TableSchema.Table("MessageLog", TableType.Table, DataService.GetInstance("SSRepository"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
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
				
				TableSchema.TableColumn colvarTitle = new TableSchema.TableColumn(schema);
				colvarTitle.ColumnName = "title";
				colvarTitle.DataType = DbType.AnsiString;
				colvarTitle.MaxLength = 255;
				colvarTitle.AutoIncrement = false;
				colvarTitle.IsNullable = false;
				colvarTitle.IsPrimaryKey = false;
				colvarTitle.IsForeignKey = false;
				colvarTitle.IsReadOnly = false;
				colvarTitle.DefaultSetting = @"";
				colvarTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTitle);
				
				TableSchema.TableColumn colvarBody = new TableSchema.TableColumn(schema);
				colvarBody.ColumnName = "body";
				colvarBody.DataType = DbType.AnsiString;
				colvarBody.MaxLength = 2147483647;
				colvarBody.AutoIncrement = false;
				colvarBody.IsNullable = false;
				colvarBody.IsPrimaryKey = false;
				colvarBody.IsForeignKey = false;
				colvarBody.IsReadOnly = false;
				colvarBody.DefaultSetting = @"";
				colvarBody.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBody);
				
				TableSchema.TableColumn colvarSentTo = new TableSchema.TableColumn(schema);
				colvarSentTo.ColumnName = "sent_to";
				colvarSentTo.DataType = DbType.AnsiString;
				colvarSentTo.MaxLength = 255;
				colvarSentTo.AutoIncrement = false;
				colvarSentTo.IsNullable = false;
				colvarSentTo.IsPrimaryKey = false;
				colvarSentTo.IsForeignKey = false;
				colvarSentTo.IsReadOnly = false;
				colvarSentTo.DefaultSetting = @"";
				colvarSentTo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSentTo);
				
				TableSchema.TableColumn colvarSentAt = new TableSchema.TableColumn(schema);
				colvarSentAt.ColumnName = "sent_at";
				colvarSentAt.DataType = DbType.DateTime;
				colvarSentAt.MaxLength = 0;
				colvarSentAt.AutoIncrement = false;
				colvarSentAt.IsNullable = false;
				colvarSentAt.IsPrimaryKey = false;
				colvarSentAt.IsForeignKey = false;
				colvarSentAt.IsReadOnly = false;
				colvarSentAt.DefaultSetting = @"";
				colvarSentAt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSentAt);
				
				TableSchema.TableColumn colvarDeleted = new TableSchema.TableColumn(schema);
				colvarDeleted.ColumnName = "Deleted";
				colvarDeleted.DataType = DbType.Boolean;
				colvarDeleted.MaxLength = 0;
				colvarDeleted.AutoIncrement = false;
				colvarDeleted.IsNullable = false;
				colvarDeleted.IsPrimaryKey = false;
				colvarDeleted.IsForeignKey = false;
				colvarDeleted.IsReadOnly = false;
				colvarDeleted.DefaultSetting = @"";
				colvarDeleted.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDeleted);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SSRepository"].AddSchema("MessageLog",schema);
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
		  
		[XmlAttribute("Title")]
		[Bindable(true)]
		public string Title 
		{
			get { return GetColumnValue<string>(Columns.Title); }
			set { SetColumnValue(Columns.Title, value); }
		}
		  
		[XmlAttribute("Body")]
		[Bindable(true)]
		public string Body 
		{
			get { return GetColumnValue<string>(Columns.Body); }
			set { SetColumnValue(Columns.Body, value); }
		}
		  
		[XmlAttribute("SentTo")]
		[Bindable(true)]
		public string SentTo 
		{
			get { return GetColumnValue<string>(Columns.SentTo); }
			set { SetColumnValue(Columns.SentTo, value); }
		}
		  
		[XmlAttribute("SentAt")]
		[Bindable(true)]
		public DateTime SentAt 
		{
			get { return GetColumnValue<DateTime>(Columns.SentAt); }
			set { SetColumnValue(Columns.SentAt, value); }
		}
		  
		[XmlAttribute("Deleted")]
		[Bindable(true)]
		public bool Deleted 
		{
			get { return GetColumnValue<bool>(Columns.Deleted); }
			set { SetColumnValue(Columns.Deleted, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TitleColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BodyColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SentToColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SentAtColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DeletedColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string Title = @"title";
			 public static string Body = @"body";
			 public static string SentTo = @"sent_to";
			 public static string SentAt = @"sent_at";
			 public static string Deleted = @"Deleted";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}