using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Adres
    {
        public static List<Il> AdresGetir()
        {
            return new List<Il>
            {
                new Il
                {
                    IlAdi = "ADANA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALADAĞ" },
                        new Ilce { IlceAdi = "CEYHAN" },
                        new Ilce { IlceAdi = "ÇUKUROVA" },
                        new Ilce { IlceAdi = "FEKE" },
                        new Ilce { IlceAdi = "İMAMOĞLU" },
                        new Ilce { IlceAdi = "KARAİSALI" },
                        new Ilce { IlceAdi = "KARATAŞ" },
                        new Ilce { IlceAdi = "KOZAN" },
                        new Ilce { IlceAdi = "POZANTI" },
                        new Ilce { IlceAdi = "SAİMBEYLİ" },
                        new Ilce { IlceAdi = "SARIÇAM" },
                        new Ilce { IlceAdi = "SEYHAN" },
                        new Ilce { IlceAdi = "TUFANBEYLİ" },
                        new Ilce { IlceAdi = "YUMURTALIK" },
                        new Ilce { IlceAdi = "YÜREĞİR" }
                    }
                },
                new Il
                {
                    IlAdi = "ADIYAMAN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BESNİ" },
                        new Ilce { IlceAdi = "ÇELİKHAN" },
                        new Ilce { IlceAdi = "GERGER" },
                        new Ilce { IlceAdi = "GÖLBAŞI" },
                        new Ilce { IlceAdi = "KAHTA" },
                        new Ilce { IlceAdi = "SAMSAT" },
                        new Ilce { IlceAdi = "SİNCİK" },
                        new Ilce { IlceAdi = "TUT" }
                    }
                },
                new Il
                {
                    IlAdi = "AFYONKARAHİSAR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAŞMAKÇI" },
                        new Ilce { IlceAdi = "BAYAT" },
                        new Ilce { IlceAdi = "BOLVADİN" },
                        new Ilce { IlceAdi = "ÇAY" },
                        new Ilce { IlceAdi = "ÇOBANLAR" },
                        new Ilce { IlceAdi = "DAZKIRI" },
                        new Ilce { IlceAdi = "DİNAR" },
                        new Ilce { IlceAdi = "EMİRDAĞ" },
                        new Ilce { IlceAdi = "EVCİLER" },
                        new Ilce { IlceAdi = "HOCALAR" },
                        new Ilce { IlceAdi = "İHSANİYE" },
                        new Ilce { IlceAdi = "İSCEHİSAR" },
                        new Ilce { IlceAdi = "KIZILÖREN" },
                        new Ilce { IlceAdi = "SANDIKLI" },
                        new Ilce { IlceAdi = "SİNANPAŞA" },
                        new Ilce { IlceAdi = "SULTANDAĞI" },
                        new Ilce { IlceAdi = "ŞUHUT" }
                    }
                },
                new Il
                {
                    IlAdi = "AĞRI",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "DİYADİN" },
                        new Ilce { IlceAdi = "DOĞUBAYAZIT" },
                        new Ilce { IlceAdi = "ELEŞKİRT" },
                        new Ilce { IlceAdi = "HAMUR" },
                        new Ilce { IlceAdi = "PATNOS" },
                        new Ilce { IlceAdi = "TAŞLIÇAY" },
                        new Ilce { IlceAdi = "TUTAK" }
                    }
                },
                new Il
                {
                    IlAdi = "AMASYA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "GÖYNÜCEK" },
                        new Ilce { IlceAdi = "GÜMÜŞHACIKÖY" },
                        new Ilce { IlceAdi = "HAMAMÖZÜ" },
                        new Ilce { IlceAdi = "MERZİFON" },
                        new Ilce { IlceAdi = "SULUOVA" },
                        new Ilce { IlceAdi = "TAŞOVA" }
                    }
                },
                new Il
                {
                    IlAdi = "ANKARA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKYURT" },
                        new Ilce { IlceAdi = "ALTINDAĞ" },
                        new Ilce { IlceAdi = "AYAŞ" },
                        new Ilce { IlceAdi = "BALA" },
                        new Ilce { IlceAdi = "BEYPAZARI" },
                        new Ilce { IlceAdi = "ÇAMLIDERE" },
                        new Ilce { IlceAdi = "ÇANKAYA" },
                        new Ilce { IlceAdi = "ÇUBUK" },
                        new Ilce { IlceAdi = "ELMADAĞ" },
                        new Ilce { IlceAdi = "ETİMESGUT" },
                        new Ilce { IlceAdi = "EVREN" },
                        new Ilce { IlceAdi = "GÖLBAŞI" },
                        new Ilce { IlceAdi = "GÜDÜL" },
                        new Ilce { IlceAdi = "HAYMANA" },
                        new Ilce { IlceAdi = "KAHRAMANKAZAN" },
                        new Ilce { IlceAdi = "KALECİK" },
                        new Ilce { IlceAdi = "KEÇİÖREN" },
                        new Ilce { IlceAdi = "KIZILCAHAMAM" },
                        new Ilce { IlceAdi = "MAMAK" },
                        new Ilce { IlceAdi = "NALLIHAN" },
                        new Ilce { IlceAdi = "POLATLI" },
                        new Ilce { IlceAdi = "PURSAKLAR" },
                        new Ilce { IlceAdi = "SİNCAN" },
                        new Ilce { IlceAdi = "ŞEREFLİKOÇHİSAR" },
                        new Ilce { IlceAdi = "YENİMAHALLE" }
                    }
                },
                new Il
                {
                    IlAdi = "ANTALYA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKSEKİ" },
                        new Ilce { IlceAdi = "AKSU" },
                        new Ilce { IlceAdi = "ALANYA" },
                        new Ilce { IlceAdi = "DEMRE" },
                        new Ilce { IlceAdi = "DÖŞEMEALTI" },
                        new Ilce { IlceAdi = "ELMALI" },
                        new Ilce { IlceAdi = "FİNİKE" },
                        new Ilce { IlceAdi = "GAZİPAŞA" },
                        new Ilce { IlceAdi = "GÜNDOĞMUŞ" },
                        new Ilce { IlceAdi = "İBRADI" },
                        new Ilce { IlceAdi = "KAŞ" },
                        new Ilce { IlceAdi = "KEMER" },
                        new Ilce { IlceAdi = "KEPEZ" },
                        new Ilce { IlceAdi = "KONYAALTI" },
                        new Ilce { IlceAdi = "KORKUTELİ" },
                        new Ilce { IlceAdi = "KUMLUCA" },
                        new Ilce { IlceAdi = "MANAVGAT" },
                        new Ilce { IlceAdi = "MURATPAŞA" },
                        new Ilce { IlceAdi = "SERİK" }
                    }
                },
                new Il
                {
                    IlAdi = "ARTVİN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ARDANUÇ" },
                        new Ilce { IlceAdi = "ARHAVİ" },
                        new Ilce { IlceAdi = "BORÇKA" },
                        new Ilce { IlceAdi = "HOPA" },
                        new Ilce { IlceAdi = "KEMALPAŞA" },
                        new Ilce { IlceAdi = "MURGUL" },
                        new Ilce { IlceAdi = "ŞAVŞAT" },
                        new Ilce { IlceAdi = "YUSUFELİ" }
                    }
                },
                new Il
                {
                    IlAdi = "AYDIN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BOZDOĞAN" },
                        new Ilce { IlceAdi = "BUHARKENT" },
                        new Ilce { IlceAdi = "ÇİNE" },
                        new Ilce { IlceAdi = "DİDİM" },
                        new Ilce { IlceAdi = "EFELER" },
                        new Ilce { IlceAdi = "GERMENCİK" },
                        new Ilce { IlceAdi = "İNCİRLİOVA" },
                        new Ilce { IlceAdi = "KARACASU" },
                        new Ilce { IlceAdi = "KARPUZLU" },
                        new Ilce { IlceAdi = "KOÇARLI" },
                        new Ilce { IlceAdi = "KÖŞK" },
                        new Ilce { IlceAdi = "KUŞADASI" },
                        new Ilce { IlceAdi = "KUYUCAK" },
                        new Ilce { IlceAdi = "NAZİLLİ" },
                        new Ilce { IlceAdi = "SÖKE" },
                        new Ilce { IlceAdi = "SULTANHİSAR" },
                        new Ilce { IlceAdi = "YENİPAZAR" }
                    }
                },
                new Il
                {
                    IlAdi = "BALIKESİR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALTIEYLÜL" },
                        new Ilce { IlceAdi = "AYVALIK" },
                        new Ilce { IlceAdi = "BALYA" },
                        new Ilce { IlceAdi = "BANDIRMA" },
                        new Ilce { IlceAdi = "BİGADİÇ" },
                        new Ilce { IlceAdi = "BURHANİYE" },
                        new Ilce { IlceAdi = "DURSUNBEY" },
                        new Ilce { IlceAdi = "EDREMİT" },
                        new Ilce { IlceAdi = "ERDEK" },
                        new Ilce { IlceAdi = "GÖMEÇ" },
                        new Ilce { IlceAdi = "GÖNEN" },
                        new Ilce { IlceAdi = "HAVRAN" },
                        new Ilce { IlceAdi = "İVRİNDİ" },
                        new Ilce { IlceAdi = "KARESİ" },
                        new Ilce { IlceAdi = "KEPSUT" },
                        new Ilce { IlceAdi = "MANYAS" },
                        new Ilce { IlceAdi = "MARMARA" },
                        new Ilce { IlceAdi = "SAVAŞTEPE" },
                        new Ilce { IlceAdi = "SINDIRGI" },
                        new Ilce { IlceAdi = "SUSURLUK" }
                    }
                },
                new Il
                {
                    IlAdi = "BİLECİK",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BOZÜYÜK" },
                        new Ilce { IlceAdi = "GÖLPAZARI" },
                        new Ilce { IlceAdi = "İNHİSAR" },
                        new Ilce { IlceAdi = "OSMANELİ" },
                        new Ilce { IlceAdi = "PAZARYERİ" },
                        new Ilce { IlceAdi = "SÖĞÜT" },
                        new Ilce { IlceAdi = "YENİPAZAR" }
                    }
                },
                new Il
                {
                    IlAdi = "BİNGÖL",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ADAKLI" },
                        new Ilce { IlceAdi = "GENÇ" },
                        new Ilce { IlceAdi = "KARLIOVA" },
                        new Ilce { IlceAdi = "KİĞI" },
                        new Ilce { IlceAdi = "SOLHAN" },
                        new Ilce { IlceAdi = "YAYLADERE" },
                        new Ilce { IlceAdi = "YEDİSU" }
                    }
                },
                new Il
                {
                    IlAdi = "BİTLİS",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ADİLCEVAZ" },
                        new Ilce { IlceAdi = "AHLAT" },
                        new Ilce { IlceAdi = "GÜROYMAK" },
                        new Ilce { IlceAdi = "HİZAN" },
                        new Ilce { IlceAdi = "MUTKİ" },
                        new Ilce { IlceAdi = "TATVAN" }
                    }
                },
                new Il
                {
                    IlAdi = "BOLU",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "DÖRTDİVAN" },
                        new Ilce { IlceAdi = "GEREDE" },
                        new Ilce { IlceAdi = "GÖYNÜK" },
                        new Ilce { IlceAdi = "KIBRISCIK" },
                        new Ilce { IlceAdi = "MENGEN" },
                        new Ilce { IlceAdi = "MUDURNU" },
                        new Ilce { IlceAdi = "SEBEN" },
                        new Ilce { IlceAdi = "YENİÇAĞA" }
                    }
                },
                new Il
                {
                    IlAdi = "BURDUR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AĞLASUN" },
                        new Ilce { IlceAdi = "ALTINYAYLA" },
                        new Ilce { IlceAdi = "BUCAK" },
                        new Ilce { IlceAdi = "ÇAVDIR" },
                        new Ilce { IlceAdi = "ÇELTİKÇİ" },
                        new Ilce { IlceAdi = "GÖLHİSAR" },
                        new Ilce { IlceAdi = "KARAMANLI" },
                        new Ilce { IlceAdi = "KEMER" },
                        new Ilce { IlceAdi = "TEFENNİ" },
                        new Ilce { IlceAdi = "YEŞİLOVA" }
                    }
                },
                new Il
                {
                    IlAdi = "BURSA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BÜYÜKORHAN" },
                        new Ilce { IlceAdi = "GEMLİK" },
                        new Ilce { IlceAdi = "GÜRSU" },
                        new Ilce { IlceAdi = "HARMANCIK" },
                        new Ilce { IlceAdi = "İNEGÖL" },
                        new Ilce { IlceAdi = "İZNİK" },
                        new Ilce { IlceAdi = "KARACABEY" },
                        new Ilce { IlceAdi = "KELES" },
                        new Ilce { IlceAdi = "KESTEL" },
                        new Ilce { IlceAdi = "MUDANYA" },
                        new Ilce { IlceAdi = "MUSTAFAKEMALPAŞA" },
                        new Ilce { IlceAdi = "NİLÜFER" },
                        new Ilce { IlceAdi = "ORHANELİ" },
                        new Ilce { IlceAdi = "ORHANGAZİ" },
                        new Ilce { IlceAdi = "OSMANGAZİ" },
                        new Ilce { IlceAdi = "YENİŞEHİR" },
                        new Ilce { IlceAdi = "YILDIRIM" }
                    }
                },
                new Il
                {
                    IlAdi = "ÇANAKKALE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AYVACIK" },
                        new Ilce { IlceAdi = "BAYRAMİÇ" },
                        new Ilce { IlceAdi = "BİGA" },
                        new Ilce { IlceAdi = "BOZCAADA" },
                        new Ilce { IlceAdi = "ÇAN" },
                        new Ilce { IlceAdi = "ECEABAT" },
                        new Ilce { IlceAdi = "EZİNE" },
                        new Ilce { IlceAdi = "GELİBOLU" },
                        new Ilce { IlceAdi = "GÖKÇEADA" },
                        new Ilce { IlceAdi = "LAPSEKİ" },
                        new Ilce { IlceAdi = "YENİCE" }
                    }
                },
                new Il
                {
                    IlAdi = "ÇANKIRI",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ATKARACALAR" },
                        new Ilce { IlceAdi = "BAYRAMÖREN" },
                        new Ilce { IlceAdi = "ÇERKEŞ" },
                        new Ilce { IlceAdi = "ELDİVAN" },
                        new Ilce { IlceAdi = "ILGAZ" },
                        new Ilce { IlceAdi = "KIZILIRMAK" },
                        new Ilce { IlceAdi = "KORGUN" },
                        new Ilce { IlceAdi = "KURŞUNLU" },
                        new Ilce { IlceAdi = "ORTA" },
                        new Ilce { IlceAdi = "ŞABANÖZÜ" },
                        new Ilce { IlceAdi = "YAPRAKLI" }
                    }
                },
                new Il
                {
                    IlAdi = "ÇORUM",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALACA" },
                        new Ilce { IlceAdi = "BAYAT" },
                        new Ilce { IlceAdi = "BOĞAZKALE" },
                        new Ilce { IlceAdi = "DODURGA" },
                        new Ilce { IlceAdi = "İSKİLİP" },
                        new Ilce { IlceAdi = "KARGI" },
                        new Ilce { IlceAdi = "LAÇİN" },
                        new Ilce { IlceAdi = "MECİTÖZÜ" },
                        new Ilce { IlceAdi = "OĞUZLAR" },
                        new Ilce { IlceAdi = "ORTAKÖY" },
                        new Ilce { IlceAdi = "OSMANCIK" },
                        new Ilce { IlceAdi = "SUNGURLU" },
                        new Ilce { IlceAdi = "UĞURLUDAĞ" }
                    }
                },
                new Il
                {
                    IlAdi = "DENİZLİ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ACIPAYAM" },
                        new Ilce { IlceAdi = "BABADAĞ" },
                        new Ilce { IlceAdi = "BAKLAN" },
                        new Ilce { IlceAdi = "BEKİLLİ" },
                        new Ilce { IlceAdi = "BEYAĞAÇ" },
                        new Ilce { IlceAdi = "BOZKURT" },
                        new Ilce { IlceAdi = "BULDAN" },
                        new Ilce { IlceAdi = "ÇAL" },
                        new Ilce { IlceAdi = "ÇAMELİ" },
                        new Ilce { IlceAdi = "ÇARDAK" },
                        new Ilce { IlceAdi = "ÇİVRİL" },
                        new Ilce { IlceAdi = "GÜNEY" },
                        new Ilce { IlceAdi = "HONAZ" },
                        new Ilce { IlceAdi = "KALE" },
                        new Ilce { IlceAdi = "MERKEZEFENDİ" },
                        new Ilce { IlceAdi = "PAMUKKALE" },
                        new Ilce { IlceAdi = "SARAYKÖY" },
                        new Ilce { IlceAdi = "SERİNHİSAR" },
                        new Ilce { IlceAdi = "TAVAS" }
                    }
                },
                new Il
                {
                    IlAdi = "DİYARBAKIR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAĞLAR" },
                        new Ilce { IlceAdi = "BİSMİL" },
                        new Ilce { IlceAdi = "ÇERMİK" },
                        new Ilce { IlceAdi = "ÇINAR" },
                        new Ilce { IlceAdi = "ÇÜNGÜŞ" },
                        new Ilce { IlceAdi = "DİCLE" },
                        new Ilce { IlceAdi = "EĞİL" },
                        new Ilce { IlceAdi = "ERGANİ" },
                        new Ilce { IlceAdi = "HANİ" },
                        new Ilce { IlceAdi = "HAZRO" },
                        new Ilce { IlceAdi = "KAYAPINAR" },
                        new Ilce { IlceAdi = "KOCAKÖY" },
                        new Ilce { IlceAdi = "KULP" },
                        new Ilce { IlceAdi = "LİCE" },
                        new Ilce { IlceAdi = "SİLVAN" },
                        new Ilce { IlceAdi = "SUR" },
                        new Ilce { IlceAdi = "YENİŞEHİR" }
                    }
                },
                new Il
                {
                    IlAdi = "EDİRNE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ENEZ" },
                        new Ilce { IlceAdi = "HAVSA" },
                        new Ilce { IlceAdi = "İPSALA" },
                        new Ilce { IlceAdi = "KEŞAN" },
                        new Ilce { IlceAdi = "LALAPAŞA" },
                        new Ilce { IlceAdi = "MERİÇ" },
                        new Ilce { IlceAdi = "SÜLOĞLU" },
                        new Ilce { IlceAdi = "UZUNKÖPRÜ" }
                    }
                },
                new Il
                {
                    IlAdi = "ELAZIĞ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AĞIN" },
                        new Ilce { IlceAdi = "ALACAKAYA" },
                        new Ilce { IlceAdi = "ARICAK" },
                        new Ilce { IlceAdi = "BASKİL" },
                        new Ilce { IlceAdi = "KARAKOÇAN" },
                        new Ilce { IlceAdi = "KEBAN" },
                        new Ilce { IlceAdi = "KOVANCILAR" },
                        new Ilce { IlceAdi = "MADEN" },
                        new Ilce { IlceAdi = "PALU" },
                        new Ilce { IlceAdi = "SİVRİCE" }
                    }
                },
                new Il
                {
                    IlAdi = "ERZİNCAN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ÇAYIRLI" },
                        new Ilce { IlceAdi = "İLİÇ" },
                        new Ilce { IlceAdi = "KEMAH" },
                        new Ilce { IlceAdi = "KEMALİYE" },
                        new Ilce { IlceAdi = "OTLUKBELİ" },
                        new Ilce { IlceAdi = "REFAHİYE" },
                        new Ilce { IlceAdi = "TERCAN" },
                        new Ilce { IlceAdi = "ÜZÜMLÜ" }
                    }
                },
                new Il
                {
                    IlAdi = "ERZURUM",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AŞKALE" },
                        new Ilce { IlceAdi = "AZİZİYE" },
                        new Ilce { IlceAdi = "ÇAT" },
                        new Ilce { IlceAdi = "HINIS" },
                        new Ilce { IlceAdi = "HORASAN" },
                        new Ilce { IlceAdi = "İSPİR" },
                        new Ilce { IlceAdi = "KARAÇOBAN" },
                        new Ilce { IlceAdi = "KARAYAZI" },
                        new Ilce { IlceAdi = "KÖPRÜKÖY" },
                        new Ilce { IlceAdi = "NARMAN" },
                        new Ilce { IlceAdi = "OLTU" },
                        new Ilce { IlceAdi = "OLUR" },
                        new Ilce { IlceAdi = "PALANDÖKEN" },
                        new Ilce { IlceAdi = "PASİNLER" },
                        new Ilce { IlceAdi = "PAZARYOLU" },
                        new Ilce { IlceAdi = "ŞENKAYA" },
                        new Ilce { IlceAdi = "TEKMAN" },
                        new Ilce { IlceAdi = "TORTUM" },
                        new Ilce { IlceAdi = "UZUNDERE" },
                        new Ilce { IlceAdi = "YAKUTİYE" }
                    }
                },
                new Il
                {
                    IlAdi = "ESKİŞEHİR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALPU" },
                        new Ilce { IlceAdi = "BEYLİKOVA" },
                        new Ilce { IlceAdi = "ÇİFTELER" },
                        new Ilce { IlceAdi = "GÜNYÜZÜ" },
                        new Ilce { IlceAdi = "HAN" },
                        new Ilce { IlceAdi = "İNÖNÜ" },
                        new Ilce { IlceAdi = "MAHMUDİYE" },
                        new Ilce { IlceAdi = "MİHALGAZİ" },
                        new Ilce { IlceAdi = "MİHALIÇÇIK" },
                        new Ilce { IlceAdi = "ODUNPAZARI" },
                        new Ilce { IlceAdi = "SARICAKAYA" },
                        new Ilce { IlceAdi = "SEYİTGAZİ" },
                        new Ilce { IlceAdi = "SİVRİHİSAR" },
                        new Ilce { IlceAdi = "TEPEBAŞI" }
                    }
                },
                new Il
                {
                    IlAdi = "GAZİANTEP",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ARABAN" },
                        new Ilce { IlceAdi = "İSLAHİYE" },
                        new Ilce { IlceAdi = "KARKAMIŞ" },
                        new Ilce { IlceAdi = "NİZİP" },
                        new Ilce { IlceAdi = "NURDAĞI" },
                        new Ilce { IlceAdi = "OĞUZELİ" },
                        new Ilce { IlceAdi = "ŞAHİNBEY" },
                        new Ilce { IlceAdi = "ŞEHİTKAMİL" },
                        new Ilce { IlceAdi = "YAVUZELİ" }
                    }
                },
                new Il
                {
                    IlAdi = "GİRESUN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALUCRA" },
                        new Ilce { IlceAdi = "BULANCAK" },
                        new Ilce { IlceAdi = "ÇAMOLUK" },
                        new Ilce { IlceAdi = "ÇANAKÇI" },
                        new Ilce { IlceAdi = "DERELİ" },
                        new Ilce { IlceAdi = "DOĞANKENT" },
                        new Ilce { IlceAdi = "ESPİYE" },
                        new Ilce { IlceAdi = "EYNESİL" },
                        new Ilce { IlceAdi = "GÖRELE" },
                        new Ilce { IlceAdi = "GÜCE" },
                        new Ilce { IlceAdi = "KEŞAP" },
                        new Ilce { IlceAdi = "PİRAZİZ" },
                        new Ilce { IlceAdi = "ŞEBİNKARAHİSAR" },
                        new Ilce { IlceAdi = "TİREBOLU" },
                        new Ilce { IlceAdi = "YAĞLIDERE" }
                    }
                },
                new Il
                {
                    IlAdi = "GÜMÜŞHANE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "KELKİT" },
                        new Ilce { IlceAdi = "KÖSE" },
                        new Ilce { IlceAdi = "KÜRTÜN" },
                        new Ilce { IlceAdi = "ŞİRAN" },
                        new Ilce { IlceAdi = "TORUL" }
                    }
                },
                new Il
                {
                    IlAdi = "HAKKARİ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ÇUKURCA" },
                        new Ilce { IlceAdi = "DERECİK" },
                        new Ilce { IlceAdi = "ŞEMDİNLİ" },
                        new Ilce { IlceAdi = "YÜKSEKOVA" }
                    }
                },
                new Il
                {
                    IlAdi = "HATAY",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALTINÖZÜ" },
                        new Ilce { IlceAdi = "ANTAKYA" },
                        new Ilce { IlceAdi = "ARSUZ" },
                        new Ilce { IlceAdi = "BELEN" },
                        new Ilce { IlceAdi = "DEFNE" },
                        new Ilce { IlceAdi = "DÖRTYOL" },
                        new Ilce { IlceAdi = "ERZİN" },
                        new Ilce { IlceAdi = "HASSA" },
                        new Ilce { IlceAdi = "İSKENDERUN" },
                        new Ilce { IlceAdi = "KIRIKHAN" },
                        new Ilce { IlceAdi = "KUMLU" },
                        new Ilce { IlceAdi = "PAYAS" },
                        new Ilce { IlceAdi = "REYHANLI" },
                        new Ilce { IlceAdi = "SAMANDAĞ" },
                        new Ilce { IlceAdi = "YAYLADAĞI" }
                    }
                },
                new Il
                {
                    IlAdi = "ISPARTA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKSU" },
                        new Ilce { IlceAdi = "ATABEY" },
                        new Ilce { IlceAdi = "EĞİRDİR" },
                        new Ilce { IlceAdi = "GELENDOST" },
                        new Ilce { IlceAdi = "GÖNEN" },
                        new Ilce { IlceAdi = "KEÇİBORLU" },
                        new Ilce { IlceAdi = "SENİRKENT" },
                        new Ilce { IlceAdi = "SÜTÇÜLER" },
                        new Ilce { IlceAdi = "ŞARKİKARAAĞAÇ" },
                        new Ilce { IlceAdi = "ULUBORLU" },
                        new Ilce { IlceAdi = "YALVAÇ" },
                        new Ilce { IlceAdi = "YENİŞARBADEMLİ" }
                    }
                },
                new Il
                {
                    IlAdi = "MERSİN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKDENİZ" },
                        new Ilce { IlceAdi = "ANAMUR" },
                        new Ilce { IlceAdi = "AYDINCIK" },
                        new Ilce { IlceAdi = "BOZYAZI" },
                        new Ilce { IlceAdi = "ÇAMLIYAYLA" },
                        new Ilce { IlceAdi = "ERDEMLİ" },
                        new Ilce { IlceAdi = "GÜLNAR" },
                        new Ilce { IlceAdi = "MEZİTLİ" },
                        new Ilce { IlceAdi = "MUT" },
                        new Ilce { IlceAdi = "SİLİFKE" },
                        new Ilce { IlceAdi = "TARSUS" },
                        new Ilce { IlceAdi = "TOROSLAR" },
                        new Ilce { IlceAdi = "YENİŞEHİR" }
                    }
                },
                new Il
                {
                    IlAdi = "İSTANBUL",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ADALAR" },
                        new Ilce { IlceAdi = "ARNAVUTKÖY" },
                        new Ilce { IlceAdi = "ATAŞEHİR" },
                        new Ilce { IlceAdi = "AVCILAR" },
                        new Ilce { IlceAdi = "BAĞCILAR" },
                        new Ilce { IlceAdi = "BAHÇELİEVLER" },
                        new Ilce { IlceAdi = "BAKIRKÖY" },
                        new Ilce { IlceAdi = "BAŞAKŞEHİR" },
                        new Ilce { IlceAdi = "BAYRAMPAŞA" },
                        new Ilce { IlceAdi = "BEŞİKTAŞ" },
                        new Ilce { IlceAdi = "BEYLİKDÜZÜ" },
                        new Ilce { IlceAdi = "BEYOĞLU" },
                        new Ilce { IlceAdi = "BÜYÜKÇEKMECE" },
                        new Ilce { IlceAdi = "ÇATALCA" },
                        new Ilce { IlceAdi = "ÇEKMEKÖY" },
                        new Ilce { IlceAdi = "ESENLER" },
                        new Ilce { IlceAdi = "ESENYURT" },
                        new Ilce { IlceAdi = "EYÜPSULTAN" },
                        new Ilce { IlceAdi = "FATİH" },
                        new Ilce { IlceAdi = "GAZİOSMANPAŞA" },
                        new Ilce { IlceAdi = "GÜNGÖREN" },
                        new Ilce { IlceAdi = "KADIKÖY" },
                        new Ilce { IlceAdi = "KAĞITHANE" },
                        new Ilce { IlceAdi = "KARTAL" },
                        new Ilce { IlceAdi = "KÜÇÜKÇEKMECE" },
                        new Ilce { IlceAdi = "MALTEPE" },
                        new Ilce { IlceAdi = "PENDİK" },
                        new Ilce { IlceAdi = "SANCAKTEPE" },
                        new Ilce { IlceAdi = "SARIYER" },
                        new Ilce { IlceAdi = "SİLİVRİ" },
                        new Ilce { IlceAdi = "SULTANBEYLİ" },
                        new Ilce { IlceAdi = "SULTANGAZİ" },
                        new Ilce { IlceAdi = "ŞİLE" },
                        new Ilce { IlceAdi = "ŞİŞLİ" },
                        new Ilce { IlceAdi = "TUZLA" },
                        new Ilce { IlceAdi = "ÜMRANİYE" },
                        new Ilce { IlceAdi = "ÜSKÜDAR" },
                        new Ilce { IlceAdi = "ZEYTİNBURNU" }
                    }
                },
                new Il
                {
                    IlAdi = "İZMİR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALİAĞA" },
                        new Ilce { IlceAdi = "BALÇOVA" },
                        new Ilce { IlceAdi = "BAYINDIR" },
                        new Ilce { IlceAdi = "BAYRAKLI" },
                        new Ilce { IlceAdi = "BERGAMA" },
                        new Ilce { IlceAdi = "BEYDAĞ" },
                        new Ilce { IlceAdi = "BORNOVA" },
                        new Ilce { IlceAdi = "BUCA" },
                        new Ilce { IlceAdi = "ÇEŞME" },
                        new Ilce { IlceAdi = "ÇİĞLİ" },
                        new Ilce { IlceAdi = "DİKİLİ" },
                        new Ilce { IlceAdi = "FOÇA" },
                        new Ilce { IlceAdi = "GAZİEMİR" },
                        new Ilce { IlceAdi = "GÜZELBAHÇE" },
                        new Ilce { IlceAdi = "KARABAĞLAR" },
                        new Ilce { IlceAdi = "KARABURUN" },
                        new Ilce { IlceAdi = "KARŞIYAKA" },
                        new Ilce { IlceAdi = "KEMALPAŞA" },
                        new Ilce { IlceAdi = "KINIK" },
                        new Ilce { IlceAdi = "KİRAZ" },
                        new Ilce { IlceAdi = "KONAK" },
                        new Ilce { IlceAdi = "MENDERES" },
                        new Ilce { IlceAdi = "MENEMEN" },
                        new Ilce { IlceAdi = "NARLIDERE" },
                        new Ilce { IlceAdi = "ÖDEMİŞ" },
                        new Ilce { IlceAdi = "SEFERİHİSAR" },
                        new Ilce { IlceAdi = "SELÇUK" },
                        new Ilce { IlceAdi = "TİRE" },
                        new Ilce { IlceAdi = "TORBALI" },
                        new Ilce { IlceAdi = "URLA" }
                    }
                },
                new Il
                {
                    IlAdi = "KARS",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKYAKA" },
                        new Ilce { IlceAdi = "ARPAÇAY" },
                        new Ilce { IlceAdi = "DİGOR" },
                        new Ilce { IlceAdi = "KAĞIZMAN" },
                        new Ilce { IlceAdi = "SARIKAMIŞ" },
                        new Ilce { IlceAdi = "SELİM" },
                        new Ilce { IlceAdi = "SUSUZ" }
                    }
                },
                new Il
                {
                    IlAdi = "KASTAMONU",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ABANA" },
                        new Ilce { IlceAdi = "AĞLI" },
                        new Ilce { IlceAdi = "ARAÇ" },
                        new Ilce { IlceAdi = "AZDAVAY" },
                        new Ilce { IlceAdi = "BOZKURT" },
                        new Ilce { IlceAdi = "CİDE" },
                        new Ilce { IlceAdi = "ÇATALZEYTİN" },
                        new Ilce { IlceAdi = "DADAY" },
                        new Ilce { IlceAdi = "DEVREKANİ" },
                        new Ilce { IlceAdi = "DOĞANYURT" },
                        new Ilce { IlceAdi = "HANÖNÜ" },
                        new Ilce { IlceAdi = "İHSANGAZİ" },
                        new Ilce { IlceAdi = "İNEBOLU" },
                        new Ilce { IlceAdi = "KÜRE" },
                        new Ilce { IlceAdi = "PINARBAŞI" },
                        new Ilce { IlceAdi = "SEYDİLER" },
                        new Ilce { IlceAdi = "ŞENPAZAR" },
                        new Ilce { IlceAdi = "TAŞKÖPRÜ" },
                        new Ilce { IlceAdi = "TOSYA" }
                    }
                },
                                new Il
                {
                    IlAdi = "KAYSERİ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKKIŞLA" },
                        new Ilce { IlceAdi = "BÜNYAN" },
                        new Ilce { IlceAdi = "DEVELİ" },
                        new Ilce { IlceAdi = "FELAHİYE" },
                        new Ilce { IlceAdi = "HACILAR" },
                        new Ilce { IlceAdi = "İNCESU" },
                        new Ilce { IlceAdi = "KOCASİNAN" },
                        new Ilce { IlceAdi = "MELİKGAZİ" },
                        new Ilce { IlceAdi = "ÖZVATAN" },
                        new Ilce { IlceAdi = "PINARBAŞI" },
                        new Ilce { IlceAdi = "SARIOĞLAN" },
                        new Ilce { IlceAdi = "SARIZ" },
                        new Ilce { IlceAdi = "TALAS" },
                        new Ilce { IlceAdi = "TOMARZA" },
                        new Ilce { IlceAdi = "YAHYALI" },
                        new Ilce { IlceAdi = "YEŞİLHİSAR" }
                    }
                },
                new Il
                {
                    IlAdi = "KIRKLARELİ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BABAESKİ" },
                        new Ilce { IlceAdi = "DEMİRKÖY" },
                        new Ilce { IlceAdi = "KOFÇAZ" },
                        new Ilce { IlceAdi = "LÜLEBURGAZ" },
                        new Ilce { IlceAdi = "PEHLİVANKÖY" },
                        new Ilce { IlceAdi = "PINARHİSAR" },
                        new Ilce { IlceAdi = "VİZE" }
                    }
                },
                new Il
                {
                    IlAdi = "KIRŞEHİR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKÇAKENT" },
                        new Ilce { IlceAdi = "AKPINAR" },
                        new Ilce { IlceAdi = "BOZTEPE" },
                        new Ilce { IlceAdi = "ÇİÇEKDAĞI" },
                        new Ilce { IlceAdi = "KAMAN" },
                        new Ilce { IlceAdi = "MUCUR" }
                    }
                },
                new Il
                {
                    IlAdi = "KOCAELİ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAŞİSKELE" },
                        new Ilce { IlceAdi = "ÇAYIROVA" },
                        new Ilce { IlceAdi = "DARICA" },
                        new Ilce { IlceAdi = "DERİNCE" },
                        new Ilce { IlceAdi = "DİLOVASI" },
                        new Ilce { IlceAdi = "GEBZE" },
                        new Ilce { IlceAdi = "GÖLCÜK" },
                        new Ilce { IlceAdi = "İZMİT" },
                        new Ilce { IlceAdi = "KANDIRA" },
                        new Ilce { IlceAdi = "KARAMÜRSEL" },
                        new Ilce { IlceAdi = "KARTEPE" },
                        new Ilce { IlceAdi = "KÖRFEZ" }
                    }
                },
                new Il
                {
                    IlAdi = "KONYA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AHIRLI" },
                        new Ilce { IlceAdi = "AKÖREN" },
                        new Ilce { IlceAdi = "AKŞEHİR" },
                        new Ilce { IlceAdi = "ALTINEKİN" },
                        new Ilce { IlceAdi = "BEYŞEHİR" },
                        new Ilce { IlceAdi = "BOZKIR" },
                        new Ilce { IlceAdi = "CİHANBEYLİ" },
                        new Ilce { IlceAdi = "ÇELTİK" },
                        new Ilce { IlceAdi = "ÇUMRA" },
                        new Ilce { IlceAdi = "DERBENT" },
                        new Ilce { IlceAdi = "DEREBUCAK" },
                        new Ilce { IlceAdi = "DOĞANHİSAR" },
                        new Ilce { IlceAdi = "EMİRGAZİ" },
                        new Ilce { IlceAdi = "EREĞLİ" },
                        new Ilce { IlceAdi = "GÜNEYSINIR" },
                        new Ilce { IlceAdi = "HADİM" },
                        new Ilce { IlceAdi = "HALKAPINAR" },
                        new Ilce { IlceAdi = "HÜYÜK" },
                        new Ilce { IlceAdi = "ILGIN" },
                        new Ilce { IlceAdi = "KADINHANI" },
                        new Ilce { IlceAdi = "KARAPINAR" },
                        new Ilce { IlceAdi = "KARATAY" },
                        new Ilce { IlceAdi = "KULU" },
                        new Ilce { IlceAdi = "MERAM" },
                        new Ilce { IlceAdi = "SARAYÖNÜ" },
                        new Ilce { IlceAdi = "SELÇUKLU" },
                        new Ilce { IlceAdi = "SEYDİŞEHİR" },
                        new Ilce { IlceAdi = "TAŞKENT" },
                        new Ilce { IlceAdi = "TUZLUKÇU" },
                        new Ilce { IlceAdi = "YALIHÜYÜK" },
                        new Ilce { IlceAdi = "YUNAK" }
                    }
                },
                new Il
                {
                    IlAdi = "KÜTAHYA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALTINTAŞ" },
                        new Ilce { IlceAdi = "ASLANAPA" },
                        new Ilce { IlceAdi = "ÇAVDARHİSAR" },
                        new Ilce { IlceAdi = "DOMANİÇ" },
                        new Ilce { IlceAdi = "DUMLUPINAR" },
                        new Ilce { IlceAdi = "EMET" },
                        new Ilce { IlceAdi = "GEDİZ" },
                        new Ilce { IlceAdi = "HİSARCIK" },
                        new Ilce { IlceAdi = "PAZARLAR" },
                        new Ilce { IlceAdi = "SİMAV" },
                        new Ilce { IlceAdi = "ŞAPHANE" },
                        new Ilce { IlceAdi = "TAVŞANLI" }
                    }
                },
                new Il
                {
                    IlAdi = "MALATYA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKÇADAĞ" },
                        new Ilce { IlceAdi = "ARAPGİR" },
                        new Ilce { IlceAdi = "ARGUVAN" },
                        new Ilce { IlceAdi = "BATTALGAZİ" },
                        new Ilce { IlceAdi = "DARENDE" },
                        new Ilce { IlceAdi = "DOĞANŞEHİR" },
                        new Ilce { IlceAdi = "DOĞANYOL" },
                        new Ilce { IlceAdi = "HEKİMHAN" },
                        new Ilce { IlceAdi = "KALE" },
                        new Ilce { IlceAdi = "KULUNCAK" },
                        new Ilce { IlceAdi = "PÜTÜRGE" },
                        new Ilce { IlceAdi = "YAZIHAN" },
                        new Ilce { IlceAdi = "YEŞİLYURT" }
                    }
                },
                new Il
                {
                    IlAdi = "MANİSA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AHMETLİ" },
                        new Ilce { IlceAdi = "AKHİSAR" },
                        new Ilce { IlceAdi = "ALAŞEHİR" },
                        new Ilce { IlceAdi = "DEMİRCİ" },
                        new Ilce { IlceAdi = "GÖLMARMARA" },
                        new Ilce { IlceAdi = "GÖRDES" },
                        new Ilce { IlceAdi = "KIRKAĞAÇ" },
                        new Ilce { IlceAdi = "KÖPRÜBAŞI" },
                        new Ilce { IlceAdi = "KULA" },
                        new Ilce { IlceAdi = "SALİHLİ" },
                        new Ilce { IlceAdi = "SARIGÖL" },
                        new Ilce { IlceAdi = "SARUHANLI" },
                        new Ilce { IlceAdi = "SELENDİ" },
                        new Ilce { IlceAdi = "SOMA" },
                        new Ilce { IlceAdi = "ŞEHZADELER" },
                        new Ilce { IlceAdi = "TURGUTLU" },
                        new Ilce { IlceAdi = "YUNUSEMRE" }
                    }
                },
                new Il
                {
                    IlAdi = "KAHRAMANMARAŞ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AFŞİN" },
                        new Ilce { IlceAdi = "ANDIRIN" },
                        new Ilce { IlceAdi = "ÇAĞLAYANCERİT" },
                        new Ilce { IlceAdi = "DULKADİROĞLU" },
                        new Ilce { IlceAdi = "EKİNÖZÜ" },
                        new Ilce { IlceAdi = "ELBİSTAN" },
                        new Ilce { IlceAdi = "GÖKSUN" },
                        new Ilce { IlceAdi = "NURHAK" },
                        new Ilce { IlceAdi = "ONİKİŞUBAT" },
                        new Ilce { IlceAdi = "PAZARCIK" },
                        new Ilce { IlceAdi = "TÜRKOĞLU" }
                    }
                },
                new Il
                {
                    IlAdi = "MARDİN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ARTUKLU" },
                        new Ilce { IlceAdi = "DARGEÇİT" },
                        new Ilce { IlceAdi = "DERİK" },
                        new Ilce { IlceAdi = "KIZILTEPE" },
                        new Ilce { IlceAdi = "MAZIDAĞI" },
                        new Ilce { IlceAdi = "MİDYAT" },
                        new Ilce { IlceAdi = "NUSAYBİN" },
                        new Ilce { IlceAdi = "ÖMERLİ" },
                        new Ilce { IlceAdi = "SAVUR" },
                        new Ilce { IlceAdi = "YEŞİLLİ" }
                    }
                },
                new Il
                {
                    IlAdi = "MUĞLA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BODRUM" },
                        new Ilce { IlceAdi = "DALAMAN" },
                        new Ilce { IlceAdi = "DATÇA" },
                        new Ilce { IlceAdi = "FETHİYE" },
                        new Ilce { IlceAdi = "KAVAKLIDERE" },
                        new Ilce { IlceAdi = "KÖYCEĞİZ" },
                        new Ilce { IlceAdi = "MARMARİS" },
                        new Ilce { IlceAdi = "MENTEŞE" },
                        new Ilce { IlceAdi = "MİLAS" },
                        new Ilce { IlceAdi = "ORTACA" },
                        new Ilce { IlceAdi = "SEYDİKEMER" },
                        new Ilce { IlceAdi = "ULA" },
                        new Ilce { IlceAdi = "YATAĞAN" }
                    }
                },
                new Il
                {
                    IlAdi = "MUŞ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BULANIK" },
                        new Ilce { IlceAdi = "HASKÖY" },
                        new Ilce { IlceAdi = "KORKUT" },
                        new Ilce { IlceAdi = "MALAZGİRT" },
                        new Ilce { IlceAdi = "VARTO" }
                    }
                },
                new Il
                {
                    IlAdi = "NEVŞEHİR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ACIGÖL" },
                        new Ilce { IlceAdi = "AVANOS" },
                        new Ilce { IlceAdi = "DERİNKUYU" },
                        new Ilce { IlceAdi = "GÜLŞEHİR" },
                        new Ilce { IlceAdi = "HACIBEKTAŞ" },
                        new Ilce { IlceAdi = "KOZAKLI" },
                        new Ilce { IlceAdi = "ÜRGÜP" }
                    }
                },
                new Il
                {
                    IlAdi = "NİĞDE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALTUNHİSAR" },
                        new Ilce { IlceAdi = "BOR" },
                        new Ilce { IlceAdi = "ÇAMARDI" },
                        new Ilce { IlceAdi = "ÇİFTLİK" },
                        new Ilce { IlceAdi = "ULUKIŞLA" }
                    }
                },
                new Il
                {
                    IlAdi = "ORDU",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKKUŞ" },
                        new Ilce { IlceAdi = "ALTINORDU" },
                        new Ilce { IlceAdi = "AYBASTI" },
                        new Ilce { IlceAdi = "ÇAMAŞ" },
                        new Ilce { IlceAdi = "ÇATALPINAR" },
                        new Ilce { IlceAdi = "ÇAYBAŞI" },
                        new Ilce { IlceAdi = "FATSA" },
                        new Ilce { IlceAdi = "GÖLKÖY" },
                        new Ilce { IlceAdi = "GÜLYALI" },
                        new Ilce { IlceAdi = "GÜRGENTEPE" },
                        new Ilce { IlceAdi = "İKİZCE" },
                        new Ilce { IlceAdi = "KABADÜZ" },
                        new Ilce { IlceAdi = "KABATAŞ" },
                        new Ilce { IlceAdi = "KORGAN" },
                        new Ilce { IlceAdi = "KUMRU" },
                        new Ilce { IlceAdi = "MESUDİYE" },
                        new Ilce { IlceAdi = "PERŞEMBE" },
                        new Ilce { IlceAdi = "ULUBEY" },
                        new Ilce { IlceAdi = "ÜNYE" }
                    }
                },
                new Il
                {
                    IlAdi = "RİZE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ARDEŞEN" },
                        new Ilce { IlceAdi = "ÇAMLIHEMŞİN" },
                        new Ilce { IlceAdi = "ÇAYELİ" },
                        new Ilce { IlceAdi = "DEREPAZARI" },
                        new Ilce { IlceAdi = "FINDIKLI" },
                        new Ilce { IlceAdi = "GÜNEYSU" },
                        new Ilce { IlceAdi = "HEMŞİN" },
                        new Ilce { IlceAdi = "İKİZDERE" },
                        new Ilce { IlceAdi = "İYİDERE" },
                        new Ilce { IlceAdi = "KALKANDERE" },
                        new Ilce { IlceAdi = "PAZAR" }
                    }
                },
                new Il
                {
                    IlAdi = "SAKARYA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ADAPAZARI" },
                        new Ilce { IlceAdi = "AKYAZI" },
                        new Ilce { IlceAdi = "ARİFİYE" },
                        new Ilce { IlceAdi = "ERENLER" },
                        new Ilce { IlceAdi = "FERİZLİ" },
                        new Ilce { IlceAdi = "GEYVE" },
                        new Ilce { IlceAdi = "HENDEK" },
                        new Ilce { IlceAdi = "KARAPÜRÇEK" },
                        new Ilce { IlceAdi = "KARASU" },
                        new Ilce { IlceAdi = "KAYNARCA" },
                        new Ilce { IlceAdi = "KOCAALİ" },
                        new Ilce { IlceAdi = "PAMUKOVA" },
                        new Ilce { IlceAdi = "SAPANCA" },
                        new Ilce { IlceAdi = "SERDİVAN" },
                        new Ilce { IlceAdi = "SÖĞÜTLÜ" },
                        new Ilce { IlceAdi = "TARAKLI" }
                    }
                },
                new Il
                {
                    IlAdi = "SAMSUN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "19 MAYIS" },
                        new Ilce { IlceAdi = "ALAÇAM" },
                        new Ilce { IlceAdi = "ASARCIK" },
                        new Ilce { IlceAdi = "ATAKUM" },
                        new Ilce { IlceAdi = "AYVACIK" },
                        new Ilce { IlceAdi = "BAFRA" },
                        new Ilce { IlceAdi = "CANİK" },
                        new Ilce { IlceAdi = "ÇARŞAMBA" },
                        new Ilce { IlceAdi = "HAVZA" },
                        new Ilce { IlceAdi = "İLKADIM" },
                        new Ilce { IlceAdi = "KAVAK" },
                        new Ilce { IlceAdi = "LADİK" },
                        new Ilce { IlceAdi = "SALIPAZARI" },
                        new Ilce { IlceAdi = "TEKKEKÖY" },
                        new Ilce { IlceAdi = "TERME" },
                        new Ilce { IlceAdi = "VEZİRKÖPRÜ" },
                        new Ilce { IlceAdi = "YAKAKENT" }
                    }
                },
                new Il
                {
                    IlAdi = "SİİRT",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAYKAN" },
                        new Ilce { IlceAdi = "ERUH" },
                        new Ilce { IlceAdi = "KURTALAN" },
                        new Ilce { IlceAdi = "PERVARİ" },
                        new Ilce { IlceAdi = "ŞİRVAN" },
                        new Ilce { IlceAdi = "TİLLO" }
                    }
                },
                new Il
                {
                    IlAdi = "SİNOP",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AYANCIK" },
                        new Ilce { IlceAdi = "BOYABAT" },
                        new Ilce { IlceAdi = "DİKMEN" },
                        new Ilce { IlceAdi = "DURAĞAN" },
                        new Ilce { IlceAdi = "ERFELEK" },
                        new Ilce { IlceAdi = "GERZE" },
                        new Ilce { IlceAdi = "SARAYDÜZÜ" },
                        new Ilce { IlceAdi = "TÜRKELİ" }
                    }
                },
                new Il
                {
                    IlAdi = "SİVAS",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKINCILAR" },
                        new Ilce { IlceAdi = "ALTINYAYLA" },
                        new Ilce { IlceAdi = "DİVRİĞİ" },
                        new Ilce { IlceAdi = "DOĞANŞAR" },
                        new Ilce { IlceAdi = "GEMEREK" },
                        new Ilce { IlceAdi = "GÖLOVA" },
                        new Ilce { IlceAdi = "GÜRÜN" },
                        new Ilce { IlceAdi = "HAFİK" },
                        new Ilce { IlceAdi = "İMRANLI" },
                        new Ilce { IlceAdi = "KANGAL" },
                        new Ilce { IlceAdi = "KOYULHİSAR" },
                        new Ilce { IlceAdi = "SUŞEHRİ" },
                        new Ilce { IlceAdi = "ŞARKIŞLA" },
                        new Ilce { IlceAdi = "ULAŞ" },
                        new Ilce { IlceAdi = "YILDIZELİ" },
                        new Ilce { IlceAdi = "ZARA" }
                    }
                },
                new Il
                {
                    IlAdi = "TEKİRDAĞ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ÇERKEZKÖY" },
                        new Ilce { IlceAdi = "ÇORLU" },
                        new Ilce { IlceAdi = "ERGENE" },
                        new Ilce { IlceAdi = "HAYRABOLU" },
                        new Ilce { IlceAdi = "KAPAKLI" },
                        new Ilce { IlceAdi = "MALKARA" },
                        new Ilce { IlceAdi = "MARMARAEREĞLİSİ" },
                        new Ilce { IlceAdi = "MURATLI" },
                        new Ilce { IlceAdi = "SARAY" },
                        new Ilce { IlceAdi = "SÜLEYMANPAŞA" },
                        new Ilce { IlceAdi = "ŞARKÖY" }
                    }
                },
                new Il
                {
                    IlAdi = "TOKAT",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALMUS" },
                        new Ilce { IlceAdi = "ARTOVA" },
                        new Ilce { IlceAdi = "BAŞÇİFTLİK" },
                        new Ilce { IlceAdi = "ERBAA" },
                        new Ilce { IlceAdi = "NİKSAR" },
                        new Ilce { IlceAdi = "PAZAR" },
                        new Ilce { IlceAdi = "REŞADİYE" },
                        new Ilce { IlceAdi = "SULUSARAY" },
                        new Ilce { IlceAdi = "TURHAL" },
                        new Ilce { IlceAdi = "YEŞİLYURT" },
                        new Ilce { IlceAdi = "ZİLE" }
                    }
                },
                new Il
                {
                    IlAdi = "TRABZON",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKÇAABAT" },
                        new Ilce { IlceAdi = "ARAKLI" },
                        new Ilce { IlceAdi = "ARSİN" },
                        new Ilce { IlceAdi = "BEŞİKDÜZÜ" },
                        new Ilce { IlceAdi = "ÇARŞIBAŞI" },
                        new Ilce { IlceAdi = "ÇAYKARA" },
                        new Ilce { IlceAdi = "DERNEKPAZARI" },
                        new Ilce { IlceAdi = "DÜZKÖY" },
                        new Ilce { IlceAdi = "HAYRAT" },
                        new Ilce { IlceAdi = "KÖPRÜBAŞI" },
                        new Ilce { IlceAdi = "MAÇKA" },
                        new Ilce { IlceAdi = "OF" },
                        new Ilce { IlceAdi = "ORTAHİSAR" },
                        new Ilce { IlceAdi = "SÜRMENE" },
                        new Ilce { IlceAdi = "ŞALPAZARI" },
                        new Ilce { IlceAdi = "TONYA" },
                        new Ilce { IlceAdi = "VAKFIKEBİR" },
                        new Ilce { IlceAdi = "YOMRA" }
                    }
                },
                new Il
                {
                    IlAdi = "TUNCELİ",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ÇEMİŞGEZEK" },
                        new Ilce { IlceAdi = "HOZAT" },
                        new Ilce { IlceAdi = "MAZGİRT" },
                        new Ilce { IlceAdi = "NAZIMİYE" },
                        new Ilce { IlceAdi = "OVACIK" },
                        new Ilce { IlceAdi = "PERTEK" },
                        new Ilce { IlceAdi = "PÜLÜMÜR" }
                    }
                },
                new Il
                {
                    IlAdi = "ŞANLIURFA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKÇAKALE" },
                        new Ilce { IlceAdi = "BİRECİK" },
                        new Ilce { IlceAdi = "BOZOVA" },
                        new Ilce { IlceAdi = "CEYLANPINAR" },
                        new Ilce { IlceAdi = "EYYÜBİYE" },
                        new Ilce { IlceAdi = "HALFETİ" },
                        new Ilce { IlceAdi = "HALİLİYE" },
                        new Ilce { IlceAdi = "HARRAN" },
                        new Ilce { IlceAdi = "HİLVAN" },
                        new Ilce { IlceAdi = "KARAKÖPRÜ" },
                        new Ilce { IlceAdi = "SİVEREK" },
                        new Ilce { IlceAdi = "SURUÇ" },
                        new Ilce { IlceAdi = "VİRANŞEHİR" }
                    }
                },
                new Il
                {
                    IlAdi = "UŞAK",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BANAZ" },
                        new Ilce { IlceAdi = "EŞME" },
                        new Ilce { IlceAdi = "KARAHALLI" },
                        new Ilce { IlceAdi = "SİVASLI" },
                        new Ilce { IlceAdi = "ULUBEY" }
                    }
                },
                new Il
                {
                    IlAdi = "VAN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAHÇESARAY" },
                        new Ilce { IlceAdi = "BAŞKALE" },
                        new Ilce { IlceAdi = "ÇALDIRAN" },
                        new Ilce { IlceAdi = "ÇATAK" },
                        new Ilce { IlceAdi = "EDREMİT" },
                        new Ilce { IlceAdi = "ERCİŞ" },
                        new Ilce { IlceAdi = "GEVAŞ" },
                        new Ilce { IlceAdi = "GÜRPINAR" },
                        new Ilce { IlceAdi = "İPEKYOLU" },
                        new Ilce { IlceAdi = "MURADİYE" },
                        new Ilce { IlceAdi = "ÖZALP" },
                        new Ilce { IlceAdi = "SARAY" },
                        new Ilce { IlceAdi = "TUŞBA" }
                    }
                },
                new Il
                {
                    IlAdi = "YOZGAT",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKDAĞMADENİ" },
                        new Ilce { IlceAdi = "AYDINCIK" },
                        new Ilce { IlceAdi = "BOĞAZLIYAN" },
                        new Ilce { IlceAdi = "ÇANDIR" },
                        new Ilce { IlceAdi = "ÇAYIRALAN" },
                        new Ilce { IlceAdi = "ÇEKEREK" },
                        new Ilce { IlceAdi = "KADIŞEHRİ" },
                        new Ilce { IlceAdi = "SARAYKENT" },
                        new Ilce { IlceAdi = "SARIKAYA" },
                        new Ilce { IlceAdi = "SORGUN" },
                        new Ilce { IlceAdi = "ŞEFAATLİ" },
                        new Ilce { IlceAdi = "YENİFAKILI" },
                        new Ilce { IlceAdi = "YERKÖY" }
                    }
                },
                new Il
                {
                    IlAdi = "ZONGULDAK",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALAPLI" },
                        new Ilce { IlceAdi = "ÇAYCUMA" },
                        new Ilce { IlceAdi = "DEVREK" },
                        new Ilce { IlceAdi = "EREĞLİ" },
                        new Ilce { IlceAdi = "GÖKÇEBEY" },
                        new Ilce { IlceAdi = "KİLİMLİ" },
                        new Ilce { IlceAdi = "KOZLU" }
                    }
                },
                new Il
                {
                    IlAdi = "AKSARAY",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AĞAÇÖREN" },
                        new Ilce { IlceAdi = "ESKİL" },
                        new Ilce { IlceAdi = "GÜLAĞAÇ" },
                        new Ilce { IlceAdi = "GÜZELYURT" },
                        new Ilce { IlceAdi = "ORTAKÖY" },
                        new Ilce { IlceAdi = "SARIYAHŞİ" },
                        new Ilce { IlceAdi = "SULTANHANI" }
                    }
                },
                new Il
                {
                    IlAdi = "BAYBURT",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AYDINTEPE" },
                        new Ilce { IlceAdi = "DEMİRÖZÜ" }
                    }
                },
                new Il
                {
                    IlAdi = "KARAMAN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AYRANCI" },
                        new Ilce { IlceAdi = "BAŞYAYLA" },
                        new Ilce { IlceAdi = "ERMENEK" },
                        new Ilce { IlceAdi = "KAZIMKARABEKİR" },
                        new Ilce { IlceAdi = "SARIVELİLER" }
                    }
                },
                new Il
                {
                    IlAdi = "KIRIKKALE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAHŞILI" },
                        new Ilce { IlceAdi = "BALIŞEYH" },
                        new Ilce { IlceAdi = "ÇELEBİ" },
                        new Ilce { IlceAdi = "DELİCE" },
                        new Ilce { IlceAdi = "KARAKEÇİLİ" },
                        new Ilce { IlceAdi = "KESKİN" },
                        new Ilce { IlceAdi = "SULAKYURT" },
                        new Ilce { IlceAdi = "YAHŞİHAN" }
                    }
                },
                new Il
                {
                    IlAdi = "BATMAN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BEŞİRİ" },
                        new Ilce { IlceAdi = "GERCÜŞ" },
                        new Ilce { IlceAdi = "HASANKEYF" },
                        new Ilce { IlceAdi = "KOZLUK" },
                        new Ilce { IlceAdi = "SASON" }
                    }
                },
                new Il
                {
                    IlAdi = "ŞIRNAK",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BEYTÜŞŞEBAP" },
                        new Ilce { IlceAdi = "CİZRE" },
                        new Ilce { IlceAdi = "GÜÇLÜKONAK" },
                        new Ilce { IlceAdi = "İDİL" },
                        new Ilce { IlceAdi = "SİLOPİ" },
                        new Ilce { IlceAdi = "ULUDERE" }
                    }
                },
                new Il
                {
                    IlAdi = "BARTIN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AMASRA" },
                        new Ilce { IlceAdi = "KURUCAŞİLE" },
                        new Ilce { IlceAdi = "ULUS" }
                    }
                },
                new Il
                {
                    IlAdi = "ARDAHAN",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ÇILDIR" },
                        new Ilce { IlceAdi = "DAMAL" },
                        new Ilce { IlceAdi = "GÖLE" },
                        new Ilce { IlceAdi = "HANAK" },
                        new Ilce { IlceAdi = "POSOF" }
                    }
                },
                new Il
                {
                    IlAdi = "IĞDIR",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ARALIK" },
                        new Ilce { IlceAdi = "KARAKOYUNLU" },
                        new Ilce { IlceAdi = "TUZLUCA" }
                    }
                },
                new Il
                {
                    IlAdi = "YALOVA",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ALTINOVA" },
                        new Ilce { IlceAdi = "ARMUTLU" },
                        new Ilce { IlceAdi = "ÇINARCIK" },
                        new Ilce { IlceAdi = "ÇİFTLİKKÖY" },
                        new Ilce { IlceAdi = "TERMAL" }
                    }
                },
                new Il
                {
                    IlAdi = "KARABÜK",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "EFLANİ" },
                        new Ilce { IlceAdi = "ESKİPAZAR" },
                        new Ilce { IlceAdi = "OVACIK" },
                        new Ilce { IlceAdi = "SAFRANBOLU" },
                        new Ilce { IlceAdi = "YENİCE" }
                    }
                },
                new Il
                {
                    IlAdi = "KİLİS",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "ELBEYLİ" },
                        new Ilce { IlceAdi = "MUSABEYLİ" },
                        new Ilce { IlceAdi = "POLATELİ" }
                    }
                },
                new Il
                {
                    IlAdi = "OSMANİYE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "BAHÇE" },
                        new Ilce { IlceAdi = "DÜZİÇİ" },
                        new Ilce { IlceAdi = "HASANBEYLİ" },
                        new Ilce { IlceAdi = "KADİRLİ" },
                        new Ilce { IlceAdi = "SUMBAS" },
                        new Ilce { IlceAdi = "TOPRAKKALE" }
                    }
                },
                new Il
                {
                    IlAdi = "DÜZCE",
                    Ilceler = new List<Ilce>
                    {
                        new Ilce { IlceAdi = "AKÇAKOCA" },
                        new Ilce { IlceAdi = "CUMAYERİ" },
                        new Ilce { IlceAdi = "ÇİLİMLİ" },
                        new Ilce { IlceAdi = "GÖLYAKA" },
                        new Ilce { IlceAdi = "GÜMÜŞOVA" },
                        new Ilce { IlceAdi = "KAYNAŞLI" },
                        new Ilce { IlceAdi = "YIĞILCA" }
                    }
                }
            };
        }
    }
}
