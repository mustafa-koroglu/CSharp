﻿using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManagar
{
    Course[] courses = new Course[3];
    //constructor
    public CourseManagar()
    {

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8 VS...";

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "JAVA 17";

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12";

        Console.WriteLine("başladı");
        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll()
    {
        return courses;

    }
}