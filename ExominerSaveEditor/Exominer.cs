namespace Exominer
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ExominerSave
    {
        [JsonProperty("SaveNumber")]
        public long SaveNumber { get; set; }

        [JsonProperty("Version")]
        public long Version { get; set; }

        [JsonProperty("Planet")]
        public long Planet { get; set; }

        [JsonProperty("Rank")]
        public long Rank { get; set; }

        [JsonProperty("RankUp")]
        public bool RankUp { get; set; }

        [JsonProperty("ExplorerTier")]
        public long ExplorerTier { get; set; }

        [JsonProperty("DepositMineRate")]
        public double DepositMineRate { get; set; }

        [JsonProperty("DepositShipCargo")]
        public double DepositShipCargo { get; set; }

        [JsonProperty("DepositShipSpeed")]
        public double DepositShipSpeed { get; set; }

        [JsonProperty("Smelter")]
        public bool Smelter { get; set; }

        [JsonProperty("Crafter")]
        public bool Crafter { get; set; }

        [JsonProperty("Smelters")]
        public object[] Smelters { get; set; }

        [JsonProperty("Crafters")]
        public object[] Crafters { get; set; }

        [JsonProperty("SmelterTime")]
        public double SmelterTime { get; set; }

        [JsonProperty("SmeltersTime")]
        public object[] SmeltersTime { get; set; }

        [JsonProperty("CrafterTime")]
        public double CrafterTime { get; set; }

        [JsonProperty("CraftersTime")]
        public object[] CraftersTime { get; set; }

        [JsonProperty("OreValue")]
        public long OreValue { get; set; }

        [JsonProperty("AlloyValue")]
        public double AlloyValue { get; set; }

        [JsonProperty("ItemsValue")]
        public double ItemsValue { get; set; }

        [JsonProperty("SmelterQuantity")]
        public long SmelterQuantity { get; set; }

        [JsonProperty("CrafterQuantity")]
        public long CrafterQuantity { get; set; }

        [JsonProperty("SmelterDouble")]
        public long SmelterDouble { get; set; }

        [JsonProperty("CrafterDouble")]
        public long CrafterDouble { get; set; }

        [JsonProperty("SmelterLevel")]
        public long SmelterLevel { get; set; }

        [JsonProperty("SmeltersLevel")]
        public object[] SmeltersLevel { get; set; }

        [JsonProperty("CrafterLevel")]
        public long CrafterLevel { get; set; }

        [JsonProperty("CraftersLevel")]
        public object[] CraftersLevel { get; set; }

        [JsonProperty("CrafterModel")]
        public long CrafterModel { get; set; }

        [JsonProperty("SmelterModel")]
        public long SmelterModel { get; set; }

        [JsonProperty("IndustrialVacuumSealer")]
        public bool IndustrialVacuumSealer { get; set; }

        [JsonProperty("SmelterPackager")]
        public bool SmelterPackager { get; set; }

        [JsonProperty("CrafterRecycler")]
        public bool CrafterRecycler { get; set; }

        [JsonProperty("SmelterRecycler")]
        public bool SmelterRecycler { get; set; }

        [JsonProperty("SmeltingSpecialist")]
        public bool SmeltingSpecialist { get; set; }

        [JsonProperty("CraftingSpecialist")]
        public bool CraftingSpecialist { get; set; }

        [JsonProperty("Wallet")]
        public Wallet Wallet { get; set; }

        [JsonProperty("Resources")]
        public Resources Resources { get; set; }

        [JsonProperty("Production")]
        public Production Production { get; set; }

        [JsonProperty("Deposits")]
        public SelectedDeposit[] Deposits { get; set; }

        [JsonProperty("Astronauts")]
        public SelectedDeposit[] Astronauts { get; set; }

        [JsonProperty("Research")]
        public Research Research { get; set; }

        [JsonProperty("Boosts")]
        public Boost[] Boosts { get; set; }

        [JsonProperty("Missions")]
        public Mission[] Missions { get; set; }

        [JsonProperty("Store")]
        public Store Store { get; set; }

        [JsonProperty("RewardedAd")]
        public RewardedAd RewardedAd { get; set; }

        [JsonProperty("DailyReward")]
        public DailyReward DailyReward { get; set; }

        [JsonProperty("CrateAd")]
        public CrateAd CrateAd { get; set; }

        [JsonProperty("Tutorials")]
        public Tutorial[] Tutorials { get; set; }

        [JsonProperty("ServerStartTime")]
        public double ServerStartTime { get; set; }

        [JsonProperty("DeviceStartTime")]
        public double DeviceStartTime { get; set; }

        [JsonProperty("DevicePlayTime")]
        public long DevicePlayTime { get; set; }

        [JsonProperty("ServerPlayTime")]
        public long ServerPlayTime { get; set; }

        [JsonProperty("DeltaTime")]
        public long DeltaTime { get; set; }

        [JsonProperty("Mute")]
        public bool Mute { get; set; }

        [JsonProperty("ShowRateMe")]
        public bool ShowRateMe { get; set; }

        [JsonProperty("ShowIntroduction")]
        public bool ShowIntroduction { get; set; }

        [JsonProperty("IdleTime")]
        public double IdleTime { get; set; }

        [JsonProperty("FreeCommonCrates")]
        public long FreeCommonCrates { get; set; }

        [JsonProperty("FreeEpicCrates")]
        public long FreeEpicCrates { get; set; }

        [JsonProperty("FreeLegendaryCrates")]
        public long FreeLegendaryCrates { get; set; }

        [JsonProperty("RemoveAds")]
        public bool RemoveAds { get; set; }

        [JsonProperty("SelectedDeposit")]
        public SelectedDeposit SelectedDeposit { get; set; }

        [JsonProperty("Fog")]
        public object[] Fog { get; set; }

        [JsonProperty("fogOfWarTransform")]
        public FogOfWarTransform FogOfWarTransform { get; set; }

        [JsonProperty("specialOffersCount")]
        public long SpecialOffersCount { get; set; }

        [JsonProperty("_ship")]
        public string Ship { get; set; }

        [JsonProperty("_planetValue")]
        public long PlanetValue { get; set; }

        [JsonProperty("_planetValueLarge")]
        public double PlanetValueLarge { get; set; }

        [JsonProperty("references")]
        public References References { get; set; }
    }

    public partial class SelectedDeposit
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class Boost
    {
        [JsonProperty("Reset")]
        public bool Reset { get; set; }

        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("Ticks")]
        public long Ticks { get; set; }

        [JsonProperty("_boost")]
        public string BoostBoost { get; set; }
    }

    public partial class CrateAd
    {
        [JsonProperty("lastAdSeen")]
        public string LastAdSeen { get; set; }
    }

    public partial class DailyReward
    {
        [JsonProperty("lastClaimTicks")]
        public double LastClaimTicks { get; set; }

        [JsonProperty("streak")]
        public long Streak { get; set; }
    }

    public partial class FogOfWarTransform
    {
        [JsonProperty("m_FileID")]
        public long MFileId { get; set; }

        [JsonProperty("m_PathID")]
        public long MPathId { get; set; }
    }

    public partial class Mission
    {
        [JsonProperty("Completed")]
        public bool Completed { get; set; }

        [JsonProperty("Claimed")]
        public bool Claimed { get; set; }

        [JsonProperty("Objective")]
        public SelectedDeposit Objective { get; set; }

        [JsonProperty("_mission")]
        public string MissionMission { get; set; }
    }

    public partial class Production
    {
        [JsonProperty("Smelting")]
        public Ting[] Smelting { get; set; }

        [JsonProperty("Crafting")]
        public Ting[] Crafting { get; set; }

        [JsonProperty("UnlockedAlloys")]
        public long UnlockedAlloys { get; set; }

        [JsonProperty("UnlockedItems")]
        public long UnlockedItems { get; set; }
    }

    public partial class Ting
    {
        [JsonProperty("Ticks")]
        public long Ticks { get; set; }

        [JsonProperty("Working")]
        public bool Working { get; set; }

        [JsonProperty("_type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("_recipe")]
        public string Recipe { get; set; }
    }

    public partial class References
    {
        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("00000000")]
        public The00000000_Class The00000000 { get; set; }

        [JsonProperty("00000001")]
        public The00000000_Class The00000001 { get; set; }

        [JsonProperty("00000002")]
        public The00000000_Class The00000002 { get; set; }

        [JsonProperty("00000003")]
        public The00000000_Class The00000003 { get; set; }

        [JsonProperty("00000004")]
        public The00000000_Class The00000004 { get; set; }

        [JsonProperty("00000005")]
        public The00000000_Class The00000005 { get; set; }

        [JsonProperty("00000006")]
        public The00000000_Class The00000006 { get; set; }

        [JsonProperty("00000007")]
        public The00000000_Class The00000007 { get; set; }

        [JsonProperty("00000008")]
        public The00000000_Class The00000008 { get; set; }

        [JsonProperty("00000009")]
        public The00000000_Class The00000009 { get; set; }

        [JsonProperty("0000000A")]
        public The00000000_Class The0000000A { get; set; }

        [JsonProperty("0000000B")]
        public The00000000_Class The0000000B { get; set; }

        [JsonProperty("0000000C")]
        public The00000000_Class The0000000C { get; set; }

        [JsonProperty("0000000D")]
        public The00000000_Class The0000000D { get; set; }

        [JsonProperty("0000000E")]
        public The00000000_Class The0000000E { get; set; }

        [JsonProperty("0000000F")]
        public The00000000_Class The0000000F { get; set; }

        [JsonProperty("00000010")]
        public The00000000_Class The00000010 { get; set; }

        [JsonProperty("00000011")]
        public The00000000_Class The00000011 { get; set; }

        [JsonProperty("00000012")]
        public The00000000_Class The00000012 { get; set; }

        [JsonProperty("00000013")]
        public The00000000_Class The00000013 { get; set; }

        [JsonProperty("00000014")]
        public The00000000_Class The00000014 { get; set; }

        [JsonProperty("00000015")]
        public The00000000_Class The00000015 { get; set; }

        [JsonProperty("00000016")]
        public The00000016_Class The00000016 { get; set; }

        [JsonProperty("00000017")]
        public The00000016_Class The00000017 { get; set; }

        [JsonProperty("00000018")]
        public The00000016_Class The00000018 { get; set; }

        [JsonProperty("00000019")]
        public The00000016_Class The00000019 { get; set; }

        [JsonProperty("0000001A")]
        public The00000016_Class The0000001A { get; set; }

        [JsonProperty("0000001B")]
        public The00000016_Class The0000001B { get; set; }

        [JsonProperty("0000001C")]
        public The00000016_Class The0000001C { get; set; }

        [JsonProperty("0000001D")]
        public The00000016_Class The0000001D { get; set; }

        [JsonProperty("0000001E")]
        public The00000016_Class The0000001E { get; set; }

        [JsonProperty("0000001F")]
        public The00000016_Class The0000001F { get; set; }

        [JsonProperty("00000020")]
        public The00000016_Class The00000020 { get; set; }

        [JsonProperty("00000021")]
        public The00000016_Class The00000021 { get; set; }

        [JsonProperty("00000022")]
        public The00000016_Class The00000022 { get; set; }

        [JsonProperty("00000023")]
        public The00000016_Class The00000023 { get; set; }

        [JsonProperty("00000024")]
        public The00000016_Class The00000024 { get; set; }

        [JsonProperty("00000025")]
        public The00000016_Class The00000025 { get; set; }

        [JsonProperty("00000026")]
        public The00000016_Class The00000026 { get; set; }

        [JsonProperty("00000027")]
        public The00000016_Class The00000027 { get; set; }

        [JsonProperty("00000028")]
        public The00000016_Class The00000028 { get; set; }

        [JsonProperty("00000029")]
        public The00000016_Class The00000029 { get; set; }

        [JsonProperty("0000002A")]
        public The0000002AClass The0000002A { get; set; }

        [JsonProperty("0000002B")]
        public The0000002AClass The0000002B { get; set; }

        [JsonProperty("0000002C")]
        public The0000002AClass The0000002C { get; set; }

        [JsonProperty("0000002D")]
        public The0000002DClass The0000002D { get; set; }

        [JsonProperty("0000002E")]
        public The0000002DClass The0000002E { get; set; }
    }

    public partial class The00000000_Class
    {
        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("data")]
        public The00000000_Data Data { get; set; }
    }

    public partial class The00000000_Data
    {
        [JsonProperty("Position")]
        public Position Position { get; set; }

        [JsonProperty("Angle")]
        public long Angle { get; set; }

        [JsonProperty("Purchased")]
        public bool Purchased { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }

        [JsonProperty("Transport")]
        public Transport Transport { get; set; }

        [JsonProperty("Ticks")]
        public long[] Ticks { get; set; }

        [JsonProperty("Mined")]
        public Mined[] Mined { get; set; }

        [JsonProperty("MineRateLevel")]
        public long MineRateLevel { get; set; }

        [JsonProperty("ShipSpeedLevel")]
        public long ShipSpeedLevel { get; set; }

        [JsonProperty("ShipCargoLevel")]
        public long ShipCargoLevel { get; set; }

        [JsonProperty("MineRateX")]
        public double MineRateX { get; set; }

        [JsonProperty("ShipSpeedX")]
        public double ShipSpeedX { get; set; }

        [JsonProperty("ShipCargoX")]
        public double ShipCargoX { get; set; }

        [JsonProperty("DeployedAstronaut")]
        public long DeployedAstronaut { get; set; }

        [JsonProperty("overdriveEndTrigger")]
        public bool OverdriveEndTrigger { get; set; }

        [JsonProperty("_deposit")]
        public string Deposit { get; set; }
    }

    public partial class Mined
    {
        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("_ore")]
        public string Ore { get; set; }
    }

    public partial class Position
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }
    }

    public partial class Transport
    {
        [JsonProperty("Ticks")]
        public long Ticks { get; set; }

        [JsonProperty("Position")]
        public double Position { get; set; }

        [JsonProperty("Loaded")]
        public bool Loaded { get; set; }

        [JsonProperty("Ores")]
        public Mined[] Ores { get; set; }
    }

    public partial class TypeClass
    {
        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("ns")]
        public Ns Ns { get; set; }

        [JsonProperty("asm")]
        public Asm Asm { get; set; }
    }

    public partial class The00000016_Class
    {
        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("data")]
        public The00000016_Data Data { get; set; }
    }

    public partial class The00000016_Data
    {
        [JsonProperty("_astronaut")]
        public string Astronaut { get; set; }

        [JsonProperty("_collected")]
        public bool Collected { get; set; }

        [JsonProperty("_deployed")]
        public bool Deployed { get; set; }

        [JsonProperty("_level")]
        public long Level { get; set; }

        [JsonProperty("_associatedDepositNumber")]
        public long AssociatedDepositNumber { get; set; }

        [JsonProperty("_cardsOwned")]
        public long CardsOwned { get; set; }

        [JsonProperty("_totalCardsOwned")]
        public long TotalCardsOwned { get; set; }
    }

    public partial class The0000002AClass
    {
        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("data")]
        public The0000002AData Data { get; set; }
    }

    public partial class The0000002AData
    {
        [JsonProperty("_amount")]
        public long Amount { get; set; }
    }

    public partial class The0000002DClass
    {
        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("data")]
        public The0000002DData Data { get; set; }
    }

    public partial class The0000002DData
    {
    }

    public partial class Research
    {
        [JsonProperty("_researched")]
        public string[] Researched { get; set; }
    }

    public partial class Resources
    {
        [JsonProperty("Ores")]
        public Ore[] Ores { get; set; }

        [JsonProperty("Alloys")]
        public Alloy[] Alloys { get; set; }

        [JsonProperty("Items")]
        public Alloy[] Items { get; set; }
    }

    public partial class Alloy
    {
        [JsonProperty("_type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("_auto")]
        public bool Auto { get; set; }

        [JsonProperty("_amount")]
        public long Amount { get; set; }

        [JsonProperty("_recipe")]
        public string Recipe { get; set; }
    }

    public partial class Ore
    {
        [JsonProperty("Amount")]
        public long Amount { get; set; }

        [JsonProperty("_ore")]
        public string OreOre { get; set; }

        [JsonProperty("_auto")]
        public bool Auto { get; set; }
    }

    public partial class RewardedAd
    {
        [JsonProperty("lastAdSeen")]
        public string LastAdSeen { get; set; }

        [JsonProperty("noOfAdsShownInADay")]
        public long NoOfAdsShownInADay { get; set; }
    }

    public partial class Store
    {
        [JsonProperty("currencyProductStates")]
        public State[] CurrencyProductStates { get; set; }

        [JsonProperty("packageProductState")]
        public State[] PackageProductState { get; set; }

        [JsonProperty("freeRelicsStates")]
        public State[] FreeRelicsStates { get; set; }

        [JsonProperty("sciencePointsStates")]
        public State[] SciencePointsStates { get; set; }

        [JsonProperty("astronautProductStates")]
        public State[] AstronautProductStates { get; set; }

        [JsonProperty("slAstronautPackageStates")]
        public State[] SlAstronautPackageStates { get; set; }

        [JsonProperty("noAdsProductState")]
        public State[] NoAdsProductState { get; set; }

        [JsonProperty("firstLogin")]
        public string FirstLogin { get; set; }

        [JsonProperty("usedPromoPackages")]
        public object[] UsedPromoPackages { get; set; }
    }

    public partial class State
    {
        [JsonProperty("_product")]
        public FogOfWarTransform Product { get; set; }

        [JsonProperty("_isPurchased")]
        public bool IsPurchased { get; set; }

        [JsonProperty("_isSpecialOfferPurchased")]
        public bool IsSpecialOfferPurchased { get; set; }

        [JsonProperty("_timeOfActivation")]
        public TimeOfActivation TimeOfActivation { get; set; }

        [JsonProperty("_lastTimeSpecialOfferActive")]
        public string LastTimeSpecialOfferActive { get; set; }

        [JsonProperty("_specialOfferConfig")]
        public SpecialOfferConfig SpecialOfferConfig { get; set; }

        [JsonProperty("_hasPopupShown")]
        public bool HasPopupShown { get; set; }

        [JsonProperty("_productPrefix")]
        public string ProductPrefix { get; set; }

        [JsonProperty("_astronautNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? AstronautNumber { get; set; }

        [JsonProperty("_freeRelicsAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? FreeRelicsAmount { get; set; }

        [JsonProperty("_packageShownInStore", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PackageShownInStore { get; set; }

        [JsonProperty("_isSpecialOfferShownOnce", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSpecialOfferShownOnce { get; set; }
    }

    public partial class SpecialOfferConfig
    {
        [JsonProperty("_firstTriggerTime")]
        public long FirstTriggerTime { get; set; }

        [JsonProperty("_intervalBetweenOffers")]
        public long IntervalBetweenOffers { get; set; }

        [JsonProperty("_availableTime")]
        public long AvailableTime { get; set; }
    }

    public partial class Tutorial
    {
        [JsonProperty("IsComplete")]
        public bool IsComplete { get; set; }

        [JsonProperty("_tutorialPrefix")]
        public string TutorialPrefix { get; set; }
    }

    public partial class Wallet
    {
        [JsonProperty("SoftCurrency")]
        public double SoftCurrency { get; set; }

        [JsonProperty("HardCurrency")]
        public long HardCurrency { get; set; }

        [JsonProperty("SciencePoints")]
        public long SciencePoints { get; set; }
    }

    public enum TypeEnum { Aid, Iid };

    public enum Asm { AssemblyCSharp, Empty, FakeAsm };

    public enum Class { AstronautState, DepositState, Empty, ObtainResourceState, Terminus };

    public enum Ns { Empty, ExoMinerState, ExoMinerStateMissions, UnityEngineDmat };

    public enum TimeOfActivation { The0101000100000, The01010001000000, The2003202390910, The22032023140138 };

    public partial class ExominerSave
    {
        public static ExominerSave FromJson(string json) => JsonConvert.DeserializeObject<ExominerSave>(json, Exominer.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ExominerSave self) => JsonConvert.SerializeObject(self, Exominer.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                TimeOfActivationConverter.Singleton,
                AsmConverter.Singleton,
                ClassConverter.Singleton,
                NsConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AID":
                    return TypeEnum.Aid;
                case "IID":
                    return TypeEnum.Iid;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Aid:
                    serializer.Serialize(writer, "AID");
                    return;
                case TypeEnum.Iid:
                    serializer.Serialize(writer, "IID");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class TimeOfActivationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimeOfActivation) || t == typeof(TimeOfActivation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "01.01.0001 0:00:00":
                    return TimeOfActivation.The0101000100000;
                case "01/01/0001 00:00:00":
                    return TimeOfActivation.The01010001000000;
                case "20.03.2023 9:09:10":
                    return TimeOfActivation.The2003202390910;
                case "22.03.2023 14:01:38":
                    return TimeOfActivation.The22032023140138;
            }
            throw new Exception("Cannot unmarshal type TimeOfActivation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TimeOfActivation)untypedValue;
            switch (value)
            {
                case TimeOfActivation.The0101000100000:
                    serializer.Serialize(writer, "01.01.0001 0:00:00");
                    return;
                case TimeOfActivation.The01010001000000:
                    serializer.Serialize(writer, "01/01/0001 00:00:00");
                    return;
                case TimeOfActivation.The2003202390910:
                    serializer.Serialize(writer, "20.03.2023 9:09:10");
                    return;
                case TimeOfActivation.The22032023140138:
                    serializer.Serialize(writer, "22.03.2023 14:01:38");
                    return;
            }
            throw new Exception("Cannot marshal type TimeOfActivation");
        }

        public static readonly TimeOfActivationConverter Singleton = new TimeOfActivationConverter();
    }

    internal class AsmConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Asm) || t == typeof(Asm?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Asm.Empty;
                case "Assembly-CSharp":
                    return Asm.AssemblyCSharp;
                case "FAKE_ASM":
                    return Asm.FakeAsm;
            }
            throw new Exception("Cannot unmarshal type Asm");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Asm)untypedValue;
            switch (value)
            {
                case Asm.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Asm.AssemblyCSharp:
                    serializer.Serialize(writer, "Assembly-CSharp");
                    return;
                case Asm.FakeAsm:
                    serializer.Serialize(writer, "FAKE_ASM");
                    return;
            }
            throw new Exception("Cannot marshal type Asm");
        }

        public static readonly AsmConverter Singleton = new AsmConverter();
    }

    internal class ClassConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Class) || t == typeof(Class?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Class.Empty;
                case "AstronautState":
                    return Class.AstronautState;
                case "DepositState":
                    return Class.DepositState;
                case "ObtainResourceState":
                    return Class.ObtainResourceState;
                case "Terminus":
                    return Class.Terminus;
            }
            throw new Exception("Cannot unmarshal type Class");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Class)untypedValue;
            switch (value)
            {
                case Class.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Class.AstronautState:
                    serializer.Serialize(writer, "AstronautState");
                    return;
                case Class.DepositState:
                    serializer.Serialize(writer, "DepositState");
                    return;
                case Class.ObtainResourceState:
                    serializer.Serialize(writer, "ObtainResourceState");
                    return;
                case Class.Terminus:
                    serializer.Serialize(writer, "Terminus");
                    return;
            }
            throw new Exception("Cannot marshal type Class");
        }

        public static readonly ClassConverter Singleton = new ClassConverter();
    }

    internal class NsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ns) || t == typeof(Ns?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Ns.Empty;
                case "ExoMiner.State":
                    return Ns.ExoMinerState;
                case "ExoMiner.State.Missions":
                    return Ns.ExoMinerStateMissions;
                case "UnityEngine.DMAT":
                    return Ns.UnityEngineDmat;
            }
            throw new Exception("Cannot unmarshal type Ns");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Ns)untypedValue;
            switch (value)
            {
                case Ns.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Ns.ExoMinerState:
                    serializer.Serialize(writer, "ExoMiner.State");
                    return;
                case Ns.ExoMinerStateMissions:
                    serializer.Serialize(writer, "ExoMiner.State.Missions");
                    return;
                case Ns.UnityEngineDmat:
                    serializer.Serialize(writer, "UnityEngine.DMAT");
                    return;
            }
            throw new Exception("Cannot marshal type Ns");
        }

        public static readonly NsConverter Singleton = new NsConverter();
    }
}
