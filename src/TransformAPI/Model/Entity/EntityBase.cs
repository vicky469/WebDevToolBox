namespace TransformAPI.Model.Entity;

public class EntityBase
{
    private DateTime CreatedDate { get; set; }
    private string CreatedBy { get; set; }
    private DateTime? UpdatedDate { get; set; }
    private string UpdatedBy { get; set; }
}