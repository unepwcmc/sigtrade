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
    /// Controller class for CommitteeLib
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CommitteeLibController
    {
        // Preload our schema..
        CommitteeLib thisSchemaLoad = new CommitteeLib();
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
        public CommitteeLibCollection FetchAll()
        {
            CommitteeLibCollection coll = new CommitteeLibCollection();
            Query qry = new Query(CommitteeLib.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CommitteeLibCollection FetchByID(object Id)
        {
            CommitteeLibCollection coll = new CommitteeLibCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CommitteeLibCollection FetchByQuery(Query qry)
        {
            CommitteeLibCollection coll = new CommitteeLibCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CommitteeLib.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CommitteeLib.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Description,DateTime? DateAdded,bool Deleted)
	    {
		    CommitteeLib item = new CommitteeLib();
		    
            item.Description = Description;
            
            item.DateAdded = DateAdded;
            
            item.Deleted = Deleted;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Description,DateTime? DateAdded,bool Deleted)
	    {
		    CommitteeLib item = new CommitteeLib();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Description = Description;
				
			item.DateAdded = DateAdded;
				
			item.Deleted = Deleted;
				
	        item.Save(UserName);
	    }
    }
}