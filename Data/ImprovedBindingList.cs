using System.ComponentModel;

namespace TSP2005
{
    public class ImprovedBindingList<T> : BindingList<T>
    {

        protected override void RemoveItem(int itemIndex)
        {
            //itemIndex = index of item which is going to be removed
            //get item from binding list at itemIndex position
            object deletedItem = this.Items[itemIndex];

            //raise event containing item which is going to be removed
            BeforeRemove?.Invoke(deletedItem);

            //remove item from list
            base.RemoveItem(itemIndex);
        }

        public delegate void BeforeRemoveEvent(object deletedItem);
        public event BeforeRemoveEvent BeforeRemove;

    }

    public static class ImprovedBindingListFactory<T>
    {
        public static ImprovedBindingList<T> Create(IList<T> source)
        {
            var destination = new ImprovedBindingList<T>();

            foreach (var item in source)
            {
                destination.Add(item);
            }

            return destination;

        }
    }
}
