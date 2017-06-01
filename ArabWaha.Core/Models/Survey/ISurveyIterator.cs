using System;

namespace ArabWaha
{
	public interface ISurveyIterator
	{
		Survey First();
		Survey Next();
		bool IsDone { get; }
		Survey CurrentItem { get; }
	}
}
