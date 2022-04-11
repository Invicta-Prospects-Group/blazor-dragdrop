namespace Plk.Blazor.DragDrop;

public class ItemDropDifferentZoneArgs<TItem>
{
    public TItem Item { get; }
    public int InsertIndex { get; }
    public string FromDropZoneId { get; }
    public string ToDropZoneId { get; }

    public ItemDropDifferentZoneArgs(TItem item, int insertIndex, string fromDropZoneId, string toDropZoneId)
    {
        Item = item;
        InsertIndex = insertIndex;
        FromDropZoneId = fromDropZoneId;
        ToDropZoneId = toDropZoneId;
    }

}