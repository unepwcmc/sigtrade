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
    /// Controller class for Decisions
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class DecisionController
    {
        // Preload our schema..
        Decision thisSchemaLoad = new Decision();
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
        public DecisionCollection FetchAll()
        {
            DecisionCollection coll = new DecisionCollection();
            Query qry = new Query(Decision.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public DecisionCollection FetchByID(object Id)
        {
            DecisionCollection coll = new DecisionCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public DecisionCollection FetchByQuery(Query qry)
        {
            DecisionCollection coll = new DecisionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (Decision.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (Decision.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? ParagraphActionID,int? DecisionType,string Notes,DateTime? SuspensionDate,int? TradeTerms,int? SuspensionCommitteeID,DateTime? SuspensionLiftDate,int? LigftingCommitteeID,DateTime? AddedDate,DateTime? ModifiedDate,bool? Deleted,DateTime? DeletedDate)
	    {
		    Decision item = new Decision();
		    
            item.ParagraphActionID = ParagraphActionID;
            
            item.DecisionType = DecisionType;
            
            item.Notes = Notes;
            
            item.SuspensionDate = SuspensionDate;
            
            item.TradeTerms = TradeTerms;
            
            item.SuspensionCommitteeID = SuspensionCommitteeID;
            
            item.SuspensionLiftDate = SuspensionLiftDate;
            
            item.LigftingCommitteeID = LigftingCommitteeID;
            
            item.AddedDate = AddedDate;
            
            item.ModifiedDate = ModifiedDate;
            
            item.Deleted = Deleted;
            
            item.DeletedDate = DeletedDate;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? ParagraphActionID,int? DecisionType,string Notes,DateTime? SuspensionDate,int? TradeTerms,int? SuspensionCommitteeID,DateTime? SuspensionLiftDate,int? LigftingCommitteeID,DateTime? AddedDate,DateTime? ModifiedDate,bool? Deleted,DateTime? DeletedDate)
	    {
		    Decision item = new Decision();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.ParagraphActionID = ParagraphActionID;
				
			item.DecisionType = DecisionType;
				
			item.Notes = Notes;
				
			item.SuspensionDate = SuspensionDate;
				
			item.TradeTerms = TradeTerms;
				
			item.SuspensionCommitteeID = SuspensionCommitteeID;
				
			item.SuspensionLiftDate = SuspensionLiftDate;
				
			item.LigftingCommitteeID = LigftingCommitteeID;
				
			item.AddedDate = AddedDate;
				
			item.ModifiedDate = ModifiedDate;
				
			item.Deleted = Deleted;
				
			item.DeletedDate = DeletedDate;
				
	        item.Save(UserName);
	    }
    }
}
