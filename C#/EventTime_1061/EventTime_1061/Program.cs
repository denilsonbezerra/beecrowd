using System;

class URI {

    static bool CheckUncompleteDay(int startHour, int startMinutes, int startSeconds, int endHour, int endMinutes, int endSeconds) {

        if (endHour < startHour || (endHour == startHour && endMinutes < startMinutes) || (endHour == startHour && endMinutes == startMinutes && endSeconds < startSeconds)) return true;
        else return false;

    }

    static bool CheckUncompleteHours(int startMinutes, int startSeconds, int endMinutes, int endSeconds) {

        if (endMinutes < startMinutes || (endMinutes == startMinutes && endSeconds < startSeconds)) return true;
        else return false;

    }

    static bool CheckUncompleteMinutes(int startSeconds, int endSeconds) {

        if (endSeconds < startSeconds) return true;
        else return false;

    }

    static void Main(string[] args) {

        string[] inputStartDay = Console.ReadLine().Split();
        int startDay = int.Parse(inputStartDay[1]);

        string[] inputStartTime = Console.ReadLine().Split(':');
        int startHour = int.Parse(inputStartTime[0]), startMinutes = int.Parse(inputStartTime[1]), startSeconds = int.Parse(inputStartTime[2]);

        string[] inputEndDay = Console.ReadLine().Split();
        int endDay = int.Parse(inputEndDay[1]);

        string[] inputEndTime = Console.ReadLine().Split(':');
        int endHour = int.Parse(inputEndTime[0]), endMinutes = int.Parse(inputEndTime[1]), endSeconds = int.Parse(inputEndTime[2]);

        int eventDays = endDay - startDay;

        int eventHours, eventMinutes, eventSeconds;

        if (endHour == startHour && endMinutes > startMinutes) {
            eventHours = 0;
        } else if (CheckUncompleteDay(startHour, startMinutes, startSeconds, endHour, endMinutes, endSeconds)) {
            eventHours = Math.Abs(startHour - (endHour + 24));
            eventDays--;
        } else {
            eventHours = endHour - startHour;
        }

        if (CheckUncompleteHours(startMinutes, startSeconds, endMinutes, endSeconds)) {
            eventMinutes = Math.Abs(startMinutes - (endMinutes + 60));
            eventHours--;
        } else {
            eventMinutes = endMinutes - startMinutes;
        }

        if (CheckUncompleteMinutes(startSeconds, endSeconds)) {
            eventSeconds = Math.Abs(startSeconds - (endSeconds + 60));
            eventMinutes--;
        } else {
            eventSeconds = endSeconds - startSeconds;
        }

        Console.WriteLine(
            $"{eventDays} dia(s)\n" +
            $"{eventHours} hora(s)\n" +
            $"{eventMinutes} minuto(s)\n" +
            $"{eventSeconds} segundo(s)");

    }

}