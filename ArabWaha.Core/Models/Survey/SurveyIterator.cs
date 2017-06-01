using System;

namespace ArabWaha
{
	public class SurveyIterator : ISurveyIterator
	{
		private SurveyCollection _collection;
		private int _current = 0;
		private int _step = 1;

		// Constructor
		public SurveyIterator(SurveyCollection collection)
		{
			this._collection = collection;
		}

		// Gets first item
		public Survey First()
		{
			_current = 0;
			return _collection[_current] as Survey;
		}

		// Gets next item
		public Survey Next()
		{
			_current += _step;
			//if (!IsDone)
				return _collection[_current] as Survey;
			//else
				//return null;
		}

		// Gets or sets stepsize
		public int Step
		{
			get { return _step; }
			set { _step = value; }
		}

		// Gets current iterator item
		public Survey CurrentItem
		{
			get { return _collection[_current] as Survey; }
		}

		// Gets whether iteration is complete
		public bool IsDone
		{
			get { return _current >= _collection.Count - 1; }
		}
	}
}
