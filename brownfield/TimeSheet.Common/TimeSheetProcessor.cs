﻿using System;
using System.Collections.Generic;
using System.Linq;
using TimeSheet.Common.Models;

namespace TimeSheet.Common
{
    public class TimeSheetProcessor
    {
        public static int CalculateTimeForCustomer(List<TimeSheetEntryModel> entries, string customerName)
        {
            int sum = 0;

            foreach (var entry in entries)
            {
                // returnerar ett int värde där värdet som kollas finns. Om det inte finns returneras -1
                int customerIndex = entry.WorkDone.IndexOf(customerName, StringComparison.OrdinalIgnoreCase);
                if (customerIndex >= 0)
                {
                    sum += entry.HoursWorked;
                }
            }

            return sum;
        }

        //public static int CalculateTimeWorked(List<TimeSheetEntryModel> entries)
        //{
        //    //int sum = 0;

        //    //foreach (var entry in entries)
        //    //{
        //    //    sum += entry.HoursWorked;
        //    //}

        //    //return sum;
            
        //    //return entries.Sum(x => x.HoursWorked); // LINQ  alternativt mer adnacerat sätt att skriva det
        //}
        public static int CalculateTimeWorked(List<TimeSheetEntryModel> entries) => entries.Sum(x => x.HoursWorked); // Lambda uttryck med LINQ

        public static int CalculateTimeAsLambda (List<TimeSheetEntryModel> e, string c) => 
            e.Where(x => x.WorkDone.ToLower().Contains(c)).
            Sum(x => x.HoursWorked); // LINQ med lambda
    }
}
