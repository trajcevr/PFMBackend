using PFMBackend.Data;
using System;
using System.Linq;
using PFMBackend.Models;
using PFMBackend.Data.Entities;

using var db = new PFMDbContex();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new Transaction");
db.Add(new Transaction
{
    id = "123",
    beneficiary_name = "blabla",
    date = "11.01.2022" ,
    direction = TransactionDirection.c,
    amount = 0,
    description = "blabla",
    currency = "USD",
    mcc = "asf",
    kind = TransactionKind.inc
});

Console.WriteLine("Inserting a new Category");
db.Add(new Category
{
    code = "123" , 
    parent_code = "123" , 
    name = "blabla"
});

db.SaveChanges();

