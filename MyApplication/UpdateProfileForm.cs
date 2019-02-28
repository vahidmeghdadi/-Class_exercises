using System;

namespace MyApplication
{
    internal class UpdateProfileForm
    {
        public bool IsDisposed { get; internal set; }
        public MainForm MdiParent { get; internal set; }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}