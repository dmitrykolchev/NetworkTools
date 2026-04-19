// <copyright file="InterfaceType.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Wfp;

/// <summary>
/// Перечисление типов интерфейсов, определенных IANA и объектом ifType в MIB-II (RFC 1213).
/// См. ftp://ftp.isi.edu/mib/ianaiftype.mib
/// </summary>
public enum InterfaceType
{
    /// <summary>None of the below</summary>
    Other = 1,
    Regular1822 = 2,
    Hdh1822 = 3,
    DdnX25 = 4,
    Rfc877X25 = 5,
    EthernetCsmacd = 6,
    Iso88023Csmacd = 7,
    Iso88024TokenBus = 8,
    Iso88025TokenRing = 9,
    Iso88026Man = 10,
    StarLan = 11,
    Proteon10Mbit = 12,
    Proteon80Mbit = 13,
    HyperChannel = 14,
    Fddi = 15,
    LapB = 16,
    Sdlc = 17,
    /// <summary>DS1-MIB</summary>
    Ds1 = 18,
    /// <summary>Obsolete; see DS1-MIB</summary>
    E1 = 19,
    BasicIsdn = 20,
    PrimaryIsdn = 21,
    /// <summary>Proprietary serial</summary>
    PropPoint2PointSerial = 22,
    Ppp = 23,
    SoftwareLoopback = 24,
    /// <summary>CLNP over IP</summary>
    Eon = 25,
    Ethernet3Mbit = 26,
    /// <summary>XNS over IP</summary>
    Nsip = 27,
    /// <summary>Generic Slip</summary>
    Slip = 28,
    /// <summary>ULTRA Technologies</summary>
    Ultra = 29,
    /// <summary>DS3-MIB</summary>
    Ds3 = 30,
    /// <summary>SMDS, coffee</summary>
    Sip = 31,
    /// <summary>DTE only</summary>
    FrameRelay = 32,
    Rs232 = 33,
    /// <summary>Parallel port</summary>
    Para = 34,
    Arcnet = 35,
    ArcnetPlus = 36,
    /// <summary>ATM cells</summary>
    Atm = 37,
    MioX25 = 38,
    /// <summary>SONET or SDH</summary>
    Sonet = 39,
    X25Ple = 40,
    Iso88022Llc = 41,
    LocalTalk = 42,
    SmdsDxi = 43,
    /// <summary>FRNETSERV-MIB</summary>
    FrameRelayService = 44,
    V35 = 45,
    Hssi = 46,
    Hippi = 47,
    /// <summary>Generic Modem</summary>
    Modem = 48,
    /// <summary>AAL5 over ATM</summary>
    Aal5 = 49,
    SonetPath = 50,
    SonetVt = 51,
    /// <summary>SMDS InterCarrier Interface</summary>
    SmdsIcip = 52,
    /// <summary>Proprietary virtual/internal</summary>
    PropVirtual = 53,
    /// <summary>Proprietary multiplexing</summary>
    PropMultiplexor = 54,
    /// <summary>100BaseVG</summary>
    Ieee80212 = 55,
    FibreChannel = 56,
    HippiInterface = 57,
    /// <summary>Obsolete, use 32 or 44</summary>
    FrameRelayInterconnect = 58,
    /// <summary>ATM Emulated LAN for 802.3</summary>
    Aflane8023 = 59,
    /// <summary>ATM Emulated LAN for 802.5</summary>
    Aflane8025 = 60,
    /// <summary>ATM Emulated circuit</summary>
    CctEmul = 61,
    /// <summary>Fast Ethernet (100BaseT)</summary>
    FastEther = 62,
    /// <summary>ISDN and X.25</summary>
    Isdn = 63,
    /// <summary>CCITT V.11/X.21</summary>
    V11 = 64,
    /// <summary>CCITT V.36</summary>
    V36 = 65,
    /// <summary>CCITT G703 at 64Kbps</summary>
    G703_64K = 66,
    /// <summary>Obsolete; see DS1-MIB</summary>
    G703_2M = 67,
    /// <summary>SNA QLLC</summary>
    Qllc = 68,
    /// <summary>Fast Ethernet (100BaseFX)</summary>
    FastEtherFx = 69,
    Channel = 70,
    /// <summary>Radio spread spectrum</summary>
    Ieee80211 = 71,
    /// <summary>IBM System 360/370 OEMI Channel</summary>
    Ibm370ParChan = 72,
    /// <summary>IBM Enterprise Systems Connection</summary>
    Escon = 73,
    /// <summary>Data Link Switching</summary>
    Dlsw = 74,
    /// <summary>ISDN S/T interface</summary>
    IsdnS = 75,
    /// <summary>ISDN U interface</summary>
    IsdnU = 76,
    /// <summary>Link Access Protocol D</summary>
    LapD = 77,
    /// <summary>IP Switching Objects</summary>
    IpSwitch = 78,
    /// <summary>Remote Source Route Bridging</summary>
    Rsrb = 79,
    /// <summary>ATM Logical Port</summary>
    AtmLogical = 80,
    /// <summary>Digital Signal Level 0</summary>
    Ds0 = 81,
    /// <summary>Group of ds0s on the same ds1</summary>
    Ds0Bundle = 82,
    /// <summary>Bisynchronous Protocol</summary>
    Bsc = 83,
    /// <summary>Asynchronous Protocol</summary>
    Async = 84,
    /// <summary>Combat Net Radio</summary>
    Cnr = 85,
    /// <summary>ISO 802.5r DTR</summary>
    Iso88025rDtr = 86,
    /// <summary>Ext Pos Loc Report Sys</summary>
    Eplrs = 87,
    /// <summary>Appletalk Remote Access Protocol</summary>
    Arap = 88,
    /// <summary>Proprietary Connectionless Proto</summary>
    PropCnls = 89,
    /// <summary>CCITT-ITU X.29 PAD Protocol</summary>
    HostPad = 90,
    /// <summary>CCITT-ITU X.3 PAD Facility</summary>
    TermPad = 91,
    /// <summary>Multiproto Interconnect over FR</summary>
    FrameRelayMpi = 92,
    /// <summary>CCITT-ITU X213</summary>
    X213 = 93,
    /// <summary>Asymmetric Digital Subscrbr Loop</summary>
    Adsl = 94,
    /// <summary>Rate-Adapt Digital Subscrbr Loop</summary>
    Radsl = 95,
    /// <summary>Symmetric Digital Subscriber Loop</summary>
    Sdsl = 96,
    /// <summary>Very H-Speed Digital Subscrb Loop</summary>
    Vdsl = 97,
    /// <summary>ISO 802.5 CRFP</summary>
    Iso88025CrfPrint = 98,
    /// <summary>Myricom Myrinet</summary>
    Myrinet = 99,
    /// <summary>Voice recEive and transMit</summary>
    VoiceEm = 100,
    /// <summary>Voice Foreign Exchange Office</summary>
    VoiceFxo = 101,
    /// <summary>Voice Foreign Exchange Station</summary>
    VoiceFxs = 102,
    /// <summary>Voice encapsulation</summary>
    VoiceEncap = 103,
    /// <summary>Voice over IP encapsulation</summary>
    VoiceOverIp = 104,
    /// <summary>ATM DXI</summary>
    AtmDxi = 105,
    /// <summary>ATM FUNI</summary>
    AtmFuni = 106,
    /// <summary>ATM IMA</summary>
    AtmIma = 107,
    /// <summary>PPP Multilink Bundle</summary>
    PppMultilinkBundle = 108,
    /// <summary>IBM ipOverCdlc</summary>
    IpOverCdlc = 109,
    /// <summary>IBM Common Link Access to Workstn</summary>
    IpOverClaw = 110,
    /// <summary>IBM stackToStack</summary>
    StackToStack = 111,
    /// <summary>IBM VIPA</summary>
    VirtualIpAddress = 112,
    /// <summary>IBM multi-proto channel support</summary>
    Mpc = 113,
    /// <summary>IBM ipOverAtm</summary>
    IpOverAtm = 114,
    /// <summary>ISO 802.5j Fiber Token Ring</summary>
    Iso88025Fiber = 115,
    /// <summary>IBM twinaxial data link control</summary>
    Tdlc = 116,
    GigabitEthernet = 117,
    Hdlc = 118,
    LapF = 119,
    V37 = 120,
    /// <summary>Multi-Link Protocol</summary>
    X25Mlp = 121,
    /// <summary>X.25 Hunt Group</summary>
    X25HuntGroup = 122,
    TranspHdlc = 123,
    /// <summary>Interleave channel</summary>
    Interleave = 124,
    /// <summary>Fast channel</summary>
    Fast = 125,
    /// <summary>IP (for APPN HPR in IP networks)</summary>
    Ip = 126,
    /// <summary>CATV Mac Layer</summary>
    DocsCableMacLayer = 127,
    /// <summary>CATV Downstream interface</summary>
    DocsCableDownstream = 128,
    /// <summary>CATV Upstream interface</summary>
    DocsCableUpstream = 129,
    /// <summary>Avalon Parallel Processor</summary>
    A12MppSwitch = 130,
    /// <summary>Encapsulation interface</summary>
    Tunnel = 131,
    /// <summary>Coffee pot</summary>
    Coffee = 132,
    /// <summary>Circuit Emulation Service</summary>
    Ces = 133,
    /// <summary>ATM Sub Interface</summary>
    AtmSubInterface = 134,
    /// <summary>Layer 2 Virtual LAN using 802.1Q</summary>
    L2Vlan = 135,
    /// <summary>Layer 3 Virtual LAN using IP</summary>
    L3IpVlan = 136,
    /// <summary>Layer 3 Virtual LAN using IPX</summary>
    L3IpxVlan = 137,
    /// <summary>IP over Power Lines</summary>
    DigitalPowerLine = 138,
    /// <summary>Multimedia Mail over IP</summary>
    MediaMailOverIp = 139,
    /// <summary>Dynamic syncronous Transfer Mode</summary>
    Dtm = 140,
    /// <summary>Data Communications Network</summary>
    Dcn = 141,
    /// <summary>IP Forwarding Interface</summary>
    IpForward = 142,
    /// <summary>Multi-rate Symmetric DSL</summary>
    Msdsl = 143,
    /// <summary>IEEE1394 High Perf Serial Bus</summary>
    Ieee1394 = 144,
    IfGsn = 145,
    DvbrccMacLayer = 146,
    DvbrccDownstream = 147,
    DvbrccUpstream = 148,
    AtmVirtual = 149,
    MplsTunnel = 150,
    Srp = 151,
    VoiceOverAtm = 152,
    VoiceOverFrameRelay = 153,
    Idsl = 154,
    CompositeLink = 155,
    Ss7SigLink = 156,
    PropWirelessP2P = 157,
    FrForward = 158,
    Rfc1483 = 159,
    Usb = 160,
    Ieee8023adLag = 161,
    BgpPolicyAccounting = 162,
    Frf16MfrBundle = 163,
    H323Gatekeeper = 164,
    H323Proxy = 165,
    Mpls = 166,
    MfSigLink = 167,
    Hdsl2 = 168,
    Shdsl = 169,
    Ds1Fdl = 170,
    Pos = 171,
    DvbAsiIn = 172,
    DvbAsiOut = 173,
    Plc = 174,
    Nfas = 175,
    Tr008 = 176,
    Gr303Rdt = 177,
    Gr303Idt = 178,
    Isup = 179,
    PropDocsWirelessMacLayer = 180,
    PropDocsWirelessDownstream = 181,
    PropDocsWirelessUpstream = 182,
    HiperLan2 = 183,
    PropBwaP2Mp = 184,
    SonetOverheadChannel = 185,
    DigitalWrapperOverheadChannel = 186,
    Aal2 = 187,
    RadioMac = 188,
    AtmRadio = 189,
    Imt = 190,
    Mvl = 191,
    ReachDsl = 192,
    FrDlciEndPt = 193,
    AtmVciEndPt = 194,
    OpticalChannel = 195,
    OpticalTransport = 196,
    Ieee80216Wman = 237,
    /// <summary>WWAN devices based on GSM technology</summary>
    WwanPp = 243,
    /// <summary>WWAN devices based on CDMA technology</summary>
    WwanPp2 = 244,
    /// <summary>IEEE 802.15.4 WPAN interface</summary>
    Ieee802154 = 259,
    XboxWireless = 281
}
