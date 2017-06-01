using System;
using System.Collections;
using System.Collections.Generic;

namespace ArabWaha
{
	public class SurveyCollection : ISurveyCollection
	{
        List<Survey> _items = new List<Survey>();

		public SurveyIterator CreateIterator()
		{
			return new SurveyIterator(this);
		}

		// Gets item count
		public int Count
		{
			get { return _items.Count; }
		}

		// Indexer
        public Survey this[int index]
		{
			get { return _items[index]; }
			set { _items.Add(value); } 
		}
	}
}
