using System.Windows.Controls;

namespace MediatorDemo
{
    /// <summary>
    /// Interaction logic for JobDetails.xaml
    /// </summary>
    public partial class JobDetails : UserControl
    {
        public JobDetails()
        {
            InitializeComponent();
            Mediator.GetInstance().JobChanged += (s, e) =>
            {
                this.DataContext = e.Job;
            };
        }

    }
}
