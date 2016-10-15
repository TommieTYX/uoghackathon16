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

            foreach (IEnumerable<T> permutation in PermuteUtils.Permute<T>(input, count))
            {

                string curStr = "";
                foreach (T i in permutation)
                {
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


            string[] stringInput = { "FDFCAFDFFAABCBABDCDBCAEEEEAAAFCEFCFDECDCAFFFCBDADECAFACEFDBDCCAFCEDFEDBCAAFFCCBECDAAFBABBEDDBEEBCFACFBACDACCCBFDABDCDCACBADEDFCEEDA",
                                    "FDAFFBEDBFBACCFBBBDEFBEDA",
                                    "CCACFADAADAADFDFECFBCFDDBDDFFFFDADBFEEFDADCBFDFBDBFBDCDAFBFBEDFBCDEDCCABDADAECCBBAAFACCBEADECFFFDECFDBEBEECAFEECABCEABFCBABEADCEEBABDCFDEDDABCBFADAFDBFFEFAFACDCEFCBEEBDBEBFFAEDCCBADBABDCEDDDEDCDCDFCEBAAAAEDA",
                                    "AECACCBBCFFEFADCEEDFDDDBDADEDA",
                                    "FFDEACDCDABCCFCDABBDFCCFEADBDBFBACFAFCDCFFBDEEEBCADABCECECBBECFECBABBFDEEDDFADBFBEABBDFACFBCEEDFEEDFEFDDDCBAABBACFEBDDFACECBBCAEEAFFBDADDBAEFDEEDCCEBCCDFCDACFCBBBABDDDDDFCFFBDBBABCDCCADFBFCFBCDCADAFDBDACCDDCEACAADABAEFAEEEEFBBDECDCADABECAFDEAEEDBCFEFAAAECBAEEBFEEBDEECFBBACBFFCEEECBEFDFFCFFEFBCEAFCCADAAEEEBEEACAABFABACDDACFEBDBFCEDBABAFABEFEAFBDBAFCAFEBADACCAEEFEECACBEEDBEACEEFAFFEBEAEBFBBFCDCBACBAABCABACBFBEEDBDEEAADDFBDBEDFCBFBEBDBAEBAAAFFFDDFEEFCEBFEFBCCFFDCDFEEABDDDDDEEFFEEDA",
                                    "BCDCBDFFDFDBAFBDCEEABECAFAEEDFDDEFEFFDAADEDCFACCDEBAAACDDBFBACEBBBFEBCDCACDFBBBBDDDACBCBDDBCBFCECCFFBCDAEECFABEBDFDFFCEBAFED"};

            string[] stringInput2 = { "BFBEABBDFACFBCEEDFEEDFEFDDDCBAABBACFEBDDFACECBBCAEEAFFBDADDBAEFDEEDCCEBCCDFCDACFCBBBABDDDDDFCFFBDBBABCDCCADFBFCFBCDCADAFDBDACCDDCEACAADABAEFAEEEEFBBDECDCADABECAFDEAEEDBCFEFAAAECBAEEBFEEBDEECFBBACBFFCEEECBEFDFFCFFEFBCEAFCCADAAEEEBEEACAABFABACDDACFEBDBFCEDBABAFABEFEAFBDBAFCAFEBADACCAEEFEECACBEEDBEACEEFAFFEBEAEBFBBFCDCBACBAABCABACBFBEEDBDEEAADDFBDBEDFCBFBEBDBAEBAAAFFFDDFEEFCEBFEFBCCFFDCDFEEABDDDDDEEFFEEDAAECACCBBCFFEFADCEEDFDDDBDADEDAFDFCAFDFFAABCBABDCDBCAEEEEAAAFCEFCFDECDCAFFFCBDADECAFACEFDBDCCAFCEDFEDBCAAFFCCBECDAAFBABBEDDBEEBCFACFBACDACCCBFDABDCDCACBADEDFCEEDAFDAFFBEDBFBACCFBBBDEFBEDABCDCBDFFDFDBAFBDCEEABECAFAEEDFDDEFEFFDAADEDCFACCDEBAAACDDBFBACEBBBFEBCDCACDFBBBBDDDACBCBDDBCBFCECCFFBCDAEECFABEBDFDFFCEBAFED",
                                        "CCACFADAADAADFDFECFBCFDDBDDFFFFDADBFEEFDADCBFDFBDBFBDCDAFBFBEDFBCDEDCCABDADAECCBBAAFACCBEADECFFFDECFDBEBEECAFEECABCEABFCBABEADCEEBABDCFDEDDABCBFADAFDBFFEFAFACDCEFCBEEBDBEBFFAEDCCBADBABDCEDDDEDCDCDFCEBAAAAEDAFFDEACDCDABCCFCDABBDFCCFEADBDBFBACFAFCDCFFBDEEEBCADABCECECBBECFECBABBFDEEDDFAD"};
            //ShowPermutations<string>(stringInput, stringInput.Length);

            List<string> aa = showPerm<string>(stringInput, stringInput.Length);
            List<string> bb = showPerm<string>(stringInput2, stringInput2.Length);

            var common = aa.Intersect(bb).ToArray();

            /*List<string> myResult = showPerm<string>(stringInput, stringInput.Length);
            foreach (string item in myResult)
            {
                resultsTb.AppendText(item);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
            }*/

            /*for(int i = 0; i < common.Length; i++)
            {
                resultsTb.AppendText(common[i]);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
                resultsTb.AppendText(Environment.NewLine);
            }*/

            string text = System.IO.File.ReadAllText(@"C:\Users\Yuxiang\Desktop\uoghackaton16\genomePieces\1k_digest_DFAD");


            var json = System.IO.File.ReadAllText(@"C:\Users\Yuxiang\Desktop\uoghackaton16\genomePieces\1k_digest_DFAD");

            var objects = JArray.Parse(json); // parse as array  


            resultsTb.AppendText(objects[0].ToString());
        }
    }
}
