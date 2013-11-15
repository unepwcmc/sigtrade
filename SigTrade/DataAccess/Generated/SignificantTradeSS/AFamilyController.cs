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
    /// Controller class for AFamily
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AFamilyController
    {
        // Preload our schema..
        AFamily thisSchemaLoad = new AFamily();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public AFamilyCollection FetchAll()
        {
            AFamilyCollection coll = new AFamilyCollection();
            Query qry = new Query(AFamily.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AFamilyCollection FetchByID(object FamRecID)
        {
            AFamilyCollection coll = new AFamilyCollection().Where("FamRecID", FamRecID).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AFamilyCollection FetchByQuery(Query qry)
        {
            AFamilyCollection coll = new AFamilyCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object FamRecID)
        {
            return (AFamily.Delete(FamRecID) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object FamRecID)
        {
            return (AFamily.Destroy(FamRecID) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int FamRecID,int? FamOrdRecID,string FamName,string FamAuthor,float? FamSortCodeEU,float? FamSortCodeRL,int? FamOrder,string FamStatus,string FamCommonName,int? FamNoGenera,string FamCITESAppendix,DateTime? FamDateListed,DateTime? FamAdded,DateTime? FamModified,int? FamByWho)
	    {
		    AFamily item = new AFamily();
		    
            item.FamRecID = FamRecID;
            
            item.FamOrdRecID = FamOrdRecID;
            
            item.FamName = FamName;
            
            item.FamAuthor = FamAuthor;
            
            item.FamSortCodeEU = FamSortCodeEU;
            
            item.FamSortCodeRL = FamSortCodeRL;
            
            item.FamOrder = FamOrder;
            
            item.FamStatus = FamStatus;
            
            item.FamCommonName = FamCommonName;
            
            item.FamNoGenera = FamNoGenera;
            
            item.FamCITESAppendix = FamCITESAppendix;
            
            item.FamDateListed = FamDateListed;
            
            item.FamAdded = FamAdded;
            
            item.FamModified = FamModified;
            
            item.FamByWho = FamByWho;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int FamRecID,int? FamOrdRecID,string FamName,string FamAuthor,float? FamSortCodeEU,float? FamSortCodeRL,int? FamOrder,string FamStatus,string FamCommonName,int? FamNoGenera,string FamCITESAppendix,DateTime? FamDateListed,DateTime? FamAdded,DateTime? FamModified,int? FamByWho)
	    {
		    AFamily item = new AFamily();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.FamRecID = FamRecID;
				
			item.FamOrdRecID = FamOrdRecID;
				
			item.FamName = FamName;
				
			item.FamAuthor = FamAuthor;
				
			item.FamSortCodeEU = FamSortCodeEU;
				
			item.FamSortCodeRL = FamSortCodeRL;
				
			item.FamOrder = FamOrder;
				
			item.FamStatus = FamStatus;
				
			item.FamCommonName = FamCommonName;
				
			item.FamNoGenera = FamNoGenera;
				
			item.FamCITESAppendix = FamCITESAppendix;
				
			item.FamDateListed = FamDateListed;
				
			item.FamAdded = FamAdded;
				
			item.FamModified = FamModified;
				
			item.FamByWho = FamByWho;
				
	        item.Save(UserName);
	    }
    }
}
