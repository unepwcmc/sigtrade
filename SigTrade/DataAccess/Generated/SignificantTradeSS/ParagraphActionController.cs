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
    /// Controller class for ParagraphAction
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ParagraphActionController
    {
        // Preload our schema..
        ParagraphAction thisSchemaLoad = new ParagraphAction();
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
        public ParagraphActionCollection FetchAll()
        {
            ParagraphActionCollection coll = new ParagraphActionCollection();
            Query qry = new Query(ParagraphAction.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ParagraphActionCollection FetchByID(object Id)
        {
            ParagraphActionCollection coll = new ParagraphActionCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ParagraphActionCollection FetchByQuery(Query qry)
        {
            ParagraphActionCollection coll = new ParagraphActionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (ParagraphAction.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (ParagraphAction.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? PALibID,DateTime? DateStarted,DateTime? DeadlineDate,int? CommitteeID,int? MeetingID,int? ReviewID,bool Deleted,bool Completed,DateTime? CompletedDate,DateTime? DateAdded,DateTime? DateModified,int? ConcernID,bool? CurrentConcern)
	    {
		    ParagraphAction item = new ParagraphAction();
		    
            item.PALibID = PALibID;
            
            item.DateStarted = DateStarted;
            
            item.DeadlineDate = DeadlineDate;
            
            item.CommitteeID = CommitteeID;
            
            item.MeetingID = MeetingID;
            
            item.ReviewID = ReviewID;
            
            item.Deleted = Deleted;
            
            item.Completed = Completed;
            
            item.CompletedDate = CompletedDate;
            
            item.DateAdded = DateAdded;
            
            item.DateModified = DateModified;
            
            item.ConcernID = ConcernID;
            
            item.CurrentConcern = CurrentConcern;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? PALibID,DateTime? DateStarted,DateTime? DeadlineDate,int? CommitteeID,int? MeetingID,int? ReviewID,bool Deleted,bool Completed,DateTime? CompletedDate,DateTime? DateAdded,DateTime? DateModified,int? ConcernID,bool? CurrentConcern)
	    {
		    ParagraphAction item = new ParagraphAction();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.PALibID = PALibID;
				
			item.DateStarted = DateStarted;
				
			item.DeadlineDate = DeadlineDate;
				
			item.CommitteeID = CommitteeID;
				
			item.MeetingID = MeetingID;
				
			item.ReviewID = ReviewID;
				
			item.Deleted = Deleted;
				
			item.Completed = Completed;
				
			item.CompletedDate = CompletedDate;
				
			item.DateAdded = DateAdded;
				
			item.DateModified = DateModified;
				
			item.ConcernID = ConcernID;
				
			item.CurrentConcern = CurrentConcern;
				
	        item.Save(UserName);
	    }
    }
}