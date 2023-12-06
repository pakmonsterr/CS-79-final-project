local Font = {}

Font.info = 
    {
    face              = "NicoClean",
    file              = "CleanPlate.png",
    size              = 16,
    bold              = 0,
    italic            = 0,
    charset           = "",
    unicode           = 0,
    stretchH          = 100,
    smooth            = 1,
    aa                = 1,
    padding           = {0, 0, 0, 0},
    spacing           = 2,
    charsCount        = 95,
    kerningsCounts    = 0,
    }

Font.common =
    {
    lineHeight        = 18,
    base              = 13,
    scaleW            = 126,
    scaleH            = 179,
    pages             = 1,
    packed            = 0,
    }

Font.chars =
    {
    {id=32,x=28,y=170,width=0,height=0,xoffset=0,yoffset=14,xadvance=5,page=0,chnl=0,letter="space"},
    {id=33,x=108,y=108,width=5,height=15,xoffset=2,yoffset=0,xadvance=5,page=0,chnl=0,letter="!"},
    {id=34,x=79,y=156,width=7,height=8,xoffset=2,yoffset=0,xadvance=7,page=0,chnl=0,letter=string.char(34)},
    {id=35,x=42,y=22,width=16,height=15,xoffset=1,yoffset=0,xadvance=15,page=0,chnl=0,letter="#"},
    {id=36,x=36,y=2,width=12,height=17,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="$"},
    {id=37,x=16,y=125,width=16,height=14,xoffset=1,yoffset=1,xadvance=15,page=0,chnl=0,letter="%"},
    {id=38,x=82,y=40,width=13,height=15,xoffset=1,yoffset=0,xadvance=12,page=0,chnl=0,letter="&"},
    {id=39,x=88,y=156,width=4,height=8,xoffset=2,yoffset=0,xadvance=4,page=0,chnl=0,letter="'"},
    {id=40,x=50,y=2,width=7,height=17,xoffset=1,yoffset=0,xadvance=6,page=0,chnl=0,letter="("},
    {id=41,x=59,y=2,width=7,height=17,xoffset=1,yoffset=0,xadvance=6,page=0,chnl=0,letter=")"},
    {id=42,x=55,y=156,width=9,height=9,xoffset=1,yoffset=0,xadvance=8,page=0,chnl=0,letter="*"},
    {id=43,x=23,y=156,width=11,height=11,xoffset=1,yoffset=3,xadvance=10,page=0,chnl=0,letter="+"},
    {id=44,x=94,y=156,width=5,height=7,xoffset=2,yoffset=10,xadvance=5,page=0,chnl=0,letter=","},
    {id=45,x=2,y=170,width=10,height=5,xoffset=1,yoffset=6,xadvance=9,page=0,chnl=0,letter="-"},
    {id=46,x=14,y=170,width=5,height=5,xoffset=2,yoffset=10,xadvance=5,page=0,chnl=0,letter="."},
    {id=47,x=99,y=2,width=10,height=16,xoffset=0,yoffset=0,xadvance=8,page=0,chnl=0,letter="/"},
    {id=48,x=92,y=57,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="0"},
    {id=49,x=99,y=108,width=7,height=15,xoffset=1,yoffset=0,xadvance=6,page=0,chnl=0,letter="1"},
    {id=50,x=30,y=91,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="2"},
    {id=51,x=43,y=91,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="3"},
    {id=52,x=97,y=40,width=13,height=15,xoffset=0,yoffset=0,xadvance=11,page=0,chnl=0,letter="4"},
    {id=53,x=56,y=91,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="5"},
    {id=54,x=69,y=91,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="6"},
    {id=55,x=82,y=91,width=11,height=15,xoffset=0,yoffset=0,xadvance=9,page=0,chnl=0,letter="7"},
    {id=56,x=95,y=91,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="8"},
    {id=57,x=108,y=91,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="9"},
    {id=58,x=36,y=156,width=5,height=11,xoffset=2,yoffset=3,xadvance=5,page=0,chnl=0,letter=":"},
    {id=59,x=45,y=125,width=5,height=14,xoffset=2,yoffset=3,xadvance=5,page=0,chnl=0,letter=";"},
    {id=60,x=94,y=142,width=10,height=12,xoffset=2,yoffset=3,xadvance=10,page=0,chnl=0,letter="<"},
    {id=61,x=43,y=156,width=10,height=9,xoffset=2,yoffset=5,xadvance=10,page=0,chnl=0,letter="="},
    {id=62,x=106,y=142,width=10,height=12,xoffset=2,yoffset=3,xadvance=10,page=0,chnl=0,letter=">"},
    {id=63,x=54,y=108,width=10,height=15,xoffset=1,yoffset=0,xadvance=9,page=0,chnl=0,letter="?"},
    {id=64,x=60,y=22,width=16,height=15,xoffset=1,yoffset=0,xadvance=15,page=0,chnl=0,letter="@"},
    {id=65,x=2,y=40,width=14,height=15,xoffset=0,yoffset=0,xadvance=12,page=0,chnl=0,letter="A"},
    {id=66,x=106,y=57,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="B"},
    {id=67,x=18,y=40,width=14,height=15,xoffset=1,yoffset=0,xadvance=13,page=0,chnl=0,letter="C"},
    {id=68,x=2,y=57,width=13,height=15,xoffset=1,yoffset=0,xadvance=12,page=0,chnl=0,letter="D"},
    {id=69,x=2,y=108,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="E"},
    {id=70,x=15,y=108,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="F"},
    {id=71,x=34,y=40,width=14,height=15,xoffset=1,yoffset=0,xadvance=13,page=0,chnl=0,letter="G"},
    {id=72,x=2,y=74,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="H"},
    {id=73,x=115,y=108,width=5,height=15,xoffset=1,yoffset=0,xadvance=4,page=0,chnl=0,letter="I"},
    {id=74,x=89,y=108,width=8,height=15,xoffset=0,yoffset=0,xadvance=6,page=0,chnl=0,letter="J"},
    {id=75,x=17,y=57,width=13,height=15,xoffset=1,yoffset=0,xadvance=12,page=0,chnl=0,letter="K"},
    {id=76,x=66,y=108,width=10,height=15,xoffset=1,yoffset=0,xadvance=9,page=0,chnl=0,letter="L"},
    {id=77,x=78,y=22,width=15,height=15,xoffset=1,yoffset=0,xadvance=14,page=0,chnl=0,letter="M"},
    {id=78,x=32,y=57,width=13,height=15,xoffset=1,yoffset=0,xadvance=12,page=0,chnl=0,letter="N"},
    {id=79,x=95,y=22,width=15,height=15,xoffset=1,yoffset=0,xadvance=14,page=0,chnl=0,letter="O"},
    {id=80,x=16,y=74,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="P"},
    {id=81,x=68,y=2,width=15,height=16,xoffset=1,yoffset=0,xadvance=14,page=0,chnl=0,letter="Q"},
    {id=82,x=47,y=57,width=13,height=15,xoffset=1,yoffset=0,xadvance=12,page=0,chnl=0,letter="R"},
    {id=83,x=30,y=74,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="S"},
    {id=84,x=44,y=74,width=12,height=15,xoffset=0,yoffset=0,xadvance=10,page=0,chnl=0,letter="T"},
    {id=85,x=58,y=74,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="U"},
    {id=86,x=50,y=40,width=14,height=15,xoffset=0,yoffset=0,xadvance=12,page=0,chnl=0,letter="V"},
    {id=87,x=22,y=22,width=18,height=15,xoffset=-1,yoffset=0,xadvance=15,page=0,chnl=0,letter="W"},
    {id=88,x=66,y=40,width=14,height=15,xoffset=0,yoffset=0,xadvance=12,page=0,chnl=0,letter="X"},
    {id=89,x=62,y=57,width=13,height=15,xoffset=0,yoffset=0,xadvance=11,page=0,chnl=0,letter="Y"},
    {id=90,x=72,y=74,width=12,height=15,xoffset=0,yoffset=0,xadvance=10,page=0,chnl=0,letter="Z"},
    {id=91,x=2,y=2,width=7,height=18,xoffset=2,yoffset=0,xadvance=7,page=0,chnl=0,letter="["},
    {id=92,x=111,y=2,width=10,height=16,xoffset=1,yoffset=0,xadvance=9,page=0,chnl=0,letter=string.char(92)},
    {id=93,x=11,y=2,width=7,height=18,xoffset=1,yoffset=0,xadvance=6,page=0,chnl=0,letter="]"},
    {id=94,x=66,y=156,width=11,height=8,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="^"},
    {id=95,x=113,y=156,width=11,height=5,xoffset=1,yoffset=12,xadvance=10,page=0,chnl=0,letter="_"},
    {id=96,x=21,y=170,width=5,height=5,xoffset=3,yoffset=0,xadvance=6,page=0,chnl=0,letter="`"},
    {id=97,x=16,y=142,width=11,height=12,xoffset=1,yoffset=3,xadvance=10,page=0,chnl=0,letter="a"},
    {id=98,x=86,y=74,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="b"},
    {id=99,x=29,y=142,width=11,height=12,xoffset=1,yoffset=3,xadvance=10,page=0,chnl=0,letter="c"},
    {id=100,x=100,y=74,width=12,height=15,xoffset=1,yoffset=0,xadvance=11,page=0,chnl=0,letter="d"},
    {id=101,x=42,y=142,width=11,height=12,xoffset=1,yoffset=3,xadvance=10,page=0,chnl=0,letter="e"},
    {id=102,x=78,y=108,width=9,height=15,xoffset=0,yoffset=0,xadvance=7,page=0,chnl=0,letter="f"},
    {id=103,x=85,y=2,width=12,height=16,xoffset=0,yoffset=3,xadvance=10,page=0,chnl=0,letter="g"},
    {id=104,x=28,y=108,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="h"},
    {id=105,x=2,y=125,width=5,height=15,xoffset=1,yoffset=0,xadvance=4,page=0,chnl=0,letter="i"},
    {id=106,x=20,y=2,width=7,height=18,xoffset=-1,yoffset=0,xadvance=4,page=0,chnl=0,letter="j"},
    {id=107,x=41,y=108,width=11,height=15,xoffset=1,yoffset=0,xadvance=10,page=0,chnl=0,letter="k"},
    {id=108,x=9,y=125,width=5,height=15,xoffset=1,yoffset=0,xadvance=4,page=0,chnl=0,letter="l"},
    {id=109,x=71,y=125,width=15,height=12,xoffset=1,yoffset=3,xadvance=14,page=0,chnl=0,letter="m"},
    {id=110,x=55,y=142,width=11,height=12,xoffset=1,yoffset=3,xadvance=10,page=0,chnl=0,letter="n"},
    {id=111,x=88,y=125,width=12,height=12,xoffset=1,yoffset=3,xadvance=11,page=0,chnl=0,letter="o"},
    {id=112,x=2,y=91,width=12,height=15,xoffset=1,yoffset=3,xadvance=11,page=0,chnl=0,letter="p"},
    {id=113,x=16,y=91,width=12,height=15,xoffset=1,yoffset=3,xadvance=11,page=0,chnl=0,letter="q"},
    {id=114,x=13,y=156,width=8,height=12,xoffset=1,yoffset=3,xadvance=7,page=0,chnl=0,letter="r"},
    {id=115,x=2,y=156,width=9,height=12,xoffset=1,yoffset=3,xadvance=8,page=0,chnl=0,letter="s"},
    {id=116,x=34,y=125,width=9,height=14,xoffset=0,yoffset=1,xadvance=7,page=0,chnl=0,letter="t"},
    {id=117,x=68,y=142,width=11,height=12,xoffset=1,yoffset=3,xadvance=10,page=0,chnl=0,letter="u"},
    {id=118,x=102,y=125,width=12,height=12,xoffset=0,yoffset=3,xadvance=10,page=0,chnl=0,letter="v"},
    {id=119,x=52,y=125,width=17,height=12,xoffset=0,yoffset=3,xadvance=15,page=0,chnl=0,letter="w"},
    {id=120,x=2,y=142,width=12,height=12,xoffset=0,yoffset=3,xadvance=10,page=0,chnl=0,letter="x"},
    {id=121,x=77,y=57,width=13,height=15,xoffset=0,yoffset=3,xadvance=11,page=0,chnl=0,letter="y"},
    {id=122,x=81,y=142,width=11,height=12,xoffset=0,yoffset=3,xadvance=9,page=0,chnl=0,letter="z"},
    {id=123,x=2,y=22,width=8,height=16,xoffset=0,yoffset=0,xadvance=6,page=0,chnl=0,letter="{"},
    {id=124,x=29,y=2,width=5,height=18,xoffset=2,yoffset=0,xadvance=5,page=0,chnl=0,letter="|"},
    {id=125,x=12,y=22,width=8,height=16,xoffset=1,yoffset=0,xadvance=7,page=0,chnl=0,letter="}"},
    {id=126,x=101,y=156,width=10,height=6,xoffset=2,yoffset=6,xadvance=10,page=0,chnl=0,letter="~"},
    }

Font.kerning =
    {
    }

return Font