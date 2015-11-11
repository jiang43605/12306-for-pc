using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrainAssistant
{
    /// <summary>
    /// NotifyMsgWindow.xaml 的交互逻辑
    /// </summary>
    public partial class NotifyMsgWindow : UserControl
    {
        private bool isClosing = false;

        #region BalloonText dependency property

        /// <summary>
        /// 标题
        /// </summary>
        public static readonly DependencyProperty BalloonTextTitleProperty =
            DependencyProperty.Register("BalloonTextTitle",
                typeof(string),
                typeof(NotifyMsgWindow),
                new FrameworkPropertyMetadata(""));

        /// <summary>
        /// A property wrapper for the <see cref="BalloonTextProperty"/>
        /// dependency property:<br/>
        /// Description
        /// </summary>
        public string BalloonTextTitle
        {
            get { return (string)GetValue(BalloonTextTitleProperty); }
            set { SetValue(BalloonTextTitleProperty, value); }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public static readonly DependencyProperty BalloonTextContentProperty =
            DependencyProperty.Register("BalloonTextContent",
                typeof(string),
                typeof(NotifyMsgWindow),
                new FrameworkPropertyMetadata(""));

        /// <summary>
        /// A property wrapper for the <see cref="BalloonTextContentProperty"/>
        /// dependency property:<br/>
        /// Description
        /// </summary>
        public string BalloonTextContent
        {
            get { return (string)GetValue(BalloonTextContentProperty); }
            set { SetValue(BalloonTextContentProperty, value); }
        }

        #endregion

        public NotifyMsgWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// By subscribing to the <see cref="TaskbarIcon.BalloonClosingEvent"/>
        /// and setting the "Handled" property to true, we suppress the popup
        /// from being closed in order to display the custom fade-out animation.
        /// </summary>
        private void OnBalloonClosing(object sender, RoutedEventArgs e)
        {
            e.Handled = true; //suppresses the popup from being closed immediately
            isClosing = true;
        }


        /// <summary>
        /// Resolves the <see cref="TaskbarIcon"/> that displayed
        /// the balloon and requests a close action.
        /// </summary>
        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //the tray icon assigned this attached property to simplify access
            TaskbarIcon taskbarIcon = TaskbarIcon.GetParentTaskbarIcon(this);
            taskbarIcon.CloseBalloon();
        }

        /// <summary>
        /// If the users hovers over the balloon, we don't close it.
        /// </summary>
        private void grid_MouseEnter(object sender, MouseEventArgs e)
        {
            //if we're already running the fade-out animation, do not interrupt anymore
            //(makes things too complicated for the sample)
            if (isClosing) return;

            //the tray icon assigned this attached property to simplify access
            TaskbarIcon taskbarIcon = TaskbarIcon.GetParentTaskbarIcon(this);
            taskbarIcon.ResetBalloonCloseTimer();
        }


        /// <summary>
        /// Closes the popup once the fade-out animation completed.
        /// The animation was triggered in XAML through the attached
        /// BalloonClosing event.
        /// </summary>
        private void OnFadeOutCompleted(object sender, EventArgs e)
        {
            //Popup pp = (Popup)Parent;
            //pp.IsOpen = false;
        }
    }
}
