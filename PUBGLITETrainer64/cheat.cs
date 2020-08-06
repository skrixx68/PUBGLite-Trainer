﻿using System.Collections;

namespace PUBGLITETrainer64
{
    class cheat
    {
        public string ant = "F3 02 B1 42 3F 8E AE 42 EA D2 C9 C2 00 00 80 3F 00 00 80 3F 00 00 80 3F 01";
        public string antOri = "0xF3 0x02 0xB1 0x42 0x3F 0x8E 0xAE 0x42 0xEA 0xD2 0xC9 0xC2 0x00 0x00 0x80 0x3F 0x00 0x00 0x80 0x3F 0x00 0x00 0x80 0x3F 0x01";
        public string anton = "0x00 0x00 0xFC 0x3F 0x00 0x00 0xFC 0x3F 0xEA 0xD2 0xC9 0xC2 0x00 0xC0 0x79 0x44 0x00 0x00 0x80 0x3F 0x00 0x00 0x80 0x3F 0x01";
        public string jump = "01 00 00 00 00 00 80 3F 00 00 0C 42 00 80 DD 43 00 00 00 3F 00 00 5C 42 E8";
        public string jumpOri = "0x01 0x00 0x00 0x00 0x00 0x00 0x80 0x3F 0x00 0x00 0x0C 0x42 0x00 0x80 0xDD 0x43 0x00 0x00 0x00 0x3F 0x00 0x00 0x5C 0x42 0xE8";
        public string jumpOn = "0x01 0x00 0x00 0x00 0x00 0x00 0x40 0x40 0x00 0x00 0x0C 0x42 0x00 0x40 0x1C 0x45 0x00 0x00 0x00 0x00 0x00 0x00 0x5C 0x42 0xE8";
        public string norecoil = "54 73 6C 52 65 63 6F 69 6C 43 6F 6D 70 6F 6E 65 6E 74";
        public string norecoilOri = "0x54 0x73 0x6C 0x52 0x65 0x63 0x6F 0x69 0x6C 0x43 0x6F 0x6D 0x70 0x6F 0x6E 0x65 0x6E 0x74";
        public string norecoilOn = "0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91";
        public string fog = "46 6F 67";
        public string fogOri = "0x46 0x6F 0x67";
        public string fogOn = "0x91 0x91 0x91";
        public string grass = "47 72 61 73 73";
        public string grassOri = "0x47 0x72 0x61 0x73 0x73";
        public string grassOn = "0x00 0x00 0x00 0x00 0x00";
        public string removeWater = "5F 5F 57 61 74 65 72";
        public string removeWaterOri = "0x5F 0x5F 0x57 0x61 0x74 0x65 0x72";
        public string removeWateron = "0x91 0x91 0x91 0x91 0x91 0x91 0x91";
        public string driveText = "AE C5 9D 74 FF FF";
        public string driveTextOri = "0xAE 0xC5 0x9D 0x74 0xFF 0xFF";
        public string driveTextOn = "0xAE 0xC5 0x9D 0x74 0xFF 0xFF";
        public string speed = "00 00 80 3F 00 00 80 3F 00 00 80 3F 17 B7 D1 38";
        public string speedOri = "0x00 0x00 0x80 0x3F 0x00 0x00 0x80 0x3F 0x00 0x00 0x80 0x3F 0x17 0xB7 0xD1 0x38";
        public string speedOn = "0xE1 0x7A 0x94 0x3F 0xE1 0x7A 0x94 0x3F 0xE1 0x7A 0x94 0x3F 0x17 0xB7 0xD1 0x38";
        public string noObj = "44 65 66 61 75 6C 74 5F 5F 53 74 61 74 69 63 4D 65 73 68 00";
        public string noObjOri = "0x44 0x65 0x66 0x61 0x75 0x6C 0x74 0x5F 0x5F 0x53 0x74 0x61 0x74 0x69 0x63 0x4D 0x65 0x73 0x68 0x00";
        public string noObjOn = "0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x91 0x00";
        public string whiteflr = "44 65 66 61 75 6C 74 5F 5F 4C 61 6E 64 73 63 61 70 65 4D 61 74 65 72 69 61 6C 49 6E 73 74 61 6E 63 65 43 6F 6E 73 74 61 6E 74";
        public string whiteflrOri = "44 65 66 61 75 6C 74 5F 5F 4C 61 6E 64 73 63 61 70 65 4D 61 74 65 72 69 61 6C 49 6E 73 74 61 6E 63 65 43 6F 6E 73 74 61 6E 74";
        public string whiteflrOn = "91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91 91";
        public long startAddress = 0x1000000000;
        public long endAddress = 0x4000000000;
    }



    class curAddr
    {
        public ArrayList recoilLST = new ArrayList();
        public ArrayList speedLST = new ArrayList();
        public ArrayList jumpLST = new ArrayList();
        public ArrayList antLST = new ArrayList();
        public ArrayList noGrassLST = new ArrayList();

        public int recoil = 1;
        public  int speed = 2;
        public  int jump = 3;
        public int ant = 4;
        public int grass = 5;

    }
}

//public string setCheat(string cheatPattern, string cheatOriginal, string cheatOverride, int type)
//{
//    string address = "";
//    string oldaddr = "";
//    while (!address.Equals("0"))
//    {
//        var res = AoBScan(cheatPattern, true, false);
//        address = res.Result.FirstOrDefault().ToString("x");

//        if (type == 1)
//        {
//            curAddress.recoilLST.Add(address);
//            oldaddr = oldaddr + "\n " + address.ToString();
//            Console.Out.WriteLine(curAddress.recoilLST.Count.ToString());
//            if (type == 2)
//            {
//                curAddress.speedLST.Add(address);
//                oldaddr = oldaddr + "\n " + address.ToString();
//                Console.Out.WriteLine(curAddress.speedLST.Count.ToString());
//                if (type == 3)
//                {
//                    curAddress.jumpLST.Add(address);
//                    oldaddr = oldaddr + "\n " + address.ToString();
//                    Console.Out.WriteLine(curAddress.jumpLST.Count.ToString());
//                    if (type == 4)
//                    {
//                        curAddress.antLST.Add(address);
//                        oldaddr = oldaddr + "\n " + address.ToString();
//                        Console.Out.WriteLine(curAddress.antLST.Count.ToString());
//                    }
//                }
//            }
//        }
//        meme.writeMemory(address, "bytes", cheatOverride);
//        Thread.Sleep(1000);
//    }

//    MessageBox.Show("Done , Address = " + oldaddr.ToString());
//    return address;
//}