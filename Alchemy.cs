using BepInEx;
using BerryLoaderNS;

namespace Alchemy
{
	[BepInPlugin("Alchemy", "Alchemy", "0.0.1")]
	[BepInDependency("BerryLoader")]
	class Plugin : BaseUnityPlugin
	{
		public static BepInEx.Logging.ManualLogSource L;

		private void Awake()
		{
			L = Logger;
			L.LogInfo("hello from Alchemy.Plugin.Awake");
		}
	}
}