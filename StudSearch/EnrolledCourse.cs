﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudSearch
{
    public class EnrolledCourse
    {
        #region Members
        /// <summary>
        /// represents the <see cref="string"/> "Info"
        /// </summary>
        public static string Info = "Info";
        private Course m_Info;
        /// <summary>
        /// represents the <see cref="Course"/> data
        /// </summary>
        public Course info
        {
            get { return m_Info; }
            set { m_Info = value; }
        }

        /// <summary>
        /// represents the <see cref="string"/> "Course ID"
        /// </summary>
        public static string CourseID = "Course ID";
        private int m_courseID;
        /// <summary>
        /// represents the course
        /// </summary>
        public int courseID
        {
            get { return m_courseID; }
            set { m_courseID = value; }
        }


        public static string CourseNumber = "Course Number";
        private int m_courseNumber;
        public int courseNumber
        {
            get { return m_courseNumber; }
            set { m_courseNumber = value; }
        }

        /// <summary>
        /// represents the <see cref="string"/> "Semester"
        /// </summary>
        public static string Semester = "Semester";
        private SemesterType m_semester;
        /// <summary>
        /// represents a <see cref="semester"/> of the course the student has taken.
        /// </summary>
        /// <see cref="SemesterType"/> 
        public SemesterType semester
        {
            get { return m_semester; }
            set { m_semester = value; }
        }

        /// <summary>
        /// represents the <see cref="string"/> "Year"
        /// </summary>
        public static string Year = "Year";
        private int m_year;
        /// <summary>
        /// represents the <see cref="year"/> the student took the course. 
        /// </summary>
        public int year
        {
            get { return m_year; }
            set { m_year = value; }
        }

        /// <summary>
        /// represents the <see cref="string"/> "Grade"
        /// </summary>
        public static string Grade = "Grade";
        private LetterGrade m_grade;
        /// <summary>
        /// represents the <see cref="LetterGrade"/> earned
        /// </summary>
        public LetterGrade grade
        {
            get { return m_grade; }
            set { m_grade = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Initializes the <see cref="EnrolledCourseArgs"/> data into the <see cref="EnrolledCourse"/> object 
        /// </summary>
        /// <param name="args"></param>
        public EnrolledCourse(EnrolledCourseArgs args)
        {
            var cArgs = ObjectCache.CourseRootList.FirstOrDefault(c => c.CourseID == args.CourseID);
            if (cArgs == null)
                return;
            info = new Course(cArgs);
            courseID = args.CourseID;
            courseNumber = args.CourseNumber;
            semester = (SemesterType)args.Semester;
            year = args.Year;
            semester = ParseSemester("spring");
        }

        /// <summary>
        /// determines which <see cref="SemesterType"/> base on the semesterName 
        /// </summary>
        /// <param name="semesterName">only valid options: Fall(default), Spring, Summer </param>
        /// <returns>returns SemesterType based on semesterName. defaults to Fall</returns>
        /// <remarks>needs finished</remarks>
        public SemesterType ParseSemester(string semesterName)
        {
            var semesterType = SemesterType.FALL;

            var name = Enum.GetName(typeof(SemesterType), SemesterType.FALL);

            return semesterType;
        }
        #endregion
    }

    #region Enumerations
    /// <summary>
    /// Represents the different types of semesters
    /// </summary>
    public enum SemesterType
    {
        /// <summary>
        /// represents fall semester
        /// </summary>
        [Description("Fall")]
        FALL,
        /// <summary>
        /// represents spring(winter) semester
        /// </summary>
        [Description("Spring")]
        SPRING,
        /// <summary>
        /// represents summer semester
        /// </summary>
        [Description("Summer")]
        SUMMER
    }

    /// <summary>
    /// Represents different grades that can be earned for a course
    /// </summary>
    public enum LetterGrade
    {
        /// <summary>
        /// represents letter grade A
        /// </summary>
        [Description("A")]
        A,
        /// <summary>
        /// represents letter grade B
        /// </summary>
        [Description("B")]
        B,
        /// <summary>
        /// represents letter grade C
        /// </summary>
        [Description("C")]
        C,
        /// <summary>
        /// represents letter grade D
        /// </summary>
        [Description("D")]
        D,
        /// <summary>
        /// represents letter grade F
        /// </summary>
        [Description("F")]
        F,
        /// <summary>
        /// represents incomplete
        /// </summary>
        [Description("Incomplete")]
        I,
        /// <summary>
        /// represents withdrown
        /// </summary>
        [Description("Withdraw")]
        W
    }
    #endregion
}
