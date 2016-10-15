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

        public Form1()
        {
            InitializeComponent();


            string[] stringInput = { "FDFCAFDFFAABCBABDCDBCAEEEEAAAFCEFCFDECDCAFFFCBDADECAFACEFDBDCCAFCEDFEDBCAAFFCCBECDAAFBABBEDDBEEBCFACFBACDACCCBFDABDCDCACBADEDFCEEDA",
                                    "FDAFFBEDBFBACCFBBBDEFBEDA",
                                    "CCACFADAADAADFDFECFBCFDDBDDFFFFDADBFEEFDADCBFDFBDBFBDCDAFBFBEDFBCDEDCCABDADAECCBBAAFACCBEADECFFFDECFDBEBEECAFEECABCEABFCBABEADCEEBABDCFDEDDABCBFADAFDBFFEFAFACDCEFCBEEBDBEBFFAEDCCBADBABDCEDDDEDCDCDFCEBAAAAEDA",
                                    "AECACCBBCFFEFADCEEDFDDDBDADEDA",
                                    "FFDEACDCDABCCFCDABBDFCCFEADBDBFBACFAFCDCFFBDEEEBCADABCECECBBECFECBABBFDEEDDFADBFBEABBDFACFBCEEDFEEDFEFDDDCBAABBACFEBDDFACECBBCAEEAFFBDADDBAEFDEEDCCEBCCDFCDACFCBBBABDDDDDFCFFBDBBABCDCCADFBFCFBCDCADAFDBDACCDDCEACAADABAEFAEEEEFBBDECDCADABECAFDEAEEDBCFEFAAAECBAEEBFEEBDEECFBBACBFFCEEECBEFDFFCFFEFBCEAFCCADAAEEEBEEACAABFABACDDACFEBDBFCEDBABAFABEFEAFBDBAFCAFEBADACCAEEFEECACBEEDBEACEEFAFFEBEAEBFBBFCDCBACBAABCABACBFBEEDBDEEAADDFBDBEDFCBFBEBDBAEBAAAFFFDDFEEFCEBFEFBCCFFDCDFEEABDDDDDEEFFEEDA",
                                    "BCDCBDFFDFDBAFBDCEEABECAFAEEDFDDEFEFFDAADEDCFACCDEBAAACDDBFBACEBBBFEBCDCACDFBBBBDDDACBCBDDBCBFCECCFFBCDAEECFABEBDFDFFCEBAFED"};
            ShowPermutations<string>(stringInput, stringInput.Length);
        }
    }
}
