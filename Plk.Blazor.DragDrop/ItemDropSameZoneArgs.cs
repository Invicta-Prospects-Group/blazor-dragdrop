namespace Plk.Blazor.DragDrop;

public class ItemDropSameZoneArgs<TItem>
{
    public TItem Item { get; }
    public int InsertIndex { get; }

    public ItemDropSameZoneArgs(TItem item, int insertIndex)
    {
        InsertIndex = insertIndex;
        Item = item;
    }
}