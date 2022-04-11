namespace Plk.Blazor.DragDrop;

public class ItemSwitchSameZoneArgs<TItem>
{
    public TItem Item1 { get; }
    public TItem Item2 { get; }

    public ItemSwitchSameZoneArgs(TItem item1, TItem item2)
    {
        Item1 = item1;
        Item2 = item2;
    }
}