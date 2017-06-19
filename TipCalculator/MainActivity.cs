using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculator {
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]

	public class MainActivity : Activity {

        // Fields
        private EditText inputBill;
        private Button calculateButton;
        private TextView outputTip, outputTotal;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

            // Get our UI controls
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            // Add an onclick to the calculate button
            calculateButton.Click += (sender, e) => {
                string userInput = inputBill.Text;
                double amount = double.Parse(userInput);
                var tip = amount * 0.15;
                var totalPayment = amount + tip;

                // Set the text of the tip and total
                outputTip.Text = tip.ToString();
                outputTotal.Text = totalPayment.ToString();
            };

		}
	}
}

