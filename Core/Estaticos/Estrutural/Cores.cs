using System.Drawing;
using System.Windows.Forms;

namespace Core
{
    public class Colors
    {
    	public static Color Primary{
    		get{
    			return Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
    		}
    	}
        public static DataGridViewCellStyle HeaderStyle {
            get {
                return new DataGridViewCellStyle {
                    BackColor = Color.White,
                    Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Padding = new Padding(0, 5, 0, 5),
                    WrapMode = DataGridViewTriState.True
                };
            }
        }

        public static DataGridViewCellStyle CellStyle {
            get {
                return new DataGridViewCellStyle {
                    BackColor = Color.White,
                    Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point),
                    ForeColor = Color.DimGray,
                    Padding = new Padding(0, 5, 0, 5),
                    SelectionBackColor = Color.SteelBlue,
                    SelectionForeColor = Color.White,
                    WrapMode = DataGridViewTriState.True
                };
            }
        }

        public static Color Default {
            get { return Color.White; }
        }

        public static Color Error {
            get { return Color.LemonChiffon; }
        }
    }
}
