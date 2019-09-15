using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Polymorphism
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
