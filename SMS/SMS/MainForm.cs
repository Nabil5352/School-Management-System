using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public enum SequenceEnum
    {
        //Log in
        LogInWindow_Control,
        //Admin home
        HomeAdmin_Control,
        //Admin settings
        Admin_Settings,
        //User home
        HomeWindow_Control,
        //All person
        AllPerson_Control,
        //Permitted users
        Users_Control,
        //Teachers
        Teachers_Control,
        //Students
        Students_Control,
        //Class
        Class_Control,
        //Subject
        Subject_Control,
        //Result
        Result_Control,
        //Progress
        Progress_Control,
        //Achievement
        Achievement_Control,
        //Vision
        Vision_Control,
        //Notice
        Notice_Control,
        //Create Person
        CreatePerson_Control,
        //User Log
        UserLog_Control,
        //Create Teacher
        CreateTeacher_Control,
        //Create Student
        CreateStudent_Control,
        //Add result
        AddResult_Control,
        //Edit Person
        EditPerson_Control,
        //Edit Teacher
        EditTeacher_Control,
        //Edit student
        EditStudent_Control,
        //Edit class
        EditClass_Control,
        //Event Control
        Event_Control
    }

    public partial class mainWindow : Form
    {       
        private IDictionary<SequenceEnum, Control> controls = new Dictionary<SequenceEnum, Control>();
        public mainWindow()
        {
            InitializeComponent();
            ShowControl(SequenceEnum.LogInWindow_Control);
        }

        internal void ShowControl(SequenceEnum value)
        {
            Control new_value = null;

            if (controls.ContainsKey(value))
            {
                new_value = controls[value];
            }
            else
            {
                new_value = CreateControl(value);
                controls[value] = new_value;
            }

            new_value.Parent = this;
            new_value.Dock = DockStyle.Fill;
            new_value.BringToFront();
            new_value.Show();
        }

        private Control CreateControl(SequenceEnum value)
        {
            switch (value)
            {
                case SequenceEnum.LogInWindow_Control:
                    return new LogInPage();
                case SequenceEnum.HomeWindow_Control:
                    return new UserHomeWindow();
                case SequenceEnum.HomeAdmin_Control:
                    return new HomeAdmin();
                case SequenceEnum.Admin_Settings:
                    return new AdminSettings();
                case SequenceEnum.AllPerson_Control:
                    return new AllPerson();
                case SequenceEnum.Users_Control:
                    return new Users();
                case SequenceEnum.UserLog_Control:
                    return new UserLog();
                case SequenceEnum.Teachers_Control:
                    return new Teachers();
                case SequenceEnum.Students_Control:
                    return new lblStatus();
                case SequenceEnum.Class_Control:
                    return new Classes();
                case SequenceEnum.Subject_Control:
                    return new Subject();
                case SequenceEnum.Result_Control:
                    return new Result();
                case SequenceEnum.Progress_Control:
                    return new Progress();
                case SequenceEnum.Achievement_Control:
                    return new Achievement();
                case SequenceEnum.Vision_Control:
                    return new Vision();
                case SequenceEnum.Notice_Control:
                    return new Notices();
                case SequenceEnum.CreatePerson_Control:
                    return new CreatePerson();
                case SequenceEnum.CreateTeacher_Control:
                    return new CreateTeacher();
                case SequenceEnum.CreateStudent_Control:
                    return new CreateStudent();
                case SequenceEnum.AddResult_Control:
                    return new AddResult();
                case SequenceEnum.EditPerson_Control:
                    return new EditPerson();
                case SequenceEnum.EditTeacher_Control:
                    return new EditTeacher();
                case SequenceEnum.EditStudent_Control:
                    return new EditStudent();
                case SequenceEnum.EditClass_Control:
                    return new EditClass();
                case SequenceEnum.Event_Control:
                    return new Event();
                default:
                    return null;
            }
        }

    }
}
