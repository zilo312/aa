using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.Collections
{

   public sealed class MultiValueDictionary<TKey, TValue> : IDictionary<TKey, TValue>
   {
      private Dictionary<TKey, List<TValue>> dict = new Dictionary<TKey, List<TValue>>();


      #region IDictionary<TKey,TValue> Members

      public void Add(TKey key, TValue value)
      {
         List<TValue> list;
         if (dict.TryGetValue(key, out list))
         {
            list.Add(value);
         }
         else
         {
            List<TValue> newList = new List<TValue>();
            newList.Add(value);
            dict.Add(key, newList);
         }
      }

      public bool ContainsKey(TKey key)
      {
         return dict.ContainsKey(key);
      }

      public ICollection<TKey> Keys
      {
         get
         {
            return dict.Keys;
         }
      }

      public bool Remove(TKey key)
      {
         return dict.Remove(key);
      }

      bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value)
      {
         throw new NotSupportedException("TryGetValue is not supported");
      }

      public ICollection<TValue> Values
      {
         get
         {
            List<TValue> values = new List<TValue>();

            Dictionary<TKey, List<TValue>>.Enumerator enumerator = dict.GetEnumerator();
            while (enumerator.MoveNext())
            {
               values.AddRange(enumerator.Current.Value);
            }

            return values;
         }
      }

      TValue IDictionary<TKey, TValue>.this[TKey key]
      {
         get
         {
            throw new NotSupportedException("accessing elements by key is not supported");
         }
         set
         {
            throw new NotSupportedException("accessing elements by key is not supported");
         }
      }

      #endregion

      public IList<TValue> this[TKey key]
      {
         get
         {
            return dict[key];
         }
      }

      #region ICollection<KeyValuePair<TKey,TValue>> Members

      public void Add(KeyValuePair<TKey, TValue> item)
      {
         Add(item.Key, item.Value);

      }

      public void Clear()
      {
         dict.Clear();
      }

      public bool Contains(KeyValuePair<TKey, TValue> item)
      {
         List<TValue> list;
         if (!dict.TryGetValue(item.Key, out list))
         {
            return false;
         }
         else
         {
            return list.Contains(item.Value);
         }
      }

      public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
      {
         if (array == null) throw new ArgumentNullException("array");
         if (arrayIndex < 0 || arrayIndex > array.Length) throw new ArgumentOutOfRangeException("array");
          if (array.Length - arrayIndex < this.Count) throw new ArgumentException("Array too small", "array");

         Dictionary<TKey, List<TValue>>.Enumerator enumerator = dict.GetEnumerator();
         while (enumerator.MoveNext())
         {
            KeyValuePair<TKey, List<TValue>> mapPair = enumerator.Current;
            foreach (TValue val in mapPair.Value)
	         {
               array[arrayIndex++] = new KeyValuePair<TKey,TValue>(mapPair.Key, val);
         		 
	         }
         }         
      }

      public int Count
      {
         get
         {
            int count = 0;

            Dictionary<TKey, List<TValue>>.Enumerator enumerator = dict.GetEnumerator();
            while (enumerator.MoveNext())
            {
               KeyValuePair<TKey, List<TValue>> pair = enumerator.Current;
               count += pair.Value.Count;
            }

            return count;

         }
      }

      public bool IsReadOnly
      {
         get { return false; }
      }

      public bool Remove(KeyValuePair<TKey, TValue> item)
      {
         List<TValue> list;
         if (dict.TryGetValue(item.Key, out list))
         {
            return list.Remove(item.Value);
         }
         else
         {
            return false;
         }
      }

      #endregion

      #region IEnumerable<KeyValuePair<TKey,TValue>> Members

      public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
      {
         Dictionary<TKey, List<TValue>>.Enumerator enumerateKeys = dict.GetEnumerator();
         while (enumerateKeys.MoveNext())
         {
            foreach (TValue val in enumerateKeys.Current.Value)
            {
               KeyValuePair<TKey, TValue> pair = new KeyValuePair<TKey, TValue>(
                  enumerateKeys.Current.Key, val);
               yield return pair;

            }
         }
      }

      #endregion

      #region IEnumerable Members

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }

      #endregion
   }
}
