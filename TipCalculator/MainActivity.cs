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
		}
	}
}

