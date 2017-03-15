namespace CodeFormatting.Events
{
    using System;

    public class OrderedBag<T>
    {
        public void Add(Event newEvent)
        {
            
        }

        public void Remove(object eventToRemove)
        {
            
        }

        public OrderedBag<Event>.View RangeFrom(Event @event, bool v)
        {
            throw new NotImplementedException();
        }

        public class View
        {
        }
    }
}