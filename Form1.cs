using System.Text;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace PassengerCodeApp
{
    public partial class Form1 : Form
    {
        private string _name;
        private string _email;
        private Gender _gender;
        private TravelClass _travelClass;
        private Meals _meals;
        private DateTime _departingDate;
        private DateTime _departingTime;
        private DateTime _birthday;
        private City _departure;
        private City _destination;


        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private string GeneratePassengerCode()
        {
            var passengerCode = new StringBuilder();

            var destinationCode = GetDestinationCode();

            if (IsNightFlight())
            {
                passengerCode.Append(destinationCode.ToLower());
            }
            else
            {
                passengerCode.Append(destinationCode);
            }

            var child = IsChild();
            var genderCode = _gender == Gender.Male ? "X" : "Y";

            if (child)
            {
                passengerCode.Append(genderCode.ToLower());
            }
            else
            {
                passengerCode.Append(genderCode);
            }

            var mealsCode = GetMealsCode();

            if (child)
            {
                passengerCode.Append(mealsCode.ToLower());
            }
            else
            {
                passengerCode.Append(mealsCode);
            }

            var travelClass = GetTravelClassCode();
            passengerCode.Append(travelClass);

            var departurePrefix = GetDeparturePrefix();
            passengerCode.Append(departurePrefix);

            return passengerCode.ToString();
        }

        private string GetDeparturePrefix()
        {
            if (_departure.DestinationCode == DestinationCode.Europe)
            {
                return "-EU";
            }

            return "-ZZ";
        }

        private object GetTravelClassCode()
        {
            switch (_travelClass)
            {
                case TravelClass.First:
                    return "P";
                case TravelClass.Business:
                    return "Q";
                case TravelClass.Economy:
                    return "R";
                default:
                    return "0";
            }
        }

        private string GetMealsCode()
        {
            switch (_meals)
            {
                case Meals.European:
                    return "G";
                case Meals.Asian:
                    return "H";
                case Meals.Vegetarian:
                    return "K";
                default:
                    return "-";
            }
        }

        private bool IsChild()
        {
            var currentDate = DateTime.Now;
            var age = currentDate.Year - _birthday.Year;

            if (_birthday > currentDate.AddYears(-age))
            {
                age--;
            }

            return age < 18;
        }

        private bool IsNightFlight()
        {
            return _departingTime.Hour >= 22 || _departingTime.Hour < 6;
        }

        private string GetDestinationCode()
        {
            switch (_departure.DestinationCode)
            {
                case DestinationCode.UK:
                    return "U";
                case DestinationCode.Europe:
                    return "E";
                case DestinationCode.Asian:
                    return "A";
                case DestinationCode.American:
                    return "Z";
                default:
                    return "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateMealsCombobox();
            PopulateTravelClassCombobox();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm";
        }

        private void PopulateTravelClassCombobox()
        {
            comboBoxTravelClass.DataSource = Enum.GetValues(typeof(TravelClass));
        }

        private void PopulateMealsCombobox()
        {
            comboBoxMeals.DataSource = Enum.GetValues(typeof(Meals));
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = radioButtonMale.Checked ? Gender.Male : Gender.Female;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = radioButtonMale.Checked ? Gender.Female : Gender.Male;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            _name = textBoxName.Text;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            _email = textBoxEmail.Text;

            if (IsValidEmail(_email))
            {
                labelWrongEmail.Visible = false;
            }
            else
            {
                labelWrongEmail.Visible = true;
            }

        }

        public bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            var regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void comboBoxMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            _meals = (Meals)comboBoxMeals.SelectedIndex;
        }

        private void comboBoxTravelClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _travelClass = (TravelClass)comboBoxTravelClass.SelectedIndex;
        }

        private void buttonReceivePassengerCode_Click(object sender, EventArgs e)
        {
            var newPassenger = CreatePassenger();

            // Validate input
            if (newPassenger.Age < 1 || newPassenger.Age > 80)
            {
                MessageBox.Show("The birth date is unexeptable. Please, enter correct birth date", "Wrong birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!IsValidEmail(_email))
            {
                MessageBox.Show("The e-mail is invalid. Please, enter correct e-mail", "Invalid e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please, select your gender", "Invalid gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_departure == null)
            {
                MessageBox.Show("Please, select departure city", "Invalid departure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_destination == null)
            {
                MessageBox.Show("Please, select destination city", "Invalid destination", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var code = GeneratePassengerCode();
            var QRCodeURL = GetQR(code, 200);
            var codeWindow = new ShowGeneratedCode(QRCodeURL, code);
            codeWindow.ShowDialog();

        }

        private string GetQR(string passengerCode, int size)
        {
            return $"https://api.qrserver.com/v1/create-qr-code/?data={passengerCode}&size={size}x{size}";
        }

        private Passenger CreatePassenger()
        {
            return new Passenger()
            {
                Name = _name,
                Gender = _gender,
                Birthday = _birthday,
                Email = _email,
                Meals = _meals,
                DepartingDate = _departingDate,
                TravelClass = _travelClass,
                Departure = _departure,
                Destination = _destination
            };
        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            _birthday = dateTimePickerBirthday.Value;
        }

        private void dateTimePickerDepartingDate_ValueChanged(object sender, EventArgs e)
        {
            _departingDate = dateTimePickerDepartingDate.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _departingTime = dateTimePicker1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                _departure = null;
            }
            else
            {
                var city = new City(textBox1.Text);
                _departure = city;

                // There is no first class for UK
                if (city.DestinationCode == DestinationCode.UK)
                {
                    var excludedEnumValue = TravelClass.First;
                    var enumValues = Enum.GetValues(typeof(TravelClass))
                                         .Cast<TravelClass>()
                                         .Where(e => e != excludedEnumValue)
                                         .ToList();
                    comboBoxTravelClass.DataSource = enumValues;
                }
                else
                {
                    comboBoxTravelClass.DataSource = Enum.GetValues(typeof(TravelClass));
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {           

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                _destination = null;
            }
            else
            {
                var city = new City(textBox2.Text);
                _destination = city;
            }
        }
    }
}