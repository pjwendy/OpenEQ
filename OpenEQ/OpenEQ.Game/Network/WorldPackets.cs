/*
*       o__ __o       o__ __o__/_   o          o    o__ __o__/_   o__ __o                o    ____o__ __o____   o__ __o__/_   o__ __o      
*      /v     v\     <|    v       <|\        <|>  <|    v       <|     v\              <|>    /   \   /   \   <|    v       <|     v\     
*     />       <\    < >           / \o      / \  < >           / \     <\             / \         \o/        < >           / \     <\    
*   o/                |            \o/ v\     \o/   |            \o/     o/           o/   \o        |          |            \o/       \o  
*  <|       _\__o__   o__/_         |   <\     |    o__/_         |__  _<|           <|__ __|>      < >         o__/_         |         |> 
*   \          |     |            / \    \o  / \   |             |       \          /       \       |          |            / \       //  
*     \         /    <o>           \o/     v\ \o/  <o>           <o>       \o      o/         \o     o         <o>           \o/      /    
*      o       o      |             |       <\ |    |             |         v\    /v           v\   <|          |             |      o     
*      <\__ __/>     / \  _\o__/_  / \        < \  / \  _\o__/_  / \         <\  />             <\  / \        / \  _\o__/_  / \  __/>     
*
* THIS FILE IS GENERATED BY structgen.py/structs.yml
* DO NOT EDIT
*
*/
using System.Collections.Generic;
using System.IO;

namespace OpenEQ.Network {
	public struct CharacterSelect : IEQStruct {
		uint charCount;
		uint totalChars;
		public List<CharacterSelectEntry> Characters;

		public CharacterSelect(List<CharacterSelectEntry> Characters) : this() {
			this.Characters = Characters;
		}

		public CharacterSelect(byte[] data, int offset = 0) : this() {
			Unpack(data, offset);
		}
		public CharacterSelect(BinaryReader br) : this() {
			Unpack(br);
		}
		public void Unpack(byte[] data, int offset = 0) {
			using(var ms = new MemoryStream(data, offset, data.Length - offset)) {
				using(var br = new BinaryReader(ms)) {
					Unpack(br);
				}
			}
		}
		public void Unpack(BinaryReader br) {
			charCount = br.ReadUInt32();
			totalChars = br.ReadUInt32();
			Characters = new List<CharacterSelectEntry>();
			for(var i = 0; i < charCount; ++i) {
				Characters.Add(new CharacterSelectEntry(br));
			}
		}

		public byte[] Pack() {
			using(var ms = new MemoryStream()) {
				using(var bw = new BinaryWriter(ms)) {
					Pack(bw);
					return ms.ToArray();
				}
			}
		}
		public void Pack(BinaryWriter bw) {
			bw.Write(charCount);
			bw.Write(totalChars);
			for(var i = 0; i < charCount; ++i) {
				Characters[i].Pack(bw);
			}
		}
	}

	public struct EnterWorld : IEQStruct {
		public string Name;
		public bool Tutorial;
		public bool GoHome;

		public EnterWorld(string Name, bool Tutorial, bool GoHome) : this() {
			this.Name = Name;
			this.Tutorial = Tutorial;
			this.GoHome = GoHome;
		}

		public EnterWorld(byte[] data, int offset = 0) : this() {
			Unpack(data, offset);
		}
		public EnterWorld(BinaryReader br) : this() {
			Unpack(br);
		}
		public void Unpack(byte[] data, int offset = 0) {
			using(var ms = new MemoryStream(data, offset, data.Length - offset)) {
				using(var br = new BinaryReader(ms)) {
					Unpack(br);
				}
			}
		}
		public void Unpack(BinaryReader br) {
			Name = br.ReadString(64);
			Tutorial = br.ReadByte() != 0;
			GoHome = br.ReadByte() != 0;
		}

		public byte[] Pack() {
			using(var ms = new MemoryStream()) {
				using(var bw = new BinaryWriter(ms)) {
					Pack(bw);
					return ms.ToArray();
				}
			}
		}
		public void Pack(BinaryWriter bw) {
			bw.Write(Name.ToBytes(64));
			bw.Write((byte) (Tutorial ? 1 : 0));
			bw.Write((byte) (GoHome ? 1 : 0));
		}
	}

	public struct ZoneServerInfo : IEQStruct {
		public string Host;
		public ushort Port;

		public ZoneServerInfo(string Host, ushort Port) : this() {
			this.Host = Host;
			this.Port = Port;
		}

		public ZoneServerInfo(byte[] data, int offset = 0) : this() {
			Unpack(data, offset);
		}
		public ZoneServerInfo(BinaryReader br) : this() {
			Unpack(br);
		}
		public void Unpack(byte[] data, int offset = 0) {
			using(var ms = new MemoryStream(data, offset, data.Length - offset)) {
				using(var br = new BinaryReader(ms)) {
					Unpack(br);
				}
			}
		}
		public void Unpack(BinaryReader br) {
			Host = br.ReadString(128);
			Port = br.ReadUInt16();
		}

		public byte[] Pack() {
			using(var ms = new MemoryStream()) {
				using(var bw = new BinaryWriter(ms)) {
					Pack(bw);
					return ms.ToArray();
				}
			}
		}
		public void Pack(BinaryWriter bw) {
			bw.Write(Host.ToBytes(128));
			bw.Write(Port);
		}
	}

	public struct CharacterSelectEntry : IEQStruct {
		public byte Level;
		public byte HairStyle;
		public bool Gender;
		public string Name;
		public byte Beard;
		public byte HairColor;
		public byte Face;
		byte[] equipment;
		public uint PrimaryID;
		public uint SecondaryID;
		byte unknown15;
		public uint Deity;
		public ushort Zone;
		public ushort Instance;
		public bool GoHome;
		byte unknown19;
		public uint Race;
		public bool Tutorial;
		public byte Class;
		public byte EyeColor1;
		public byte BeardColor;
		public byte EyeColor2;
		public uint DrakkinHeritage;
		public uint DrakkinTattoo;
		public uint DrakkinDetails;
		byte unknown;

		public CharacterSelectEntry(byte Level, byte HairStyle, bool Gender, string Name, byte Beard, byte HairColor, byte Face, uint PrimaryID, uint SecondaryID, uint Deity, ushort Zone, ushort Instance, bool GoHome, uint Race, bool Tutorial, byte Class, byte EyeColor1, byte BeardColor, byte EyeColor2, uint DrakkinHeritage, uint DrakkinTattoo, uint DrakkinDetails) : this() {
			this.Level = Level;
			this.HairStyle = HairStyle;
			this.Gender = Gender;
			this.Name = Name;
			this.Beard = Beard;
			this.HairColor = HairColor;
			this.Face = Face;
			this.PrimaryID = PrimaryID;
			this.SecondaryID = SecondaryID;
			this.Deity = Deity;
			this.Zone = Zone;
			this.Instance = Instance;
			this.GoHome = GoHome;
			this.Race = Race;
			this.Tutorial = Tutorial;
			this.Class = Class;
			this.EyeColor1 = EyeColor1;
			this.BeardColor = BeardColor;
			this.EyeColor2 = EyeColor2;
			this.DrakkinHeritage = DrakkinHeritage;
			this.DrakkinTattoo = DrakkinTattoo;
			this.DrakkinDetails = DrakkinDetails;
		}

		public CharacterSelectEntry(byte[] data, int offset = 0) : this() {
			Unpack(data, offset);
		}
		public CharacterSelectEntry(BinaryReader br) : this() {
			Unpack(br);
		}
		public void Unpack(byte[] data, int offset = 0) {
			using(var ms = new MemoryStream(data, offset, data.Length - offset)) {
				using(var br = new BinaryReader(ms)) {
					Unpack(br);
				}
			}
		}
		public void Unpack(BinaryReader br) {
			Level = br.ReadByte();
			HairStyle = br.ReadByte();
			Gender = br.ReadByte() != 0;
			Name = br.ReadString(-1);
			Beard = br.ReadByte();
			HairColor = br.ReadByte();
			Face = br.ReadByte();
			equipment = new byte[9 * 4 * 4];
			for(var i = 0; i < 9 * 4 * 4; ++i) {
				equipment[i] = br.ReadByte();
			}
			PrimaryID = br.ReadUInt32();
			SecondaryID = br.ReadUInt32();
			unknown15 = br.ReadByte();
			Deity = br.ReadUInt32();
			Zone = br.ReadUInt16();
			Instance = br.ReadUInt16();
			GoHome = br.ReadByte() != 0;
			unknown19 = br.ReadByte();
			Race = br.ReadUInt32();
			Tutorial = br.ReadByte() != 0;
			Class = br.ReadByte();
			EyeColor1 = br.ReadByte();
			BeardColor = br.ReadByte();
			EyeColor2 = br.ReadByte();
			DrakkinHeritage = br.ReadUInt32();
			DrakkinTattoo = br.ReadUInt32();
			DrakkinDetails = br.ReadUInt32();
			unknown = br.ReadByte();
		}

		public byte[] Pack() {
			using(var ms = new MemoryStream()) {
				using(var bw = new BinaryWriter(ms)) {
					Pack(bw);
					return ms.ToArray();
				}
			}
		}
		public void Pack(BinaryWriter bw) {
			bw.Write(Level);
			bw.Write(HairStyle);
			bw.Write((byte) (Gender ? 1 : 0));
			bw.Write(Name.ToBytes());
			bw.Write(Beard);
			bw.Write(HairColor);
			bw.Write(Face);
			for(var i = 0; i < 9 * 4 * 4; ++i) {
				bw.Write(equipment[i]);
			}
			bw.Write(PrimaryID);
			bw.Write(SecondaryID);
			bw.Write(unknown15);
			bw.Write(Deity);
			bw.Write(Zone);
			bw.Write(Instance);
			bw.Write((byte) (GoHome ? 1 : 0));
			bw.Write(unknown19);
			bw.Write(Race);
			bw.Write((byte) (Tutorial ? 1 : 0));
			bw.Write(Class);
			bw.Write(EyeColor1);
			bw.Write(BeardColor);
			bw.Write(EyeColor2);
			bw.Write(DrakkinHeritage);
			bw.Write(DrakkinTattoo);
			bw.Write(DrakkinDetails);
			bw.Write(unknown);
		}
	}
}
