/*===============================================================
Product:    Cryoshock
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       2/13/2018  11:02 PM
================================================================*/

using System;

namespace Homebrew
{
    [Flags]
    public enum EntityState
    {
        Visible = 1 << 0,
        Active = 1 << 1,
        Enabled = 1 << 2,
        Released = 1 << 3,
        RequireStarter = 1 << 4,
        RequireActorParent = 1 << 5,
        Initialized = 1 << 6,
        Disabled = 1<<7
    }

    public static partial class FrameworkExtensions
    {
        public static bool Contain(this EntityState state, EntityState possibleState)
        {
            return (state & possibleState) == possibleState;
        }
    }
}