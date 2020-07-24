

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public class Mopp
{
    private string[] protocol_s = { "01", "10", "11" };
    private string[] serienr_s = { "000001", "000010", "000011", "000100", "000101", "000111", "001000", "001001", "001010", "001011", "001100", "001101", "001111", "001100", "001101", "001110", "001111", "010000", "010001", "010010", "010011", "010100", "010101", "010111", "011000", "011001", "011010", "011011", "011111", "100000", "100001", "100010", "100011", "100100", "100101", "100111", "101000", "101001", "101010", "101011", "101111", "110000", "110001", "110010", "110011", "110100", "110101", "110111", "111000", "111001", "111010", "111011", "111100", "111101", "111110", "111111" };
    private string protocol;
    private string serienr;
    private string wpm = "010010";
    StringBuilder hexadecimal = new StringBuilder();
    private Random rand = new Random();

    public Mopp()
        {
        
        }


     public String Read_Mopp_Word(byte[] data)
    {
        string bitString = BitConverter.ToString(data);
        string bin = HexStringToBinary(bitString.ToString());

        string text = BinToString(bin);
        return text;
    }

    public byte[] Sent_Mopp_Word(string text)
    {
        
        string SentBin = TextToBin(text);
        byte[] SentBytes = BinToHex(SentBin);
        return SentBytes;
    }

    private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
        { '0', "0000" },
        { '1', "0001" },
        { '2', "0010" },
        { '3', "0011" },
        { '4', "0100" },
        { '5', "0101" },
        { '6', "0110" },
        { '7', "0111" },
        { '8', "1000" },
        { '9', "1001" },
        { 'a', "1010" },
        { 'b', "1011" },
        { 'c', "1100" },
        { 'd', "1101" },
        { 'e', "1110" },
        { 'f', "1111" }
    };

    private string HexStringToBinary(string hex)
    {
        StringBuilder result = new StringBuilder();
        hex = hex.Replace("-", " ");
        hex = hex.Replace("00", "");
        string hexstring = hex.Replace("\"", "");

        foreach (char c in hex)
        {
            try
            {
                // This will crash for non-hex characters. You might want to handle that differently.
                result.Append(hexCharacterToBinary[char.ToLower(c)]);
            }
            catch { }
        }
        return result.ToString();
    }



    private string BinToString(string bin)
    {
        protocol = bin.Substring(0, 2);
        //  Console.WriteLine(protocol);
        serienr = bin.Substring(2, 6);
        //   Console.WriteLine(serienr);
        wpm = bin.Substring(8, 6);
        //   Console.WriteLine(wpm);
        string text = bin.Substring(14, bin.Length - 14);
        //  Console.WriteLine(text);
        string temp_r = "";
        List<string> listText_1 = new List<string>();
        List<string> listText_2 = new List<string>();
        text += "00";
        foreach(var r in text)
        {
            temp_r += r;
            if(temp_r.Length==2)
            {
                listText_1.Add(temp_r);
                temp_r = "";
            }
        }
        string h = "";
        foreach(var t in listText_1)
        {   
            if((t != "00")&&(t!="11"))
            {
                h += t;
            }
            else
            {
                listText_2.Add(h);
                h = "";
            }
                
        }
        string cw_text = "";
       
        

        foreach (var w in listText_2)
        {
            if( w.Contains("010101010101"))
            {
                cw_text = "*";
            }
            if (w == "0110")
            {
                cw_text += "a";
            }
            
            if (w == "10010101")
            {
                cw_text += "b";
            }
           
            if (w == "10011001")
            {
                cw_text += "c";
            }
            
            if (w == "100101")
            {
                cw_text += "d";
            }
            
            if (w == ("01"))
            {
                cw_text += "e";
            }
            
            if (w == "01011001")
            {
                cw_text += "f";
            }
           
            if (w == "101001")
            {
                cw_text += "g";
            }
            
            if (w == "01010101")
            {
                cw_text += "h";
            }
           
            if (w == "0101")
            {
                cw_text += "i";
            }
            
            if (w == "01101010")
            {
                cw_text += "j";
            }
            
            if (w == "100110")
            {
                cw_text += "k";
            }
            
            if (w == "01100101")
            {
                cw_text += "l";
            }
            
            if (w == "1010")
            {
                cw_text += "m";
            }
           
            if (w == "1001")
            {
                cw_text += "n";
            }
            
            if (w == "101010")
            {
                cw_text += "o";
            }
            
            if (w == "01101001")
            {
                cw_text += "p";
            }
            
            if (w == "10100110")
            {
                cw_text += "q";
            }
            
            if (w == "011001")
            {
                cw_text += "r";
            }
            
            if (w == "010101")
            {
                cw_text += "s";
            }
            
            if (w == "10")
            {
                cw_text += "t";
            }
            
            if (w == "010110")
            {
                cw_text += "u";
            }
            
            if (w == "01010110")
            {
                cw_text += "v";
            }
           
            if (w == "011010")
            {
                cw_text += "w";
            }
           
            if (w == "10010110")
            {
                cw_text += "x";
            }
           
            if (w == "10011010")
            {
                cw_text += "y";
            }
           
            if (w == "10100101")
            {
                cw_text += "z";
            }
            
            if (w == "1010101010")
            {
                cw_text += "0";
            }
            
            if (w == "0110101010")
            {
                cw_text += "1";
            }
            
            if (w == "0101101010")
            {
                cw_text += "2";
            }
            
            if (w == "0101011010")
            {
                cw_text += "3";
            }
            
            if (w == "0101010110")
            {
                cw_text += "4";
            }
           
            if (w == "0101010101")
            {
                cw_text += "5";
            }
            
            if (w == "1001010101")
            {
                cw_text += "6";
            }
            
            if (w == "1010010101")
            {
                cw_text += "7";
            }
            
            if (w == "1010100101")
            {
                cw_text += "8";
            }
           
            if (w == "1010101001")
            {
                cw_text += "9";
            }
            
           
            if (w == "101001011010")
            {
                cw_text += ",";
            }
            
            if (w == "011001100110")
            {
                cw_text += ".";
            }
            
            if (w == "1001011001")
            {
                cw_text += "/";
            }
            
            if (w == "010101100110")
            {
                cw_text += "<sk>";
            }
            if (w == "1001101001")            {
                cw_text += "<kn>";
            }
            
            if ( w == "010110100101")
            {
                cw_text += "?";
            }
           
            


        }

        return cw_text;


    }

    public string TextToBin(string text)
    {
        string sent_bin = "";
        sent_bin = protocol_s[rand.Next(0,protocol_s.Length-1)] + serienr_s[rand.Next(0,serienr_s.Length-1)] + wpm;

        string cw_text = "";
        text = text.ToLower();

        int text_length = text.Length;
        int a = 0;
        foreach (var w in text)
        {

            a++;
            switch (w)
            {
                case 'a':
                    cw_text += "0110";
                    break;
                case 'b':
                    cw_text += "10010101";
                    break;
                case 'c':
                    cw_text += "10011001";
                    break;
                case 'd':
                    cw_text += "100101";
                    break;
                case 'e':
                    cw_text += "01";
                    break;
                case 'f':
                    cw_text += "01011001";
                    break;
                case 'g':
                    cw_text += "101001";
                    break;
                case 'h':
                    cw_text += "01010101";
                    break;
                case 'i':
                    cw_text += "0101";
                    break;
                case 'j':
                    cw_text += "01101010";
                    break;
                case 'k':
                    cw_text += "100110";
                    break;
                case 'l':
                    cw_text += "01100101";
                    break;
                case 'm':
                    cw_text += "1010";
                    break;
                case 'n':
                    cw_text += "1001";
                    break;
                case 'o':
                    cw_text += "101010";
                    break;
                case 'p':
                    cw_text += "01101001";
                    break;
                case 'q':
                    cw_text += "10100110";
                    break;
                case 'r':
                    cw_text += "011001";
                    break;
                case 's':
                    cw_text += "010101";
                    break;
                case 't':
                    cw_text += "10";
                    break;
                case 'u':
                    cw_text += "010110";
                    break;
                case 'v':
                    cw_text += "01010110";
                    break;
                case 'w':
                    cw_text += "011010";
                    break;
                case 'x':
                    cw_text += "10010110";
                    break;
                case 'y':
                    cw_text += "10011010";
                    break;
                case 'z':
                    cw_text += "10100101";
                    break;
                case '?':
                    cw_text += "010110100101";
                    break;
                case ',':
                    cw_text += "101001011010";
                    break;
                case '.':
                    cw_text += "011001100110";
                    break;
                case '/':
                    cw_text += "1001011001";
                    break;
                case '0':
                    cw_text += "1010101010";
                    break;
                case '1':
                    cw_text += "0110101010";
                    break;
                case '2':
                    cw_text += "0101101010";
                    break;
                case '3':
                    cw_text += "0101011010";
                    break;
                case '4':
                    cw_text += "0101010110";
                    break;
                case '5':
                    cw_text += "0101010101";
                    break;
                case '6':
                    cw_text += "1001010101";
                    break;
                case '7':
                    cw_text += "1010010101";
                    break;
                case '8':
                    cw_text += "1010100101";
                    break;
                case '9':
                    cw_text += "1010101001";
                    break;
                case ' ':
                    cw_text += "0000";
                    break;
                case '$':
                    cw_text += "1001101001";
                    break;
                case '@':
                    cw_text += "010101100110";
                    break;

            }
            if (a == text_length)
            {
                cw_text += "11";

            }
            else
            {
                cw_text += "00";

            }

        }
        sent_bin += cw_text;

        return sent_bin; ;



    }

    public byte[] BinToHex(string bin)
    {

       
        hexadecimal.Clear();
        while(bin.Length % 4!=0)
        {
            bin += "0";

        }
       
        StringBuilder binary = new StringBuilder(bin);
        
        try
        {

            string tempbin = bin;
            
            StringBuilder word = new StringBuilder("0000");
            for (int p = 0; p < binary.Length; p += 4)
            {
                for (int j = p; j < p + 4; j++)
                {
                    word[j % 4] = binary[j];
                }
                
                switch (word.ToString())
                {
                    case "0000": hexadecimal.Append('0'); tempbin = tempbin.Remove(0, 4); break;
                    case "0001": hexadecimal.Append('1'); tempbin = tempbin.Remove(0, 4); break;
                    case "0010": hexadecimal.Append('2'); tempbin = tempbin.Remove(0, 4); break;
                    case "0011": hexadecimal.Append('3'); tempbin = tempbin.Remove(0, 4); break;
                    case "0100": hexadecimal.Append('4'); tempbin = tempbin.Remove(0, 4); break;
                    case "0101": hexadecimal.Append('5'); tempbin = tempbin.Remove(0, 4); break;
                    case "0110": hexadecimal.Append('6'); tempbin = tempbin.Remove(0, 4); break;
                    case "0111": hexadecimal.Append('7'); tempbin = tempbin.Remove(0, 4); break;
                    case "1000": hexadecimal.Append('8'); tempbin = tempbin.Remove(0, 4); break;
                    case "1001": hexadecimal.Append('9'); tempbin = tempbin.Remove(0, 4); break;
                    case "1010": hexadecimal.Append('A'); tempbin = tempbin.Remove(0, 4); break;
                    case "1011": hexadecimal.Append('B'); tempbin = tempbin.Remove(0, 4); break;
                    case "1100": hexadecimal.Append('C'); tempbin = tempbin.Remove(0, 4); break;
                    case "1101": hexadecimal.Append('D'); tempbin = tempbin.Remove(0, 4); break;
                    case "1110": hexadecimal.Append('E'); tempbin = tempbin.Remove(0, 4); break;
                    case "1111": hexadecimal.Append('F'); tempbin = tempbin.Remove(0, 4); break;
                   

                }
                
            }

        }
        catch
        {
            
        }
        string newbyte = "";
        string n = "";
        int e = 2;
        while(hexadecimal.Length % 2 !=0)
        {
            hexadecimal.Append("0");
        }

        foreach (var q in hexadecimal.ToString())
        {
            n += q;
            if (e == 3)
            {
                e = 1;
                newbyte += n + " ";
                n = "";
            }
            e++;
        }
        
        newbyte = newbyte.Remove(newbyte.Length - 1);
       
        byte[] hex_array = newbyte.Split().Select(s => Convert.ToByte(s, 16)).ToArray();
        return hex_array;
        //hvordan får jeg sat 0x med over i byte array, den sender kun korrect når 0x er med.

     

       
    }
   
}