using Avalonia.Threading;
using ReactiveUI;
using System;
using System.Reactive;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;

namespace DFRContentHost.Models
{
    public class FunctionRowButtonModel : ReactiveObject
    {
        private bool _enabled;
        private string _keyContent;
        private VirtualKeyCode _keyCode;

        public string Content
        {
            get => _keyContent;
            set => this.RaiseAndSetIfChanged(ref _keyContent, value);
        }

        public VirtualKeyCode Code
        {
            get => _keyCode;
            set => this.RaiseAndSetIfChanged(ref _keyCode, value);
        }

        public bool Enabled
        {
            get => _enabled;
            set => this.RaiseAndSetIfChanged(ref _enabled, value);
        }

        public ReactiveCommand<Unit, Unit> KeyCommand => ReactiveCommand.Create(SendKeyItem);

        private void SendKeyItem()
        {
            try
            {
                Random rnd = new Random();
                // Bypass anti InputSimulator in some application - random length
                //int number = rnd.Next(50, 100);
                var sim = new InputSimulator();
                sim.Keyboard.KeyDown(_keyCode);
                //Thread.Sleep(number);
                Thread.Sleep(50); // Bypass anti missclick & InputSimulator - 50 milliseconds 
                sim.Keyboard.KeyUp(_keyCode);
            }
            catch (Exception)
            {
                // ULPI issue
            }
        }

        public FunctionRowButtonModel() { }
        public FunctionRowButtonModel(string content, VirtualKeyCode code)
        {
            _enabled = true;
            _keyContent = content;
            _keyCode = code;
        }
    }
}
