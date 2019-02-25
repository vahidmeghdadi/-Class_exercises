//namespace MyApplication.Infrastructure
using MyApplication;

namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static Models.User AuthenticatedUser { get; set; }

        private static MyApplication.MainForm mainForm;
        //private static LoginForm loginForm;
        //private static RegisterForm registerForm;

        public static MyApplication.MainForm MainForm
		{
			get
			{
				if (mainForm==null)
				{
					mainForm =
						new MyApplication.MainForm();
				}

				mainForm.InitializeMainForm();

				return mainForm;
			}
		}

        private static MyApplication.LoginForm loginForm;

        public static MyApplication .LoginForm LoginForm
		{
			get
			{
				if(loginForm==null)
				{
					loginForm =
						new MyApplication.LoginForm();
				}

				loginForm.ResetForm();

				return loginForm;
			}
		}

        private static MyApplication.RegisterForm registerForm;

		public static MyApplication.RegisterForm RegisterForm
		{

			get
			{
				if (registerForm == null)
				{
					registerForm =
						new MyApplication.RegisterForm();
				}

				//registerForm.resetForm();

				return registerForm;
			}
		}


	}
}
