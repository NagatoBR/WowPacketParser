namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientSendRaidTargetUpdateSingle
    {
        public ulong ChangedBy;
        public ulong Target;
        public byte PartyIndex;
        public byte Symbol;
    }
}