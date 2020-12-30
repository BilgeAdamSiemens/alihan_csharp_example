﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using StudentNoteSystem.Entity;


namespace StudentNoteSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            String path = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }

            bool isExistsFile = File.Exists(path);

            List<Student> studentList = new List<Student>();

            if (isExistsFile)
            {
                String[] lines = File.ReadAllLines(path);


                foreach (String line in lines)
                {
                    Student student = Student.Parse(line);
                    studentList.Add(student);
                }


                studentList.Sort();
                studentList.Reverse();

                foreach(Student student in studentList)
                {
                    AddStudentToListView(student);
                }

            }
            else
            {
                MessageBox.Show("Dosya Yolu Bulunamadı");
            }
        }

        private void AddStudentToListView(Student student)
        {
            ListViewItem lvi = studentListView.Items.Add(student.Number + "");


            lvi.BackColor = student.IsPass ? Color.Green : Color.Red;

            lvi.SubItems.Add(student.VisaNote + "");
            lvi.SubItems.Add(student.FinalNote + "");
            lvi.SubItems.Add(student.GetNoteAvg() + "");
            lvi.SubItems.Add(student.IsPass + "");
            lvi.SubItems.Add(student.LetterNote + "");
        }

        private void FillStudentListView(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                AddStudentToListView(student);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentListView.View = View.Details;
            studentListView.Columns.Add("Student Number");
            studentListView.Columns.Add("Visa Note");
            studentListView.Columns.Add("Final Note");
            studentListView.Columns.Add("Avg");
            studentListView.Columns.Add("Is Pass");
            studentListView.Columns.Add("Letter");
        }
    }
}
