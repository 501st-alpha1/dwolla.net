﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This namespace contains LINQ-serializable types for different
/// response types from the Dwolla API.
/// </summary>
namespace dwolla.SerializableTypes
{
    public class DwollaResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Response { get; set; }
    }

    public class MassPayJob
    {
        public string Id { get; set; }
        public string UserJobId { get; set; }
        public bool AssumeCosts { get; set; }
        public string FundingSource { get; set; }
        // TODO: Floats as currency is bad, will change when it's due time.
        public double Total { get; set; }
        public double Fees { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }
        public MassPayItemSummary ItemSummary { get; set; }
    }

    public class MassPayItemSummary
    {
        public int Count { get; set; }
        public int Completed { get; set; }
        public int Successful { get; set; }
    }

    public class FundingSource
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Verified { get; set; }
        public string ProcessingType { get; set; }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public Uri Image { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class UserNearby
    {
        public string Id { get; set; }
        public Uri Image { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Delta { get; set; }
    }
}