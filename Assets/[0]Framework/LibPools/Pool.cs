/*===============================================================
Product:    Battlecruiser
Developer:  Dimitry Pixeye - pixeye@hbrew.store
Company:    Homebrew - http://hbrew.store
Date:       05/07/2017 20:39
================================================================*/

namespace Homebrew
{
    public static class Pool
    {
        [TagField(categoryName = "Pool")]
        public const int None = 0;
        [TagField(categoryName = "Pool")]
        public const int Entities = 1;
        [TagField(categoryName = "Pool")]
        public const int Projectiles = 2;
        [TagField(categoryName = "Pool")]
        public const int UI = 3;
        [TagField(categoryName = "Pool")]
        public const int Audio = 4;
    }
}