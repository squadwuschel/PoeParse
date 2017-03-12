﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeParse
{

    public class Rootobject
    {
        public string next_change_id { get; set; }
        public Stash[] stashes { get; set; }
    }

    public class Stash
    {
        public string accountName { get; set; }
        public string lastCharacterName { get; set; }
        public string id { get; set; }
        public string stash { get; set; }
        public string stashType { get; set; }
        public Item[] items { get; set; }
        public bool _public { get; set; }
    }

    public class Item
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public Socket[] sockets { get; set; }
        public string name { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        public bool lockedToCharacter { get; set; }
        public Property1[] properties { get; set; }
        public Requirement[] requirements { get; set; }
        public string[] explicitMods { get; set; }
        public int frameType { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public Socketeditem[] socketedItems { get; set; }
        public string[] implicitMods { get; set; }
        public int talismanTier { get; set; }
        public string[] flavourText { get; set; }
        public string[] utilityMods { get; set; }
        public string descrText { get; set; }
        public bool support { get; set; }
        public Additionalproperty1[] additionalProperties { get; set; }
        public string secDescrText { get; set; }
        public Nextlevelrequirement[] nextLevelRequirements { get; set; }
        public string[] craftedMods { get; set; }
        public string note { get; set; }
        public int stackSize { get; set; }
        public int maxStackSize { get; set; }
        public string artFilename { get; set; }
        public bool duplicated { get; set; }
    }

    public class Socket
    {
        public int group { get; set; }
        public string attr { get; set; }
    }

    public class Property1
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
        public int type { get; set; }
    }

    public class Requirement
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
    }

    public class Socketeditem
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public bool support { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public object[] sockets { get; set; }
        public string name { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        public bool lockedToCharacter { get; set; }
        public Property2[] properties { get; set; }
        public Additionalproperty[] additionalProperties { get; set; }
        public Requirement1[] requirements { get; set; }
        public string secDescrText { get; set; }
        public string[] explicitMods { get; set; }
        public string descrText { get; set; }
        public int frameType { get; set; }
        public int socket { get; set; }
        public string colour { get; set; }
        public object[] socketedItems { get; set; }
    }

    public class Property2
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
        public int type { get; set; }
    }

    public class Additionalproperty
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
        public float progress { get; set; }
    }

    public class Requirement1
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
    }

    public class Additionalproperty1
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
        public float progress { get; set; }
    }

    public class Nextlevelrequirement
    {
        public string name { get; set; }
        public object[][] values { get; set; }
        public int displayMode { get; set; }
    }

}
