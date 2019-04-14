using System.Drawing;

namespace CurceRPVS.Model
{
    public class Settings
    {
        public Color colorLineGraf { get; set; }
        public int lineThickness { get; set; }
        public bool AsixX { get; set; }
        public bool AsixY { get; set; }

        public Settings()
        {
            colorLineGraf = Color.Red;
            lineThickness = 1;
            AsixX = true;
            AsixY = true;

            time_Check = true;
            mass_Check = true;
            q_Check = true;
            dq0_Check = true;
            c_Check = true;
            w_Check = true;
            E_Check = true;
        }

        public bool time_Check { get; set; }
        public bool mass_Check { get; set; }
        public bool q_Check { get; set; }
        public bool dq0_Check { get; set; }
        public bool c_Check { get; set; }
        public bool w_Check { get; set; }
        public bool E_Check { get; set; }
    }
}
