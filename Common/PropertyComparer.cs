using System.ComponentModel;

namespace TSP2025.Common
{
    public class PropertyComparer<T> : IComparer<T>
    {
        // Fields
        private PropertyDescriptor _property;
        private ListSortDirection _direction;

        // Methods
        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            _property = property;
            _direction = direction;
        }

        public int Compare(T xWord, T yWord)
        {
            object propertyValue = GetPropertyValue(xWord, _property.Name);
            object yValue = GetPropertyValue(yWord, _property.Name);
            if (_direction == ListSortDirection.Ascending)
            {
                return CompareAscending(propertyValue, yValue);
            }
            return CompareDescending(propertyValue, yValue);
        }

        private int CompareAscending(object xValue, object yValue)
        {
            int num;
            if (xValue == null && yValue == null)
            {
                return 0;
            }
            if (xValue == null)
            {
                return -1;
            }
            if (yValue == null)
            {
                return 1;
            }
            if (xValue is IComparable)
            {
                num = ((IComparable)xValue).CompareTo(yValue);
            }
            else if (xValue.Equals(yValue))
            {
                num = 0;
            }
            else
            {
                num = xValue.ToString().CompareTo(yValue.ToString());
            }
            return num;
        }

        private int CompareDescending(object xValue, object yValue)
        {
            return CompareAscending(xValue, yValue) * -1;
        }

        public bool Equals(T xWord, T yWord)
        {
            return xWord.Equals(yWord);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        private object GetPropertyValue(T value, string property)
        {
            Type type = typeof(T);
            return value.GetType().GetProperty(property).GetValue(value, null);
        }
    }
}
