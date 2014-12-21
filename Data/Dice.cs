using System.Windows.Forms;
namespace Vrchcaby.Data
{
    public class Dice
    {   
        public int Id { get; set; }
        public int Value { get; set; }
        public bool Selected { get; set; }
        public PictureBox FormElement { get; set; }
        
        public Dice()
        {
        }
    }
}
