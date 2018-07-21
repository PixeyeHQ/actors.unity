/*===============================================================
Product:    UndercityRts
Developer:  Dimitry Pixeye - info@pixeye,games
Company:    Homebrew
Date:       7/19/2018 3:22 PM
================================================================*/


using System;
 
namespace Homebrew
{
	/// <summary>
	/// Basic interface for any entity
	/// </summary>
	public interface IEntity
	{
		ProcessingSignals GetSignals { get; }
		ProcessingTags GetTags { get; }
		Time GetTime { get; }
		object Get(Type t);
		T Get<T>();
		T Get<T>(int hash);
		T Get<T>(string path);
		bool Contains<T>();
		bool Contains(int hash);
		bool HasState(EntityState possibleState);
		void HandleDestroy();	
	}
}