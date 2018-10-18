﻿using CM.Payments.Client.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:28
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
    [TestClass, ExcludeFromCodeCoverage]
	public partial class PayPalPaymentResponseTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void PayPalPaymentResponse()
		{
			var obj = new PayPalPaymentResponse
			{
				Amount = 87,
				ChargeId = "Lorum_879",
				CreatedAt = DateTime.Now,
				Currency = "Lorum_169",
				Details = new PayPalDetailsResponse
				{
					Amount = "Lorum_164",
					AuthenticationUrl = "Lorum_288",
					CallbackUrl = "Lorum_758",
					CancelledUrl = "Lorum_439",
					City = "Lorum_139",
					Currency = "Lorum_207",
					Description = "Lorum_33",
					Email = "Lorum_420",
					ExpiredUrl = "Lorum_511",
					FailedUrl = "Lorum_310",
					Firstname = "Lorum_416",
					Lastname = "Lorum_609",
					PurchaseId = "Lorum_914",
					SuccessUrl = "Lorum_258"
				},
				DueDate = DateTime.Now,
				ExpiresAt = DateTime.Now,
				PaymentId = "Lorum_684",
				Recurring = true,
				RecurringId = "Lorum_362",
				ShortPaymentId = "Lorum_194",
				Status = "Lorum_93",
				Test = true,
				UpdatedAt = DateTime.Now
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.ChargeId, deserialized.ChargeId);
			// Check only date and time up to seconds.. Json.NET does not save milliseconds.
			Assert.AreEqual(
				new DateTime(obj.CreatedAt.Year, obj.CreatedAt.Month, obj.CreatedAt.Day, obj.CreatedAt.Hour, obj.CreatedAt.Minute, obj.CreatedAt.Second),
				new DateTime(deserialized.CreatedAt.Year, deserialized.CreatedAt.Month, deserialized.CreatedAt.Day, deserialized.CreatedAt.Hour, deserialized.CreatedAt.Minute, deserialized.CreatedAt.Second));
			Assert.AreEqual(obj.Currency, deserialized.Currency);
			Assert.AreEqual(obj.Details.Amount, deserialized.Details.Amount);
			Assert.AreEqual(obj.Details.AuthenticationUrl, deserialized.Details.AuthenticationUrl);
			Assert.AreEqual(obj.Details.CallbackUrl, deserialized.Details.CallbackUrl);
			Assert.AreEqual(obj.Details.CancelledUrl, deserialized.Details.CancelledUrl);
			Assert.AreEqual(obj.Details.City, deserialized.Details.City);
			Assert.AreEqual(obj.Details.Currency, deserialized.Details.Currency);
			Assert.AreEqual(obj.Details.Description, deserialized.Details.Description);
			Assert.AreEqual(obj.Details.Email, deserialized.Details.Email);
			Assert.AreEqual(obj.Details.ExpiredUrl, deserialized.Details.ExpiredUrl);
			Assert.AreEqual(obj.Details.FailedUrl, deserialized.Details.FailedUrl);
			Assert.AreEqual(obj.Details.Firstname, deserialized.Details.Firstname);
			Assert.AreEqual(obj.Details.Lastname, deserialized.Details.Lastname);
			Assert.AreEqual(obj.Details.PurchaseId, deserialized.Details.PurchaseId);
			Assert.AreEqual(obj.Details.SuccessUrl, deserialized.Details.SuccessUrl);
		    if (obj.DueDate.HasValue && deserialized.DueDate.HasValue)
		    {
		        // Check only date and time up to seconds.. Json.NET does not save milliseconds.
		        Assert.AreEqual(
		            new DateTime(obj.DueDate.Value.Year, obj.DueDate.Value.Month, obj.DueDate.Value.Day, obj.DueDate.Value.Hour, obj.DueDate.Value.Minute, obj.DueDate.Value.Second),
		            new DateTime(deserialized.DueDate.Value.Year, deserialized.DueDate.Value.Month, deserialized.DueDate.Value.Day, deserialized.DueDate.Value.Hour, deserialized.DueDate.Value.Minute, deserialized.DueDate.Value.Second));
		    }
		    if (obj.ExpiresAt.HasValue && deserialized.ExpiresAt.HasValue)
		    {
		        // Check only date and time up to seconds.. Json.NET does not save milliseconds.
		        Assert.AreEqual(
		            new DateTime(obj.ExpiresAt.Value.Year, obj.ExpiresAt.Value.Month, obj.ExpiresAt.Value.Day, obj.ExpiresAt.Value.Hour, obj.ExpiresAt.Value.Minute, obj.ExpiresAt.Value.Second),
		            new DateTime(deserialized.ExpiresAt.Value.Year, deserialized.ExpiresAt.Value.Month, deserialized.ExpiresAt.Value.Day, deserialized.ExpiresAt.Value.Hour, deserialized.ExpiresAt.Value.Minute, deserialized.ExpiresAt.Value.Second));
		    }
            Assert.AreEqual(obj.PaymentId, deserialized.PaymentId);
			Assert.AreEqual(obj.Recurring, deserialized.Recurring);
			Assert.AreEqual(obj.RecurringId, deserialized.RecurringId);
			Assert.AreEqual(obj.ShortPaymentId, deserialized.ShortPaymentId);
			Assert.AreEqual(obj.Status, deserialized.Status);
			Assert.AreEqual(obj.Test, deserialized.Test);
		    if (obj.UpdatedAt.HasValue && deserialized.UpdatedAt.HasValue)
		    {
		        // Check only date and time up to seconds.. Json.NET does not save milliseconds.
		        Assert.AreEqual(
		            new DateTime(obj.UpdatedAt.Value.Year, obj.UpdatedAt.Value.Month, obj.UpdatedAt.Value.Day, obj.UpdatedAt.Value.Hour, obj.UpdatedAt.Value.Minute, obj.UpdatedAt.Value.Second),
		            new DateTime(deserialized.UpdatedAt.Value.Year, deserialized.UpdatedAt.Value.Month, deserialized.UpdatedAt.Value.Day, deserialized.UpdatedAt.Value.Hour, deserialized.UpdatedAt.Value.Minute, deserialized.UpdatedAt.Value.Second));
		    }
        }
	}
}