using BepInEx;
using BerryLoaderNS;

namespace MakeFlint
{
	[BepInPlugin("MakeFlint", "Make Flint", "1.0.0")]
	[BepInDependency("BerryLoader")]
	class Plugin : BaseUnityPlugin
	{
		public static BepInEx.Logging.ManualLogSource L;

		private void Awake()
		{
			L = Logger;
			L.LogInfo("hello from MakeFlint.Plugin.Awake");
		}
	}
}