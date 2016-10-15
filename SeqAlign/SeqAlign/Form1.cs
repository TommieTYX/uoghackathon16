using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeqAlign
{
    public partial class Form1 : Form
    {
        void ShowPermutations<T>(IEnumerable<T> input, int count)
        {
            foreach (IEnumerable<T> permutation in PermuteUtils.Permute<T>(input, count))
            {
                foreach (T i in permutation)
                {
                    resultsTb.AppendText(i.ToString());
                    //Console.Write(" " + i);
                }
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
            }
        }

        List<string> showPerm<T>(IEnumerable<T> input, int count)
        {
            List<string> temp = new List<string>();
            GC.Collect();
            foreach (IEnumerable<T> permutation in PermuteUtils.Permute<T>(input, count))
            {

                string curStr = "";
                foreach (T i in permutation)
                {
                    //GC.Collect();
                    curStr += i.ToString();
                    //resultsTb.AppendText(i.ToString())
                    //Console.Write(" " + i);
                }
                temp.Add(curStr);
                curStr = null;
                /*resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);*/
            }

            return temp;
        }

        List<string> showPermJ(JArray input, int count)
        {
            List<string> temp = new List<string>();

            foreach (JArray permutation in PermuteUtils.Permute(input, count))
            {

                string curStr = "";
                foreach (JArray i in permutation)
                {
                    //GC.Collect();
                    curStr += i.ToString();
                    //resultsTb.AppendText(i.ToString())
                    //Console.Write(" " + i);
                }
                temp.Add(curStr);
                /*resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);*/
            }

            return temp;
        }

        public Form1()
        {
            InitializeComponent();
         
            var json1 = System.IO.File.ReadAllText(@"C:\Users\Yuxiang\Desktop\uoghackaton16\genomePieces\1k_digest_DFAD");
            var json2 = System.IO.File.ReadAllText(@"C:\Users\Yuxiang\Desktop\uoghackaton16\genomePieces\1k_digest_EDA");

            var objects1 = JArray.Parse(json1);// parse as array  
            var objects2 = JArray.Parse(json2);// parse as array  
            //string[] objects2 = JArray.Parse(json2).Select(jv => (string)jv).ToArray(); // parse as array  




            /*string[] stringInput = { "FDFCAFDFFAABCBABDCDBCAEEEEAAAFCEFCFDECDCAFFFCBDADECAFACEFDBDCCAFCEDFEDBCAAFFCCBECDAAFBABBEDDBEEBCFACFBACDACCCBFDABDCDCACBADEDFCEEDA",
                                    "FDAFFBEDBFBACCFBBBDEFBEDA",
                                    "CCACFADAADAADFDFECFBCFDDBDDFFFFDADBFEEFDADCBFDFBDBFBDCDAFBFBEDFBCDEDCCABDADAECCBBAAFACCBEADECFFFDECFDBEBEECAFEECABCEABFCBABEADCEEBABDCFDEDDABCBFADAFDBFFEFAFACDCEFCBEEBDBEBFFAEDCCBADBABDCEDDDEDCDCDFCEBAAAAEDA",
                                    "AECACCBBCFFEFADCEEDFDDDBDADEDA",
                                    "FFDEACDCDABCCFCDABBDFCCFEADBDBFBACFAFCDCFFBDEEEBCADABCECECBBECFECBABBFDEEDDFADBFBEABBDFACFBCEEDFEEDFEFDDDCBAABBACFEBDDFACECBBCAEEAFFBDADDBAEFDEEDCCEBCCDFCDACFCBBBABDDDDDFCFFBDBBABCDCCADFBFCFBCDCADAFDBDACCDDCEACAADABAEFAEEEEFBBDECDCADABECAFDEAEEDBCFEFAAAECBAEEBFEEBDEECFBBACBFFCEEECBEFDFFCFFEFBCEAFCCADAAEEEBEEACAABFABACDDACFEBDBFCEDBABAFABEFEAFBDBAFCAFEBADACCAEEFEECACBEEDBEACEEFAFFEBEAEBFBBFCDCBACBAABCABACBFBEEDBDEEAADDFBDBEDFCBFBEBDBAEBAAAFFFDDFEEFCEBFEFBCCFFDCDFEEABDDDDDEEFFEEDA",
                                    "BCDCBDFFDFDBAFBDCEEABECAFAEEDFDDEFEFFDAADEDCFACCDEBAAACDDBFBACEBBBFEBCDCACDFBBBBDDDACBCBDDBCBFCECCFFBCDAEECFABEBDFDFFCEBAFED"};

            string[] stringInput2 = { "BFBEABBDFACFBCEEDFEEDFEFDDDCBAABBACFEBDDFACECBBCAEEAFFBDADDBAEFDEEDCCEBCCDFCDACFCBBBABDDDDDFCFFBDBBABCDCCADFBFCFBCDCADAFDBDACCDDCEACAADABAEFAEEEEFBBDECDCADABECAFDEAEEDBCFEFAAAECBAEEBFEEBDEECFBBACBFFCEEECBEFDFFCFFEFBCEAFCCADAAEEEBEEACAABFABACDDACFEBDBFCEDBABAFABEFEAFBDBAFCAFEBADACCAEEFEECACBEEDBEACEEFAFFEBEAEBFBBFCDCBACBAABCABACBFBEEDBDEEAADDFBDBEDFCBFBEBDBAEBAAAFFFDDFEEFCEBFEFBCCFFDCDFEEABDDDDDEEFFEEDAAECACCBBCFFEFADCEEDFDDDBDADEDAFDFCAFDFFAABCBABDCDBCAEEEEAAAFCEFCFDECDCAFFFCBDADECAFACEFDBDCCAFCEDFEDBCAAFFCCBECDAAFBABBEDDBEEBCFACFBACDACCCBFDABDCDCACBADEDFCEEDAFDAFFBEDBFBACCFBBBDEFBEDABCDCBDFFDFDBAFBDCEEABECAFAEEDFDDEFEFFDAADEDCFACCDEBAAACDDBFBACEBBBFEBCDCACDFBBBBDDDACBCBDDBCBFCECCFFBCDAEECFABEBDFDFFCEBAFED",
                                        "CCACFADAADAADFDFECFBCFDDBDDFFFFDADBFEEFDADCBFDFBDBFBDCDAFBFBEDFBCDEDCCABDADAECCBBAAFACCBEADECFFFDECFDBEBEECAFEECABCEABFCBABEADCEEBABDCFDEDDABCBFADAFDBFFEFAFACDCEFCBEEBDBEBFFAEDCCBADBABDCEDDDEDCDCDFCEBAAAAEDAFFDEACDCDABCCFCDABBDFCCFEADBDBFBACFAFCDCFFBDEEEBCADABCECECBBECFECBABBFDEEDDFAD"};
            */
            //ShowPermutations<string>(stringInput, stringInput.Length);

            //List<string> aa = showPerm<string>(stringInput, stringInput.Length);
            //List<string> bb = showPerm<string>(stringInput2, stringInput2.Length);

            List<string> aa = new List<string>();
            List<string> bb = new List<string>();

            for (int i = 0; i < objects1.Count; i++)
            {
                aa.Add(objects1[i].ToString());
            }

            for (int i = 0; i < objects2.Count; i++)
            {
                bb.Add(objects2[i].ToString());
            }

            /*for(int i = 0; i < aaa.Length; i++)
            {
                resultsTb.AppendText(aaa[i]);
                resultsTb.AppendText(Environment.NewLine);
            }*/

            //List<string> bb = showPerm<string>(objects2, objects2.Length);

            //var common = aa.Intersect(bb).ToArray();

            //List<string> myResult = showPerm<string>(aaa, aaa.Length);
            List<string> myResult1 = showPerm<string>(aa, aa.Count);
            List<string> myResult2 = showPerm<string>(bb, bb.Count);
            var common = myResult1.Intersect(myResult2).ToArray();

            foreach (string item in common)
            {
                resultsTb.AppendText(item);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
            }

            /*for(int i = 0; i < common.Length; i++)
            {
                resultsTb.AppendText(common[i]);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
            }*/

            //resultsTb.AppendText(objects[0].ToString());
        }
    }
}
