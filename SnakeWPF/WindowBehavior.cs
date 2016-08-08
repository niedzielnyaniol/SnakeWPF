using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace SnakeWPF
{
    public class WindowBehavior : Behavior<Window>
    {
        ViewModel vm;
        protected override void OnAttached()
        {
            Window window = this.AssociatedObject;
            if (window != null)
            {
                window.PreviewKeyDown += Window_PreviewKeyDown;
                vm = (ViewModel)window.DataContext;
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Window window = (Window)sender;

            switch (e.Key)
            {
                case Key.Down:
                    if (vm.Snake.Head.Direction != Model.Direction.Up)
                    {
                        vm.Snake.CurrentDirection = Model.Direction.Down;
                    }
                    break;
                case Key.Up:
                    if (vm.Snake.Head.Direction != Model.Direction.Down)
                    {
                        vm.Snake.CurrentDirection = Model.Direction.Up;
                    }
                    break;
                case Key.Left:
                    if (vm.Snake.Head.Direction != Model.Direction.Right)
                    {
                        vm.Snake.CurrentDirection = Model.Direction.Left;
                    }
                    break;
                case Key.Right:
                    if (vm.Snake.Head.Direction != Model.Direction.Left)
                    {
                        vm.Snake.CurrentDirection = Model.Direction.Right;
                    }
                    break;
                case Key.Space:
                    if (vm.Run)
                    {
                        vm.Move(vm.Snake.CurrentDirection);
                    }
                    break;
                case Key.Escape:
                    window.Close();
                    break;
            }
        }
    }
}
