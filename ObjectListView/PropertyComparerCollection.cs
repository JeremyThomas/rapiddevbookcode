// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace JesseJohnston
{
	/// <summary>
	/// Collection of <seealso cref="IComparer"/> objects to compare property values for a specified type.
	/// </summary>
	[Serializable]
	public class PropertyComparerCollection : IDictionary<string, IComparer>
	{
		private Dictionary<string, IComparer> comparers = new Dictionary<string, IComparer>();
		private List<string> properties = new List<string>();
		private bool suppressEvents;
		private bool collectionChanged;

		internal event EventHandler CollectionChanged;

		internal PropertyComparerCollection(Type itemType)
		{
			if (itemType == null)
				throw new ArgumentNullException("itemType");

			foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(itemType))
				this.properties.Add(prop.Name);
		}

		internal void BeginUpdate()
		{
			this.suppressEvents = true;
		}
		internal void EndUpdate()
		{
			this.suppressEvents = false;
			if (this.collectionChanged)
			{
				this.collectionChanged = false;
				this.OnCollectionChanged();
			}
		}

		#region IDictionary<string,IComparer> Members
		/// <summary>
		/// Adds an <see cref="IComparer"/> for the provided property name.
		/// </summary>
		/// <param name="key">The property name.</param>
		/// <param name="value">The <seealso cref="IComparer"/> to use when comparing values of the property.</param>
		/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2"></see>.</exception>
		/// <exception cref="T:System.ArgumentNullException">key is null.</exception>
		public void Add(string key, IComparer value)
		{
			this.comparers.Add(key, value);
			this.OnCollectionChanged();
		}
		/// <summary>
		/// Determines whether the collection contains an <see cref="IComparer"/> for the specified property name.
		/// </summary>
		/// <param name="key">The property name.</param>
		/// <returns>
		/// <b>true</b> if the contains contains an element with the key; otherwise, <b>false</b>.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException">key is null.</exception>
		public bool ContainsKey(string key)
		{
			return this.comparers.ContainsKey(key);
		}
		ICollection<string> IDictionary<string, IComparer>.Keys
		{
			get { return this.comparers.Keys; }
		}
		/// <summary>
		/// Removes the <see cref="IComparer"/> associated with the specified property name from the collection.
		/// </summary>
		/// <param name="key">The property name associated with the <seealso cref="IComparer"/> to remove.</param>
		/// <returns>
		/// <b>true</b> if the element is successfully removed; otherwise, <b>false</b>.  This method also returns false if key was not found in the original collection.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException">key is null.</exception>
		public bool Remove(string key)
		{
			bool result = this.comparers.Remove(key);
			this.OnCollectionChanged();
			return result;
		}
		bool IDictionary<string, IComparer>.TryGetValue(string key, out IComparer value)
		{
			return this.comparers.TryGetValue(key, out value);
		}
		ICollection<IComparer> IDictionary<string, IComparer>.Values
		{
			get { return this.comparers.Values; }
		}
		/// <summary>
		/// Gets or sets the <see cref="IComparer"/> for the specified property name.
		/// </summary>
		public IComparer this[string key]
		{
			get
			{
				if (this.comparers.ContainsKey(key))
					return this.comparers[key];
				else
					return null;
			}
			set
			{
				if (key == null)
					throw new ArgumentNullException("key");
				if (key == "")
					throw new ArgumentException("key");

				bool containsKey = this.comparers.ContainsKey(key);
				if ((!containsKey && value != null) ||
					 (containsKey && value != this.comparers[key]))
				{
					if (value == null)
						this.comparers.Remove(key);
					else
					{
						if (!this.HasProperty(key))
							throw new ArgumentException("key");

						this.comparers[key] = value;
					}
					this.OnCollectionChanged();
				}
			}
		}
		#endregion

		#region ICollection<KeyValuePair<string,IComparer>> Members
		void ICollection<KeyValuePair<string, IComparer>>.Add(KeyValuePair<string, IComparer> item)
		{
			((ICollection<KeyValuePair<string, IComparer>>)this.comparers).Add(item);
			this.OnCollectionChanged();
		}
		/// <summary>
		/// Removes all <see cref="IComparer"/>s from the collection.
		/// </summary>
		public void Clear()
		{
			this.comparers.Clear();
			this.OnCollectionChanged();
		}
		bool ICollection<KeyValuePair<string, IComparer>>.Contains(KeyValuePair<string, IComparer> item)
		{
			return ((ICollection<KeyValuePair<string, IComparer>>)this.comparers).Contains(item);
		}
		void ICollection<KeyValuePair<string, IComparer>>.CopyTo(KeyValuePair<string, IComparer>[] array, int arrayIndex)
		{
			((ICollection<KeyValuePair<string, IComparer>>)this.comparers).CopyTo(array, arrayIndex);
		}
		/// <summary>
		/// Gets the number of <see cref="IComparer"/>s contained in the collection.
		/// </summary>
		/// <returns>The number of elements contained in the collection.</returns>
		public int Count
		{
			get { return comparers.Count; }
		}
		bool ICollection<KeyValuePair<string, IComparer>>.IsReadOnly
		{
			get { return false; }
		}
		bool ICollection<KeyValuePair<string, IComparer>>.Remove(KeyValuePair<string, IComparer> item)
		{
			bool result = ((ICollection<KeyValuePair<string, IComparer>>)this.comparers).Remove(item);
			this.OnCollectionChanged();
			return result;
		}
		#endregion

		#region IEnumerable<KeyValuePair<string,IComparer>> Members
		IEnumerator<KeyValuePair<string, IComparer>> IEnumerable<KeyValuePair<string, IComparer>>.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<string, IComparer>>)this.comparers).GetEnumerator();
		}
		#endregion

		#region IEnumerable Members
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)this.comparers).GetEnumerator();
		}
		#endregion

		private bool HasProperty(string propertyName)
		{
			return this.properties.Contains(propertyName);
		}

		private void OnCollectionChanged()
		{
			if (CollectionChanged != null)
			{
				if (this.suppressEvents)
					this.collectionChanged = true;
				else
					CollectionChanged(this, EventArgs.Empty);
			}
		}
	}
}
