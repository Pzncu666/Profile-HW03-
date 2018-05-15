using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 輸入學生資料
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] bloodtype = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };

            // 宣告
            double man = 0;
            double woman = 0;

            double bA = 0;
            double bB = 0;
            double bO = 0;
            double bAB = 0;
            double bOther = 0;

            string nameS = " ";

            double Highest = 0;
            double Shortest = 999;

            //計算男女生人數百分比(1,2))
            for (int i = 0 ; i < gender.Length; i++)
            {
                if (gender[i] == "男")
                {
                    man++;   
                }
                else
                {
                    woman++;
                }
            }

            double allgnder = gender.Length;
            double manPercent = (man / allgnder) * 100;
            double womanPercent = (woman / allgnder) * 100;
            

            //計算血型人數百分比(3)
            for (int i = 0; i < bloodtype.Length; i++)
            {
                if (bloodtype[i] == "A")
                {
                    bA++;
                }
                if (bloodtype[i] == "B")
                {
                    bB++;
                }
                if (bloodtype[i] == "O")
                {
                    bO++;
                }
                if (bloodtype[i] == "AB")
                {
                    bAB++;
                }
                else
                {
                    bOther++;
                }

            }
            double allb = bloodtype.Length;
            double APercent = 100 *  (bA / allb);
            double BPercent = 100 * (bB / allb);
            double OPercent = 100 * (bO / allb);
            double ABPercent = 100 * (bAB / allb);

            // 計算男女生身高(4,5,6)
            double tman = 0;
            double manTH = 0;
            for (int i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "男")
                {
                    if (height[i] < 200 && height[i] > 130)
                    {
                        manTH += height[i];
                        tman += 1;
                    }

                }
            }
            double twoman = 0;
            double womanTH = 0;
            for (int i = 0; i < gender.Length; i++)
            {

                if (gender[i] == "女")
                {
                    if (height[i] < 200 && height[i] > 130)
                    {
                        womanTH += height[i];
                        twoman += 1;
                    }

                }
            }

            // 天蠍O型人(7)
            for (int i = 0; i < bloodtype.Length; i++)
            {
                if (bloodtype[i] == "O")
                {
                    if (zodiac[i] == "天蠍")
                    {
                        nameS += name[i] + " ";
                    }
                }
            }

            // 最高&最矮身高(8)
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    if (height[i] > Highest)
                    {
                        Highest = height[i];
                    }

                    if (height[i] < Shortest)
                    {
                        Shortest = height[i];
                    }
                }
            }

            // 輸出
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("男生人數=" + man + " 百分比=" + manPercent + "%");
                Console.WriteLine("女生人數=" + woman + " 百分比=" + womanPercent + "%");
            Console.ForegroundColor = ConsoleColor.DarkCyan;           
                Console.WriteLine("A型人數=" + bA + " 百分比=" + APercent + "%");
                Console.WriteLine("B型人數=" + bB + " 百分比=" + BPercent + "%");
                Console.WriteLine("O型人數=" + bO + " 百分比=" + OPercent + "%");
                Console.WriteLine("AB型人數=" + bAB + " 百分比=" + ABPercent + "%");
                Console.WriteLine("其他人數=" + bOther + " 百分比=" + (100 - (APercent + BPercent + OPercent + ABPercent)) + "%");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("男生身高平均=" + manTH / tman);
                Console.WriteLine("女生身高平均=" + womanTH / twoman);
                Console.WriteLine("全身高平均=" + (manTH + womanTH) / (tman + twoman));
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("天蠍座O型的人=" + nameS);
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("身高最高為:" + Highest);
                Console.WriteLine("身高最矮為:" + Shortest);
            
            // 停住畫面
            Console.ReadLine();
        }
    }
}
