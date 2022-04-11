namespace Plk.Blazor.DragDrop;

public class ItemDropSameZoneArgs<TItem>
{
    public TItem Item { get; }
    public string DropZoneId { get; }
    public int InsertIndex { get; }

    public ItemDropSameZoneArgs(TItem item, int insertIndex, string dropZoneId)
    {
        InsertIndex = insertIndex;
        DropZoneId = dropZoneId;
        Item = item;
    }
}