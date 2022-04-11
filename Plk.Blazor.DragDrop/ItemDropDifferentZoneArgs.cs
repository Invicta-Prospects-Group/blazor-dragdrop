using System.Collections.Generic;

namespace Plk.Blazor.DragDrop;

public class ItemDropDifferentZoneArgs<TItem>
{
    public TItem Item { get; }
    public int InsertIndex { get; }
    public IList<TItem> FromItems { get; }

    public ItemDropDifferentZoneArgs(TItem item, int insertIndex, IList<TItem> fromItems)
    {
        Item = item;
        InsertIndex = insertIndex;
        FromItems = fromItems;
    }

}