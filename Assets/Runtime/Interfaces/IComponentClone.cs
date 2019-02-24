//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

namespace Pixeye
{
	public interface IComponentClone
	{
		void AsClone(ref EntityComposer c);
		void AsRef(ref EntityComposer c);
	}

	public interface IDataClone
	{
		
	}
	
}