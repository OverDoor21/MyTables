namespace MyTables.Entities
{
    public class WorkItemTag
    {
         public WorkItem WorkItem {  get; set; }
         public int WorkItemID {  get; set; }
         public Tag Tag { get; set; }
         public int TagId { get; set; }  

         public DateTime PublicationDate { get; set; }
    }
}
