using System.Runtime.InteropServices;

namespace Practice
{
    public partial class GuestPage1 : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForml;

        //constructor
        public GuestPage1()
        {
            InitializeComponent();
            random = new Random();
        }
        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);

            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelBase.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 106, 79);
                    previousBtn.ForeColor = Color.Transparent;
                    previousBtn.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                }
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonGuests_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }

}
