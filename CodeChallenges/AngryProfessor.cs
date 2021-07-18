using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    // A Discrete Mathematics professor has a class of students.Frustrated with their lack of discipline,
    // the professor decides to cancel class if fewer than some number of students are present when class
    // starts. Arrival times go from on time(arrival <= 0) to arrived late(arrival > 0).

    // Given the arrival time of each student and a threshhold number of attendees, determine if the class is cancelled.

    class AngryProfessor
    {
        public static string angryProfessor(int attendanceThreshold, List<int> arrivalTimes)
        {
            int onTimeStudents = 0;
            foreach (var arrival in arrivalTimes)
                if (arrival >= 0) onTimeStudents++;

            return onTimeStudents >= attendanceThreshold ? "NO" : "YES";
        }
    }
}
