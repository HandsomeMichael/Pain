using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace Pain
{
	public class Pain : Mod
	{
		public override void Load() {
			if (!Main.dedServ) {
				Main.tileSolid[TileID.Trees] = true;
			}
		}
		public override void Unload() {
			if (!Main.dedServ) {
				Main.tileSolid[TileID.Trees] = false;
				Main.tileSolid[TileID.Cactus] = false;
			}
		}
	}
}