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
namespace SignificantTradeSSRepository{
    /// <summary>
    /// Strongly-typed collection for the VwAnimalsTaxaOld class.
    /// </summary>
    [Serializable]
    public partial class VwAnimalsTaxaOldCollection : ReadOnlyList<VwAnimalsTaxaOld, VwAnimalsTaxaOldCollection>
    {        
        public VwAnimalsTaxaOldCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vwAnimalsTaxa_old view.
    /// </summary>
    [Serializable]
    public partial class VwAnimalsTaxaOld : ReadOnlyRecord<VwAnimalsTaxaOld>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("vwAnimalsTaxa_old", TableType.View, DataService.GetInstance("SSRepository"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarSpcrecID = new TableSchema.TableColumn(schema);
                colvarSpcrecID.ColumnName = "SpcrecID";
                colvarSpcrecID.DataType = DbType.Int32;
                colvarSpcrecID.MaxLength = 0;
                colvarSpcrecID.AutoIncrement = false;
                colvarSpcrecID.IsNullable = true;
                colvarSpcrecID.IsPrimaryKey = false;
                colvarSpcrecID.IsForeignKey = false;
                colvarSpcrecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarSpcrecID);
                
                TableSchema.TableColumn colvarGenRecID = new TableSchema.TableColumn(schema);
                colvarGenRecID.ColumnName = "GenRecID";
                colvarGenRecID.DataType = DbType.Int32;
                colvarGenRecID.MaxLength = 0;
                colvarGenRecID.AutoIncrement = false;
                colvarGenRecID.IsNullable = true;
                colvarGenRecID.IsPrimaryKey = false;
                colvarGenRecID.IsForeignKey = false;
                colvarGenRecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarGenRecID);
                
                TableSchema.TableColumn colvarFamRecID = new TableSchema.TableColumn(schema);
                colvarFamRecID.ColumnName = "FamRecID";
                colvarFamRecID.DataType = DbType.Int32;
                colvarFamRecID.MaxLength = 0;
                colvarFamRecID.AutoIncrement = false;
                colvarFamRecID.IsNullable = false;
                colvarFamRecID.IsPrimaryKey = false;
                colvarFamRecID.IsForeignKey = false;
                colvarFamRecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarFamRecID);
                
                TableSchema.TableColumn colvarOrdRecID = new TableSchema.TableColumn(schema);
                colvarOrdRecID.ColumnName = "OrdRecID";
                colvarOrdRecID.DataType = DbType.Int32;
                colvarOrdRecID.MaxLength = 0;
                colvarOrdRecID.AutoIncrement = false;
                colvarOrdRecID.IsNullable = false;
                colvarOrdRecID.IsPrimaryKey = false;
                colvarOrdRecID.IsForeignKey = false;
                colvarOrdRecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdRecID);
                
                TableSchema.TableColumn colvarClaRecID = new TableSchema.TableColumn(schema);
                colvarClaRecID.ColumnName = "ClaRecID";
                colvarClaRecID.DataType = DbType.Int32;
                colvarClaRecID.MaxLength = 0;
                colvarClaRecID.AutoIncrement = false;
                colvarClaRecID.IsNullable = false;
                colvarClaRecID.IsPrimaryKey = false;
                colvarClaRecID.IsForeignKey = false;
                colvarClaRecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarClaRecID);
                
                TableSchema.TableColumn colvarPhyRecID = new TableSchema.TableColumn(schema);
                colvarPhyRecID.ColumnName = "PhyRecID";
                colvarPhyRecID.DataType = DbType.Int32;
                colvarPhyRecID.MaxLength = 0;
                colvarPhyRecID.AutoIncrement = false;
                colvarPhyRecID.IsNullable = false;
                colvarPhyRecID.IsPrimaryKey = false;
                colvarPhyRecID.IsForeignKey = false;
                colvarPhyRecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarPhyRecID);
                
                TableSchema.TableColumn colvarKgmRecID = new TableSchema.TableColumn(schema);
                colvarKgmRecID.ColumnName = "KgmRecID";
                colvarKgmRecID.DataType = DbType.Int32;
                colvarKgmRecID.MaxLength = 0;
                colvarKgmRecID.AutoIncrement = false;
                colvarKgmRecID.IsNullable = false;
                colvarKgmRecID.IsPrimaryKey = false;
                colvarKgmRecID.IsForeignKey = false;
                colvarKgmRecID.IsReadOnly = false;
                
                schema.Columns.Add(colvarKgmRecID);
                
                TableSchema.TableColumn colvarKgmName = new TableSchema.TableColumn(schema);
                colvarKgmName.ColumnName = "KgmName";
                colvarKgmName.DataType = DbType.String;
                colvarKgmName.MaxLength = 50;
                colvarKgmName.AutoIncrement = false;
                colvarKgmName.IsNullable = true;
                colvarKgmName.IsPrimaryKey = false;
                colvarKgmName.IsForeignKey = false;
                colvarKgmName.IsReadOnly = false;
                
                schema.Columns.Add(colvarKgmName);
                
                TableSchema.TableColumn colvarKgmCommonName = new TableSchema.TableColumn(schema);
                colvarKgmCommonName.ColumnName = "KgmCommonName";
                colvarKgmCommonName.DataType = DbType.String;
                colvarKgmCommonName.MaxLength = 30;
                colvarKgmCommonName.AutoIncrement = false;
                colvarKgmCommonName.IsNullable = true;
                colvarKgmCommonName.IsPrimaryKey = false;
                colvarKgmCommonName.IsForeignKey = false;
                colvarKgmCommonName.IsReadOnly = false;
                
                schema.Columns.Add(colvarKgmCommonName);
                
                TableSchema.TableColumn colvarPhyName = new TableSchema.TableColumn(schema);
                colvarPhyName.ColumnName = "PhyName";
                colvarPhyName.DataType = DbType.String;
                colvarPhyName.MaxLength = 30;
                colvarPhyName.AutoIncrement = false;
                colvarPhyName.IsNullable = true;
                colvarPhyName.IsPrimaryKey = false;
                colvarPhyName.IsForeignKey = false;
                colvarPhyName.IsReadOnly = false;
                
                schema.Columns.Add(colvarPhyName);
                
                TableSchema.TableColumn colvarClaName = new TableSchema.TableColumn(schema);
                colvarClaName.ColumnName = "ClaName";
                colvarClaName.DataType = DbType.String;
                colvarClaName.MaxLength = 30;
                colvarClaName.AutoIncrement = false;
                colvarClaName.IsNullable = true;
                colvarClaName.IsPrimaryKey = false;
                colvarClaName.IsForeignKey = false;
                colvarClaName.IsReadOnly = false;
                
                schema.Columns.Add(colvarClaName);
                
                TableSchema.TableColumn colvarOrdName = new TableSchema.TableColumn(schema);
                colvarOrdName.ColumnName = "OrdName";
                colvarOrdName.DataType = DbType.String;
                colvarOrdName.MaxLength = 30;
                colvarOrdName.AutoIncrement = false;
                colvarOrdName.IsNullable = true;
                colvarOrdName.IsPrimaryKey = false;
                colvarOrdName.IsForeignKey = false;
                colvarOrdName.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdName);
                
                TableSchema.TableColumn colvarFamName = new TableSchema.TableColumn(schema);
                colvarFamName.ColumnName = "FamName";
                colvarFamName.DataType = DbType.String;
                colvarFamName.MaxLength = 50;
                colvarFamName.AutoIncrement = false;
                colvarFamName.IsNullable = true;
                colvarFamName.IsPrimaryKey = false;
                colvarFamName.IsForeignKey = false;
                colvarFamName.IsReadOnly = false;
                
                schema.Columns.Add(colvarFamName);
                
                TableSchema.TableColumn colvarGenName = new TableSchema.TableColumn(schema);
                colvarGenName.ColumnName = "GenName";
                colvarGenName.DataType = DbType.String;
                colvarGenName.MaxLength = 50;
                colvarGenName.AutoIncrement = false;
                colvarGenName.IsNullable = true;
                colvarGenName.IsPrimaryKey = false;
                colvarGenName.IsForeignKey = false;
                colvarGenName.IsReadOnly = false;
                
                schema.Columns.Add(colvarGenName);
                
                TableSchema.TableColumn colvarSpcName = new TableSchema.TableColumn(schema);
                colvarSpcName.ColumnName = "SpcName";
                colvarSpcName.DataType = DbType.String;
                colvarSpcName.MaxLength = 255;
                colvarSpcName.AutoIncrement = false;
                colvarSpcName.IsNullable = true;
                colvarSpcName.IsPrimaryKey = false;
                colvarSpcName.IsForeignKey = false;
                colvarSpcName.IsReadOnly = false;
                
                schema.Columns.Add(colvarSpcName);
                
                TableSchema.TableColumn colvarSpcInfraEpithet = new TableSchema.TableColumn(schema);
                colvarSpcInfraEpithet.ColumnName = "SpcInfraEpithet";
                colvarSpcInfraEpithet.DataType = DbType.String;
                colvarSpcInfraEpithet.MaxLength = 255;
                colvarSpcInfraEpithet.AutoIncrement = false;
                colvarSpcInfraEpithet.IsNullable = true;
                colvarSpcInfraEpithet.IsPrimaryKey = false;
                colvarSpcInfraEpithet.IsForeignKey = false;
                colvarSpcInfraEpithet.IsReadOnly = false;
                
                schema.Columns.Add(colvarSpcInfraEpithet);
                
                TableSchema.TableColumn colvarSpcStatus = new TableSchema.TableColumn(schema);
                colvarSpcStatus.ColumnName = "SpcStatus";
                colvarSpcStatus.DataType = DbType.String;
                colvarSpcStatus.MaxLength = 255;
                colvarSpcStatus.AutoIncrement = false;
                colvarSpcStatus.IsNullable = true;
                colvarSpcStatus.IsPrimaryKey = false;
                colvarSpcStatus.IsForeignKey = false;
                colvarSpcStatus.IsReadOnly = false;
                
                schema.Columns.Add(colvarSpcStatus);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SSRepository"].AddSchema("vwAnimalsTaxa_old",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public VwAnimalsTaxaOld()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAnimalsTaxaOld(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAnimalsTaxaOld(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAnimalsTaxaOld(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("SpcrecID")]
        [Bindable(true)]
        public int? SpcrecID 
	    {
		    get
		    {
			    return GetColumnValue<int?>("SpcrecID");
		    }
            set 
		    {
			    SetColumnValue("SpcrecID", value);
            }
        }
	      
        [XmlAttribute("GenRecID")]
        [Bindable(true)]
        public int? GenRecID 
	    {
		    get
		    {
			    return GetColumnValue<int?>("GenRecID");
		    }
            set 
		    {
			    SetColumnValue("GenRecID", value);
            }
        }
	      
        [XmlAttribute("FamRecID")]
        [Bindable(true)]
        public int FamRecID 
	    {
		    get
		    {
			    return GetColumnValue<int>("FamRecID");
		    }
            set 
		    {
			    SetColumnValue("FamRecID", value);
            }
        }
	      
        [XmlAttribute("OrdRecID")]
        [Bindable(true)]
        public int OrdRecID 
	    {
		    get
		    {
			    return GetColumnValue<int>("OrdRecID");
		    }
            set 
		    {
			    SetColumnValue("OrdRecID", value);
            }
        }
	      
        [XmlAttribute("ClaRecID")]
        [Bindable(true)]
        public int ClaRecID 
	    {
		    get
		    {
			    return GetColumnValue<int>("ClaRecID");
		    }
            set 
		    {
			    SetColumnValue("ClaRecID", value);
            }
        }
	      
        [XmlAttribute("PhyRecID")]
        [Bindable(true)]
        public int PhyRecID 
	    {
		    get
		    {
			    return GetColumnValue<int>("PhyRecID");
		    }
            set 
		    {
			    SetColumnValue("PhyRecID", value);
            }
        }
	      
        [XmlAttribute("KgmRecID")]
        [Bindable(true)]
        public int KgmRecID 
	    {
		    get
		    {
			    return GetColumnValue<int>("KgmRecID");
		    }
            set 
		    {
			    SetColumnValue("KgmRecID", value);
            }
        }
	      
        [XmlAttribute("KgmName")]
        [Bindable(true)]
        public string KgmName 
	    {
		    get
		    {
			    return GetColumnValue<string>("KgmName");
		    }
            set 
		    {
			    SetColumnValue("KgmName", value);
            }
        }
	      
        [XmlAttribute("KgmCommonName")]
        [Bindable(true)]
        public string KgmCommonName 
	    {
		    get
		    {
			    return GetColumnValue<string>("KgmCommonName");
		    }
            set 
		    {
			    SetColumnValue("KgmCommonName", value);
            }
        }
	      
        [XmlAttribute("PhyName")]
        [Bindable(true)]
        public string PhyName 
	    {
		    get
		    {
			    return GetColumnValue<string>("PhyName");
		    }
            set 
		    {
			    SetColumnValue("PhyName", value);
            }
        }
	      
        [XmlAttribute("ClaName")]
        [Bindable(true)]
        public string ClaName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ClaName");
		    }
            set 
		    {
			    SetColumnValue("ClaName", value);
            }
        }
	      
        [XmlAttribute("OrdName")]
        [Bindable(true)]
        public string OrdName 
	    {
		    get
		    {
			    return GetColumnValue<string>("OrdName");
		    }
            set 
		    {
			    SetColumnValue("OrdName", value);
            }
        }
	      
        [XmlAttribute("FamName")]
        [Bindable(true)]
        public string FamName 
	    {
		    get
		    {
			    return GetColumnValue<string>("FamName");
		    }
            set 
		    {
			    SetColumnValue("FamName", value);
            }
        }
	      
        [XmlAttribute("GenName")]
        [Bindable(true)]
        public string GenName 
	    {
		    get
		    {
			    return GetColumnValue<string>("GenName");
		    }
            set 
		    {
			    SetColumnValue("GenName", value);
            }
        }
	      
        [XmlAttribute("SpcName")]
        [Bindable(true)]
        public string SpcName 
	    {
		    get
		    {
			    return GetColumnValue<string>("SpcName");
		    }
            set 
		    {
			    SetColumnValue("SpcName", value);
            }
        }
	      
        [XmlAttribute("SpcInfraEpithet")]
        [Bindable(true)]
        public string SpcInfraEpithet 
	    {
		    get
		    {
			    return GetColumnValue<string>("SpcInfraEpithet");
		    }
            set 
		    {
			    SetColumnValue("SpcInfraEpithet", value);
            }
        }
	      
        [XmlAttribute("SpcStatus")]
        [Bindable(true)]
        public string SpcStatus 
	    {
		    get
		    {
			    return GetColumnValue<string>("SpcStatus");
		    }
            set 
		    {
			    SetColumnValue("SpcStatus", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string SpcrecID = @"SpcrecID";
            
            public static string GenRecID = @"GenRecID";
            
            public static string FamRecID = @"FamRecID";
            
            public static string OrdRecID = @"OrdRecID";
            
            public static string ClaRecID = @"ClaRecID";
            
            public static string PhyRecID = @"PhyRecID";
            
            public static string KgmRecID = @"KgmRecID";
            
            public static string KgmName = @"KgmName";
            
            public static string KgmCommonName = @"KgmCommonName";
            
            public static string PhyName = @"PhyName";
            
            public static string ClaName = @"ClaName";
            
            public static string OrdName = @"OrdName";
            
            public static string FamName = @"FamName";
            
            public static string GenName = @"GenName";
            
            public static string SpcName = @"SpcName";
            
            public static string SpcInfraEpithet = @"SpcInfraEpithet";
            
            public static string SpcStatus = @"SpcStatus";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
