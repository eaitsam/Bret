using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FrameworkAutomation.User_Management
{
    public enum Colors
    {
        Red,
        Green,
        Blue,
        CadetBlue
    }
    public class RGBColor
    {
        private string hexValue;
        private static readonly Dictionary<ColorName, RGBColor> colors = new Dictionary<ColorName, RGBColor>
        {
            //Color Name            (R, G, B, HEXVALUE)
            {ColorName.Aqua, new RGBColor(0,255,255,"00FFFF")},
            {ColorName.Aquamarine, new RGBColor(127,255,212,"7FFFD4")},
            {ColorName.Beige, new RGBColor(245,245,220,"F5F5DC")},
            {ColorName.Black, new RGBColor(0,0,0,"000000")},
            {ColorName.Blue, new RGBColor(0,0,255,"0000FF")},
            {ColorName.BlueViolet, new RGBColor(138,43,226,"8A2BE2")},
            {ColorName.CadetBlue,  new RGBColor(95,158,160,"5F9EA0")},
            {ColorName.CornflowerBlue, new RGBColor(100,149,237,"6495ED")},
            {ColorName.Cyan, new RGBColor(0,255,255,"00FFFF")},
            {ColorName.DarkBlue, new RGBColor(0,0,139,"00008B")},
            {ColorName.DarkCyan, new RGBColor(0,139,139,"008B8B")},
            {ColorName.DarkGreen, new RGBColor(0,100,0,"006400")},
            {ColorName.DarkSeaGreen, new RGBColor(143,188,143,"8FBC8F")},
            {ColorName.DarkSlateBlue, new RGBColor(72,61,139,"483D8B")},
            {ColorName.DarkSlateGray, new RGBColor(47,79,79,"2F4F4F")},
            {ColorName.DarkSlateGrey, new RGBColor(47,79,79,"2F4F4F")},
            {ColorName.DeepSkyBlue, new RGBColor(0,191,255,"00BFFF")},
            {ColorName.DarkOliveGreen, new RGBColor(85,107,47,"556B2F")},
            {ColorName.DarkTurquoise, new RGBColor(0,206,209,"00CED1")},
            {ColorName.DimGray, new RGBColor(105,105,105,"696969")},
            {ColorName.DimGrey, new RGBColor(105,105,105,"696969")},
            {ColorName.ForestGreen, new RGBColor(34,139,34,"228B22")},
            {ColorName.Green, new RGBColor(0,128,0,"008000")},
            {ColorName.Indigo, new RGBColor(75,0,130,"4B0082")},
            {ColorName.Lime, new RGBColor(0,255,0,"00FF00")},
            {ColorName.MidnightBlue, new RGBColor(25,25,112,"191970")},
            {ColorName.DodgerBlue, new RGBColor(30,144,255,"1E90FF")},
            {ColorName.LightSeaGreen, new RGBColor(32,178,170,"20B2AA")},
            {ColorName.LimeGreen, new RGBColor(50,205,50,"32CD32")},
            {ColorName.MediumBlue, new RGBColor(0,0,205,"0000CD")},
            {ColorName.MediumSpringGreen, new RGBColor(0,250,154,"00FA9A")},
            {ColorName.MediumTurquoise, new RGBColor(72,209,204,"48D1CC")},
            {ColorName.MediumSeaGreen, new RGBColor(60,179,113,"3CB371")},
            {ColorName.Navy, new RGBColor(0,0,128,"000080")},
            {ColorName.RoyalBlue, new RGBColor(65,105,225,"4169E1")},
            {ColorName.SeaGreen, new RGBColor(46,139,87,"2E8B57")},
            {ColorName.SlateBlue, new RGBColor(106,90,205,"6A5ACD")},
            {ColorName.SlateGray, new RGBColor(112,128,144,"708090")},
            {ColorName.SlateGrey, new RGBColor(112,128,144,"708090")},
            {ColorName.SteelBlue, new RGBColor(70,130,180,"4682B4")},
            {ColorName.SpringGreen, new RGBColor(0,255,127,"00FF7F")},
            {ColorName.Teal, new RGBColor(0,128,128,"008080")},
            {ColorName.Turquoise, new RGBColor(64,224,208,"40E0D0")},
            {ColorName.RebeccaPurple, new RGBColor(102,51,153,"663399")},
            {ColorName.MediumAquaMarine, new RGBColor(102,205,170,"66CDAA")},
            {ColorName.OliveDrab, new RGBColor(107,142,35,"6B8E23")},
            {ColorName.LightSlateGray, new RGBColor(119,136,153,"778899")},
            {ColorName.LightSlateGrey, new RGBColor(119,136,153,"778899")},
            {ColorName.MediumSlateBlue, new RGBColor(123,104,238,"7B68EE")},
            {ColorName.LawnGreen, new RGBColor(124,252,0,"7CFC00")},
            {ColorName.Chartreuse, new RGBColor(127,255,0,"7FFF00")},
            {ColorName.Maroon, new RGBColor(128,0,0,"800000")},
            {ColorName.Purple, new RGBColor(128,0,128,"800080")},
            {ColorName.Olive, new RGBColor(128,128,0,"808000")},
            {ColorName.Gray, new RGBColor(128,128,128,"808080")},
            {ColorName.Grey, new RGBColor(128,128,128,"808080")},
            {ColorName.SkyBlue, new RGBColor(135,206,235,"87CEEB")},
            {ColorName.LightSkyBlue, new RGBColor(135,206,250,"87CEFA")},
            {ColorName.DarkRed, new RGBColor(139,0,0,"8B0000")},
            {ColorName.DarkMagenta, new RGBColor(139,0,139,"8B008B")},
            {ColorName.SaddleBrown, new RGBColor(139,69,19,"8B4513")},
            {ColorName.LightGreen, new RGBColor(144,238,144,"90EE90")},
            {ColorName.MediumPurple, new RGBColor(147,112,219,"9370DB")},
            {ColorName.DarkViolet, new RGBColor(148,0,211,"9400D3")},
            {ColorName.PaleGreen, new RGBColor(152,251,152,"98FB98")},
            {ColorName.DarkOrchid, new RGBColor(153,50,204,"9932CC")},
            {ColorName.YellowGreen, new RGBColor(154,205,50,"9ACD32")},
            {ColorName.Sienna, new RGBColor(160,82,45,"A0522D")},
            {ColorName.Brown, new RGBColor(165,42,42,"A52A2A")},
            {ColorName.DarkGray, new RGBColor(169,169,169,"A9A9A9")},
            {ColorName.DarkGrey, new RGBColor(169,169,169,"A9A9A9")},
            {ColorName.LightBlue, new RGBColor(173,216,230,"ADD8E6")},
            {ColorName.GreenYellow, new RGBColor(173,255,47,"ADFF2F")},
            {ColorName.PaleTurquoise, new RGBColor(175,238,238,"AFEEEE")},
            {ColorName.LightSteelBlue, new RGBColor(176,196,222,"B0C4DE")},
            {ColorName.PowderBlue, new RGBColor(176,224,230,"B0E0E6")},
            {ColorName.FireBrick, new RGBColor(178,34,34,"B22222")},
            {ColorName.DarkGoldenRod, new RGBColor(184,134,11,"B8860B")},
            {ColorName.MediumOrchid, new RGBColor(186,85,211,"BA55D3")},
            {ColorName.RosyBrown, new RGBColor(188,143,143,"BC8F8F")},
            {ColorName.DarkKhaki, new RGBColor(189,183,107,"BDB76B")},
            {ColorName.Silver, new RGBColor(192,192,192,"C0C0C0")},
            {ColorName.MediumVioletRed, new RGBColor(199,21,133,"C71585")},
            {ColorName.IndianRed, new RGBColor(205,92,92,"CD5C5C")},
            {ColorName.Peru, new RGBColor(205,133,63,"CD853F")},
            {ColorName.Chocolate, new RGBColor(210,105,30,"D2691E")},
            {ColorName.Tan, new RGBColor(210,180,140,"D2B48C")},
            {ColorName.LightGray, new RGBColor(211,211,211,"D3D3D3")},
            {ColorName.LightGrey, new RGBColor(211,211,211,"D3D3D3")},
            {ColorName.Thistle, new RGBColor(216,191,216,"D8BFD8")},
            {ColorName.Orchid, new RGBColor(218,112,214,"DA70D6")},
            {ColorName.GoldenRod, new RGBColor(218,165,32,"DAA520")},
            {ColorName.PaleVioletRed, new RGBColor(219,112,147,"DB7093")},
            {ColorName.Crimson, new RGBColor(220,20,60,"DC143C")},
            {ColorName.Gainsboro, new RGBColor(220,220,220,"DCDCDC")},
            {ColorName.Plum, new RGBColor(221,160,221,"DDA0DD")},
            {ColorName.BurlyWood, new RGBColor(222,184,135,"DEB887")},
            {ColorName.LightCyan, new RGBColor(224,255,255,"E0FFFF")},
            {ColorName.Lavender, new RGBColor(230,230,250,"E6E6FA")},
            {ColorName.DarkSalmon, new RGBColor(233,150,122,"E9967A")},
            {ColorName.Violet, new RGBColor(238,130,238,"EE82EE")},
            {ColorName.PaleGoldenRod, new RGBColor(238,232,170,"EEE8AA")},
            {ColorName.LightCoral, new RGBColor(240,128,128,"F08080")},
            {ColorName.Khaki, new RGBColor(240,230,140,"F0E68C")},
            {ColorName.AliceBlue, new RGBColor(240,248,255,"F0F8FF")},
            {ColorName.HoneyDew, new RGBColor(240,255,240,"F0FFF0")},
            {ColorName.Azure, new RGBColor(240,255,255,"F0FFFF")},
            {ColorName.SandyBrown, new RGBColor(244,164,96,"F4A460")},
            {ColorName.Wheat, new RGBColor(245,222,179,"F5DEB3")},
            {ColorName.WhiteSmoke, new RGBColor(245,245,245,"F5F5F5")},
            {ColorName.MintCream, new RGBColor(245,255,250,"F5FFFA")},
            {ColorName.GhostWhite, new RGBColor(248,248,255,"F8F8FF")},
            {ColorName.Salmon, new RGBColor(250,128,114,"FA8072")},
            {ColorName.AntiqueWhite, new RGBColor(250,235,215,"FAEBD7")},
            {ColorName.Linen, new RGBColor(250,240,230,"FAF0E6")},
            {ColorName.LightGoldenRodYellow, new RGBColor(250,250,210,"FAFAD2")},
            {ColorName.OldLace, new RGBColor(253,245,230,"FDF5E6")},
            {ColorName.Red, new RGBColor(255,0,0,"FF0000")},
            {ColorName.Fuchsia, new RGBColor(255,0,255,"FF00FF")},
            {ColorName.Magenta, new RGBColor(255,0,255,"FF00FF")},
            {ColorName.DeepPink, new RGBColor(255,20,147,"FF1493")},
            {ColorName.OrangeRed, new RGBColor(255,69,0,"FF4500")},
            {ColorName.Tomato, new RGBColor(255,99,71,"FF6347")},
            {ColorName.HotPink, new RGBColor(255,105,180,"FF69B4")},
            {ColorName.Coral, new RGBColor(255,127,80,"FF7F50")},
            {ColorName.DarkOrange, new RGBColor(255,140,0,"FF8C00")},
            {ColorName.LightSalmon, new RGBColor(255,160,122,"FFA07A")},
            {ColorName.Orange, new RGBColor(255,165,0,"FFA500")},
            {ColorName.LightPink, new RGBColor(255,182,193,"FFB6C1")},
            {ColorName.Pink, new RGBColor(255,192,203,"FFC0CB")},
            {ColorName.Gold, new RGBColor(255,215,0,"FFD700")},
            {ColorName.PeachPuff, new RGBColor(255,218,185,"FFDAB9")},
            {ColorName.NavajoWhite, new RGBColor(255,222,173,"FFDEAD")},
            {ColorName.Moccasin, new RGBColor(255,228,181,"FFE4B5")},
            {ColorName.Bisque, new RGBColor(255,228,196,"FFE4C4")},
            {ColorName.MistyRose, new RGBColor(255,228,225,"FFE4E1")},
            {ColorName.BlanchedAlmond, new RGBColor(255,235,205,"FFEBCD")},
            {ColorName.PapayaWhip, new RGBColor(255,239,213,"FFEFD5")},
            {ColorName.LavenderBlush, new RGBColor(255,240,245,"FFF0F5")},
            {ColorName.SeaShell, new RGBColor(255,245,238,"FFF5EE")},
            {ColorName.Cornsilk, new RGBColor(255,248,220,"FFF8DC")},
            {ColorName.LemonChiffon, new RGBColor(255,250,205,"FFFACD")},
            {ColorName.FloralWhite, new RGBColor(255,250,240,"FFFAF0")},
            {ColorName.Snow, new RGBColor(255,250,250,"FFFAFA")},
            {ColorName.Yellow, new RGBColor(255,255,0,"FFFF00")},
            {ColorName.LightYellow, new RGBColor(255,255,224,"FFFFE0")},
            {ColorName.Ivory, new RGBColor(255,255,240,"FFFFF0")},
            {ColorName.White, new RGBColor(255,255,255,"FFFFFF")}
        };



        public ColorName Name { get; set; } = ColorName.None;
        public ColorType Type { get; set; } = ColorType.None;

        public string HexValue
        {
            get { return $"#{hexValue}"; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    if (this.Name != ColorName.None)
                    {
                        hexValue = RGBColor.GetByName(this.Name, 0).HexValue;
                    }
                }
                else
                {
                    hexValue = StripHash(value);
                }
            }
        }

        private int Red { get; set; } = 0;
        private int Green { get; set; } = 0;
        private int Blue { get; set; } = 0;
        private decimal Opacity { get; set; } = 1;

        public RGBColor() { }
        public RGBColor(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }
        public RGBColor(int r, int g, int b, string hexValue) : this(r, g, b)
        {
            HexValue = hexValue;
        }
        private static RGBColor Clone(RGBColor rgbc)
        {
            return new RGBColor(rgbc.Red, rgbc.Green, rgbc.Blue, rgbc.HexValue);
        }
        private string DisplayOpacity()
        {
            //Check for whole numbers
            if (Opacity == 1)
                return "1";
            if (Opacity == 0)
                return "0";
            //OK, so the number is from .01 to .99. If the number only has a tenths place, write one number
            //otherwise give it two decimal places
            if (((Opacity * 100) % 10) == 0)
            {
                return $"{Opacity,0:F1}";
            }
            else
            {
                return $"{Opacity,0:F2}";
            }
        }
        public static RGBColor GetByName(ColorName name)
        {
            if (colors.ContainsKey(name))
            {
                return RGBColor.Clone(colors[name]);
            }

            return new RGBColor();
        }
        public static RGBColor GetByHexValue(string hexValue)
        {
            hexValue = StripHash(hexValue);
            var value = colors.Values.FirstOrDefault(x => x.HexValue == hexValue);
            return RGBColor.Clone(value) ?? new RGBColor();
        }
        public static RGBColor GetByName(ColorName name, decimal opacity)
        {

            if (colors.ContainsKey(name))
            {
                var rgba = RGBColor.Clone(colors[name]);
                rgba.Opacity = opacity;
                return rgba;
            }
            return new RGBColor();
        }
        private static string StripHash(string value)
        {
            if (value.StartsWith("#"))
            {
                value = value.Remove(0);
            }
            return value;
        }

        public string ToRGB()
        {
            return $"rgb({Red}, {Green}, {Blue})";
        }

        public string ToRGBA()
        {
            return $"rgba({Red}, {Green}, {Blue}, {DisplayOpacity()})";
        }
    }

    public enum ColorName
    {
        None,
        AliceBlue,
        AntiqueWhite,
        Aqua,
        Aquamarine,
        Azure,
        Beige,
        Bisque,
        Black,
        BlanchedAlmond,
        Blue,
        BlueViolet,
        Brown,
        BurlyWood,
        CadetBlue,
        Chartreuse,
        Chocolate,
        Coral,
        CornflowerBlue,
        Cornsilk,
        Crimson,
        Cyan,
        DarkBlue,
        DarkCyan,
        DarkGoldenRod,
        DarkGray,
        DarkGreen,
        DarkGrey,
        DarkKhaki,
        DarkMagenta,
        DarkOliveGreen,
        DarkOrange,
        DarkOrchid,
        DarkRed,
        DarkSalmon,
        DarkSeaGreen,
        DarkSlateBlue,
        DarkSlateGray,
        DarkSlateGrey,
        DarkTurquoise,
        DarkViolet,
        DeepPink,
        DeepSkyBlue,
        DimGray,
        DimGrey,
        DodgerBlue,
        FireBrick,
        FloralWhite,
        ForestGreen,
        Fuchsia,
        Gainsboro,
        GhostWhite,
        Gold,
        GoldenRod,
        Gray,
        Green,
        GreenYellow,
        Grey,
        HoneyDew,
        HotPink,
        IndianRed,
        Indigo,
        Ivory,
        Khaki,
        Lavender,
        LavenderBlush,
        LawnGreen,
        LemonChiffon,
        LightBlue,
        LightCoral,
        LightCyan,
        LightGoldenRodYellow,
        LightGray,
        LightGreen,
        LightGrey,
        LightPink,
        LightSalmon,
        LightSeaGreen,
        LightSkyBlue,
        LightSlateGray,
        LightSlateGrey,
        LightSteelBlue,
        LightYellow,
        Lime,
        LimeGreen,
        Linen,
        Magenta,
        Maroon,
        MediumAquaMarine,
        MediumBlue,
        MediumOrchid,
        MediumPurple,
        MediumSeaGreen,
        MediumSlateBlue,
        MediumSpringGreen,
        MediumTurquoise,
        MediumVioletRed,
        MidnightBlue,
        MintCream,
        MistyRose,
        Moccasin,
        NavajoWhite,
        Navy,
        OldLace,
        Olive,
        OliveDrab,
        Orange,
        OrangeRed,
        Orchid,
        PaleGoldenRod,
        PaleGreen,
        PaleTurquoise,
        PaleVioletRed,
        PapayaWhip,
        PeachPuff,
        Peru,
        Pink,
        Plum,
        PowderBlue,
        Purple,
        RebeccaPurple,
        Red,
        RosyBrown,
        RoyalBlue,
        SaddleBrown,
        Salmon,
        SandyBrown,
        SeaGreen,
        SeaShell,
        Sienna,
        Silver,
        SkyBlue,
        SlateBlue,
        SlateGray,
        SlateGrey,
        Snow,
        SpringGreen,
        SteelBlue,
        Tan,
        Teal,
        Thistle,
        Tomato,
        Turquoise,
        Violet,
        Wheat,
        White,
        WhiteSmoke,
        Yellow,
        YellowGreen
    }

    public enum ColorType
    {
        Name,
        Hex,
        None
    }
}
