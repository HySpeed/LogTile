using System;
using System.Collections.Generic;
using System.Net;

namespace LogTile
{
	public enum Action
	{
		ERROR = 0,
		PLACE = 1,
		BREAK = 2,
		OPEN_CHEST = 3,
		ROB_CHEST = 4
	};

	public class TileHelper
	{
		private Dictionary<int, String> itemNames = new Dictionary<int, String>();

		public TileHelper()
		{
			itemNames.Add(0x0,  "Dirt");
			itemNames.Add(0x1,  "Stone");
      itemNames.Add(0x2,  "Grass");
      itemNames.Add(0x3,  "Weeds");
      itemNames.Add(0x4,  "Torches");
      itemNames.Add(0x5,  "Logs");
      itemNames.Add(0x6,  "Iron");
      itemNames.Add(0x7,  "Copper");
      itemNames.Add(0x8,  "Gold");
      itemNames.Add(0x9,  "Silver");
      itemNames.Add(0x0A, "Closed Door");
      itemNames.Add(0x0B, "Open Door");
      itemNames.Add(0x0C, "Crystal Heart");
      itemNames.Add(0x0D, "Potions");
      itemNames.Add(0x0E, "Table");
      itemNames.Add(0x0F, "Chair");
      itemNames.Add(0x10, "Anvil");
      itemNames.Add(0x11, "Furnace");
      itemNames.Add(0x12, "Work Bench");
      itemNames.Add(0x13, "Plank");
      itemNames.Add(0x14, "Sappling");
      itemNames.Add(0x15, "Chest");
      itemNames.Add(0x16, "Corrupted Stone");
      itemNames.Add(0x17, "Corrupted Grass");
      itemNames.Add(0x18, "Corrupted Weeds");
      itemNames.Add(0x19, "Ebon Stone");
      itemNames.Add(0x1A, "Demon Alter");
      itemNames.Add(0x1B, "Sun Flower");
      itemNames.Add(0x1C, "Pot");
      itemNames.Add(0x1D, "Piggy Bank");
      itemNames.Add(0x1E, "Wood");
      itemNames.Add(0x1F, "Shadow Orb");
      itemNames.Add(0x20, "Corrupted Thorns");
      itemNames.Add(0x21, "Candle");
      itemNames.Add(0x22, "Copper Chandelier");
      itemNames.Add(0x23, "Silver Chandelier");
      itemNames.Add(0x24, "Gold Chandelier");
      itemNames.Add(0x25, "Meteorite");
      itemNames.Add(0x26, "Stone Brick");
      itemNames.Add(0x27, "Clay Brick");
      itemNames.Add(0x28, "Clay");
      itemNames.Add(0x29, "Blue Brick");
      itemNames.Add(0x2A, "Dungeon Light");
      itemNames.Add(0x2B, "Green Brick");
      itemNames.Add(0x2C, "Red Brick");
      itemNames.Add(0x2D, "Gold Brick");
      itemNames.Add(0x2E, "Silver Brick");
      itemNames.Add(0x2F, "Copper Brick");
      itemNames.Add(0x30, "Spikes");
      itemNames.Add(0x31, "Water Candle");
      itemNames.Add(0x32, "Books");
      itemNames.Add(0x33, "Cob Webs");
      itemNames.Add(0x34, "Vines");
      itemNames.Add(0x35, "Sand");
      itemNames.Add(0x36, "Glass");
      itemNames.Add(0x37, "Sign");
      itemNames.Add(0x38, "Obsidian");
      itemNames.Add(0x39, "Ash");
      itemNames.Add(0x3A, "Hellstone");
      itemNames.Add(0x3B, "Mud");
      itemNames.Add(0x3C, "Jungle Mud");
      itemNames.Add(0x3D, "Jungle Weeds");
      itemNames.Add(0x3E, "Jungle Vines");
      itemNames.Add(0x3F, "Sapphire");
      itemNames.Add(0x40, "Ruby");
      itemNames.Add(0x41, "Emerald");
      itemNames.Add(0x42, "Topaz");
      itemNames.Add(0x43, "Amethyst");
      itemNames.Add(0x44, "Diamond");
      itemNames.Add(0x45, "Thorns");
      itemNames.Add(0x46, "Glow Grass");
      itemNames.Add(0x47, "Mushrooms");
      itemNames.Add(0x48, "Giant Mushroom Stem");
      itemNames.Add(0x49, "Weeds");
      itemNames.Add(0x4A, "Jungle Flowers");
      itemNames.Add(0x4B, "Purple Brick");
      itemNames.Add(0x4C, "Hellstone Brick");
      itemNames.Add(0x4D, "Hellforge");
      itemNames.Add(0x4E, "Clay Pot");
      itemNames.Add(0x4F, "Bed");
      itemNames.Add(0x50, "Cactus");
      itemNames.Add(0x51, "Coral");
      itemNames.Add(0x52, "Herb Sprout");
      itemNames.Add(0x53, "Herb Stalk");
      itemNames.Add(0x54, "Herb");
      itemNames.Add(0x55, "Tombstone");
      itemNames.Add(0x56, "Loom");
      itemNames.Add(0x57, "Piano");
      itemNames.Add(0x58, "Dress");
      itemNames.Add(0x59, "Bench");
      itemNames.Add(0x5A, "Bathtub");
      itemNames.Add(0x5B, "Banner");
      itemNames.Add(0x5C, "Lamp Post");
      itemNames.Add(0x5D, "Tiki Torch");
      itemNames.Add(0x5E, "Keg");
      itemNames.Add(0x5F, "Chinese Lantern");
      itemNames.Add(0x60, "Pot");
      itemNames.Add(0x61, "Safe");
      itemNames.Add(0x62, "Skull Lantern");
      itemNames.Add(0x63, "Trash Can");
      itemNames.Add(0x64, "Candelabra");
      itemNames.Add(0x65, "Bookcase");
      itemNames.Add(0x66, "Throne");
      itemNames.Add(0x67, "Bowl");
      itemNames.Add(0x68, "Grandfather Clock");
      itemNames.Add(0x69, "Statue");
      itemNames.Add(0x6A, "Sawmill");
      itemNames.Add(0x6B, "Cobalt");
      itemNames.Add(0x6C, "Mythril");
      itemNames.Add(0x6D, "Hallow Grass");
      itemNames.Add(0x6E, "Hallow Flowers");
      itemNames.Add(0x6F, "Adamantite");
      itemNames.Add(0x70, "Corruption Sand");
      itemNames.Add(0x71, "Hallow Weeds");
      itemNames.Add(0x72, "Tinkerer's Workshop");
      itemNames.Add(0x73, "Hallow Vines");
      itemNames.Add(0x74, "Pearlsand");
      itemNames.Add(0x75, "Pearlstone");
      itemNames.Add(0x76, "Pearlstone Brick");
      itemNames.Add(0x77, "Iridescent Brick");
      itemNames.Add(0x78, "Mudstone Brick");
      itemNames.Add(0x79, "Cobalt Brick");
      itemNames.Add(0x7A, "Mythril Brick");
      itemNames.Add(0x7B, "Silt");
      itemNames.Add(0x7C, "Wooden Beam");
      itemNames.Add(0x7D, "Crystal Ball");
      itemNames.Add(0x7E, "Disco Ball");
      itemNames.Add(0x7F, "Ice");
      itemNames.Add(0x80, "Mannequin");
      itemNames.Add(0x81, "Crystal Shard");
      itemNames.Add(0x82, "Active Stone");
      itemNames.Add(0x83, "Inactive Stone");
      itemNames.Add(0x84, "Lever");
      itemNames.Add(0x85, "Adamantite Forge");
      itemNames.Add(0x86, "Mythril Anvil");
      itemNames.Add(0x87, "Pressure Plate");
      itemNames.Add(0x88, "Switch");
      itemNames.Add(0x89, "Dart Trap");
      itemNames.Add(0x8A, "Boulder");
      itemNames.Add(0x8B, "Music Box");
      itemNames.Add(0x8C, "Purple Brick");
      itemNames.Add(0x8D, "Explosives");
      itemNames.Add(0x8E, "Inlet Pump");
      itemNames.Add(0x8F, "Outlet Pump");
      itemNames.Add(0x90, "Timer");
      itemNames.Add(0x91, "Red Candy");
      itemNames.Add(0x92, "Green Candy");
      itemNames.Add(0x93, "Snow");
      itemNames.Add(0x94, "Snow Brick");
      itemNames.Add(0x95, "Christmas Light");
		}

		public String getItemName(int id)
		{
			String name = "";
			if (itemNames.TryGetValue(id, out name))
			{
				return name;
			}
			return "Error: Tile has no name, consider suggesting one on the forums!";
		}

		public int IPtoInt(String ip)
		{
			return BitConverter.ToInt32(IPAddress.Parse(ip).GetAddressBytes(), 0);
		}

		public String INTtoString(int ip)
		{
			return new IPAddress(BitConverter.GetBytes(ip)).ToString();
		}

		public Action getAction(int i)
		{
			switch (i)
			{
				case 1:
					return Action.PLACE;
				case 2:
					return Action.BREAK;
			}
			return Action.ERROR;
		}

		public int getActionType(Action a)
		{
			switch (a)
			{
				case Action.BREAK:
					return 2;
				case Action.PLACE:
					return 1;
			}
			return 0;
		}

		public long GetTime()
		{
			return (long) ((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds/1000);
		}
	}

	public class TileEvent : IEquatable<TileEvent>
	{
		private int x;
		private int y;
		private string name;
		private string ip;
		private int action;
		private int tileType;
		private long date;

		public TileEvent()
		{
			createEvent(0, 0, "", "", 0, 0, LogTile.helper.GetTime());
		}

		public TileEvent(int x, int y, string name, string ip, Action action, int tileType, long date)
		{
			createEvent(x, y, name, ip, action, tileType, date);
		}

		private void createEvent(int x, int y, String name, String ip, Action a, int tileType, long date)
		{
			this.x = x;
			this.y = y;
			this.name = name;
			this.ip = ip;
			this.action = LogTile.helper.getActionType(a);
			this.tileType = tileType;
			this.date = date;
		}

		public int GetX()
		{
			return x;
		}

		public int GetY()
		{
			return y;
		}

		public String GetName()
		{
			return name;
		}

		public String GetIP()
		{
			return ip;
		}

		public int GetAction()
		{
			return action;
		}

		public int GetTileType()
		{
			return tileType;
		}

		public long GetDate()
		{
			return date;
		}

		public String parseEvent()
		{
			String msg = "";
			msg += name + "(" + ip + ") ";
			msg += (action == 2 ? "broke " : "placed ");
			msg += LogTile.helper.getItemName(tileType);
			msg += " at (" + x + ", " + y + ") on ";
			msg += new DateTime(1970, 1, 1).AddMilliseconds(date*1000).ToString() + ".";
			return msg;
		}

		public bool Equals(TileEvent other)
		{
			if (this.x == other.GetX() && this.y == other.GetY())
			{
				return true;
			}
			return false;
		}
	}
}