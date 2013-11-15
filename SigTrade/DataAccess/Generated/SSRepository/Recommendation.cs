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
	/// Strongly-typed collection for the Recommendation class.
	/// </summary>
    [Serializable]
	public partial class RecommendationCollection : RepositoryList<Recommendation, RecommendationCollection>
	{	   
		public RecommendationCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RecommendationCollection</returns>
		public RecommendationCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Recommendation o = this[i];
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
	/// This is an ActiveRecord class which wraps the Recommendations table.
	/// </summary>
	[Serializable]
	public partial class Recommendation : RepositoryRecord<Recommendation>, IRecordBase
	{
		#region .ctors and Default Settings
		
		public Recommendation()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Recommendation(bool useDatabaseDefaults)
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
				TableSchema.Table schema = new TableSchema.Table("Recommendations", TableType.Table, DataService.GetInstance("SSRepository"));
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
				
				TableSchema.TableColumn colvarParagraphActionID = new TableSchema.TableColumn(schema);
				colvarParagraphActionID.ColumnName = "ParagraphActionID";
				colvarParagraphActionID.DataType = DbType.Int32;
				colvarParagraphActionID.MaxLength = 0;
				colvarParagraphActionID.AutoIncrement = false;
				colvarParagraphActionID.IsNullable = true;
				colvarParagraphActionID.IsPrimaryKey = false;
				colvarParagraphActionID.IsForeignKey = false;
				colvarParagraphActionID.IsReadOnly = false;
				colvarParagraphActionID.DefaultSetting = @"";
				colvarParagraphActionID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParagraphActionID);
				
				TableSchema.TableColumn colvarDeadlineDate = new TableSchema.TableColumn(schema);
				colvarDeadlineDate.ColumnName = "DeadlineDate";
				colvarDeadlineDate.DataType = DbType.DateTime;
				colvarDeadlineDate.MaxLength = 0;
				colvarDeadlineDate.AutoIncrement = false;
				colvarDeadlineDate.IsNullable = true;
				colvarDeadlineDate.IsPrimaryKey = false;
				colvarDeadlineDate.IsForeignKey = false;
				colvarDeadlineDate.IsReadOnly = false;
				colvarDeadlineDate.DefaultSetting = @"";
				colvarDeadlineDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDeadlineDate);
				
				TableSchema.TableColumn colvarRecommendationX = new TableSchema.TableColumn(schema);
				colvarRecommendationX.ColumnName = "Recommendation";
				colvarRecommendationX.DataType = DbType.AnsiString;
				colvarRecommendationX.MaxLength = -1;
				colvarRecommendationX.AutoIncrement = false;
				colvarRecommendationX.IsNullable = true;
				colvarRecommendationX.IsPrimaryKey = false;
				colvarRecommendationX.IsForeignKey = false;
				colvarRecommendationX.IsReadOnly = false;
				colvarRecommendationX.DefaultSetting = @"";
				colvarRecommendationX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecommendationX);
				
				TableSchema.TableColumn colvarAddedDate = new TableSchema.TableColumn(schema);
				colvarAddedDate.ColumnName = "AddedDate";
				colvarAddedDate.DataType = DbType.DateTime;
				colvarAddedDate.MaxLength = 0;
				colvarAddedDate.AutoIncrement = false;
				colvarAddedDate.IsNullable = true;
				colvarAddedDate.IsPrimaryKey = false;
				colvarAddedDate.IsForeignKey = false;
				colvarAddedDate.IsReadOnly = false;
				colvarAddedDate.DefaultSetting = @"";
				colvarAddedDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAddedDate);
				
				TableSchema.TableColumn colvarModifiedDate = new TableSchema.TableColumn(schema);
				colvarModifiedDate.ColumnName = "ModifiedDate";
				colvarModifiedDate.DataType = DbType.DateTime;
				colvarModifiedDate.MaxLength = 0;
				colvarModifiedDate.AutoIncrement = false;
				colvarModifiedDate.IsNullable = true;
				colvarModifiedDate.IsPrimaryKey = false;
				colvarModifiedDate.IsForeignKey = false;
				colvarModifiedDate.IsReadOnly = false;
				colvarModifiedDate.DefaultSetting = @"";
				colvarModifiedDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedDate);
				
				TableSchema.TableColumn colvarDeleted = new TableSchema.TableColumn(schema);
				colvarDeleted.ColumnName = "Deleted";
				colvarDeleted.DataType = DbType.Boolean;
				colvarDeleted.MaxLength = 0;
				colvarDeleted.AutoIncrement = false;
				colvarDeleted.IsNullable = false;
				colvarDeleted.IsPrimaryKey = false;
				colvarDeleted.IsForeignKey = false;
				colvarDeleted.IsReadOnly = false;
				
						colvarDeleted.DefaultSetting = @"((0))";
				colvarDeleted.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDeleted);
				
				TableSchema.TableColumn colvarDeletedDate = new TableSchema.TableColumn(schema);
				colvarDeletedDate.ColumnName = "DeletedDate";
				colvarDeletedDate.DataType = DbType.DateTime;
				colvarDeletedDate.MaxLength = 0;
				colvarDeletedDate.AutoIncrement = false;
				colvarDeletedDate.IsNullable = true;
				colvarDeletedDate.IsPrimaryKey = false;
				colvarDeletedDate.IsForeignKey = false;
				colvarDeletedDate.IsReadOnly = false;
				colvarDeletedDate.DefaultSetting = @"";
				colvarDeletedDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDeletedDate);
				
				TableSchema.TableColumn colvarRecommendationType = new TableSchema.TableColumn(schema);
				colvarRecommendationType.ColumnName = "RecommendationType";
				colvarRecommendationType.DataType = DbType.Int32;
				colvarRecommendationType.MaxLength = 0;
				colvarRecommendationType.AutoIncrement = false;
				colvarRecommendationType.IsNullable = true;
				colvarRecommendationType.IsPrimaryKey = false;
				colvarRecommendationType.IsForeignKey = false;
				colvarRecommendationType.IsReadOnly = false;
				colvarRecommendationType.DefaultSetting = @"";
				colvarRecommendationType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecommendationType);
				
				TableSchema.TableColumn colvarCommitteeID = new TableSchema.TableColumn(schema);
				colvarCommitteeID.ColumnName = "CommitteeID";
				colvarCommitteeID.DataType = DbType.Int32;
				colvarCommitteeID.MaxLength = 0;
				colvarCommitteeID.AutoIncrement = false;
				colvarCommitteeID.IsNullable = true;
				colvarCommitteeID.IsPrimaryKey = false;
				colvarCommitteeID.IsForeignKey = false;
				colvarCommitteeID.IsReadOnly = false;
				colvarCommitteeID.DefaultSetting = @"";
				colvarCommitteeID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCommitteeID);
				
				TableSchema.TableColumn colvarRecDate = new TableSchema.TableColumn(schema);
				colvarRecDate.ColumnName = "RecDate";
				colvarRecDate.DataType = DbType.DateTime;
				colvarRecDate.MaxLength = 0;
				colvarRecDate.AutoIncrement = false;
				colvarRecDate.IsNullable = true;
				colvarRecDate.IsPrimaryKey = false;
				colvarRecDate.IsForeignKey = false;
				colvarRecDate.IsReadOnly = false;
				colvarRecDate.DefaultSetting = @"";
				colvarRecDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecDate);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SSRepository"].AddSchema("Recommendations",schema);
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
		  
		[XmlAttribute("ParagraphActionID")]
		[Bindable(true)]
		public int? ParagraphActionID 
		{
			get { return GetColumnValue<int?>(Columns.ParagraphActionID); }
			set { SetColumnValue(Columns.ParagraphActionID, value); }
		}
		  
		[XmlAttribute("DeadlineDate")]
		[Bindable(true)]
		public DateTime? DeadlineDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.DeadlineDate); }
			set { SetColumnValue(Columns.DeadlineDate, value); }
		}
		  
		[XmlAttribute("RecommendationX")]
		[Bindable(true)]
		public string RecommendationX 
		{
			get { return GetColumnValue<string>(Columns.RecommendationX); }
			set { SetColumnValue(Columns.RecommendationX, value); }
		}
		  
		[XmlAttribute("AddedDate")]
		[Bindable(true)]
		public DateTime? AddedDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.AddedDate); }
			set { SetColumnValue(Columns.AddedDate, value); }
		}
		  
		[XmlAttribute("ModifiedDate")]
		[Bindable(true)]
		public DateTime? ModifiedDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.ModifiedDate); }
			set { SetColumnValue(Columns.ModifiedDate, value); }
		}
		  
		[XmlAttribute("Deleted")]
		[Bindable(true)]
		public bool Deleted 
		{
			get { return GetColumnValue<bool>(Columns.Deleted); }
			set { SetColumnValue(Columns.Deleted, value); }
		}
		  
		[XmlAttribute("DeletedDate")]
		[Bindable(true)]
		public DateTime? DeletedDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.DeletedDate); }
			set { SetColumnValue(Columns.DeletedDate, value); }
		}
		  
		[XmlAttribute("RecommendationType")]
		[Bindable(true)]
		public int? RecommendationType 
		{
			get { return GetColumnValue<int?>(Columns.RecommendationType); }
			set { SetColumnValue(Columns.RecommendationType, value); }
		}
		  
		[XmlAttribute("CommitteeID")]
		[Bindable(true)]
		public int? CommitteeID 
		{
			get { return GetColumnValue<int?>(Columns.CommitteeID); }
			set { SetColumnValue(Columns.CommitteeID, value); }
		}
		  
		[XmlAttribute("RecDate")]
		[Bindable(true)]
		public DateTime? RecDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.RecDate); }
			set { SetColumnValue(Columns.RecDate, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ParagraphActionIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DeadlineDateColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn RecommendationXColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn AddedDateColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedDateColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DeletedColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn DeletedDateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn RecommendationTypeColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn CommitteeIDColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn RecDateColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string ParagraphActionID = @"ParagraphActionID";
			 public static string DeadlineDate = @"DeadlineDate";
			 public static string RecommendationX = @"Recommendation";
			 public static string AddedDate = @"AddedDate";
			 public static string ModifiedDate = @"ModifiedDate";
			 public static string Deleted = @"Deleted";
			 public static string DeletedDate = @"DeletedDate";
			 public static string RecommendationType = @"RecommendationType";
			 public static string CommitteeID = @"CommitteeID";
			 public static string RecDate = @"RecDate";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
