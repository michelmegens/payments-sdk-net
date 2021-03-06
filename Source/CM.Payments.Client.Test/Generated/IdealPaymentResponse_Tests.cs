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
	public partial class IdealPaymentResponseTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void IdealPaymentResponse()
		{
			var obj = new IdealPaymentResponse
			{
				Amount = 97,
				ChargeId = "Lorum_515",
				CreatedAt = DateTime.Now,
				Currency = "Lorum_708",
				Details = new IdealDetailsResponse
				{
					AuthenticationUrl = "Lorum_783",
					CallbackUrl = "Lorum_813",
					CancelledUrl = "Lorum_29",
					Description = "Lorum_390",
					ExpiredUrl = "Lorum_371",
					FailedUrl = "Lorum_60",
					IssuerId = "Lorum_178",
					PaidByAscript = "Lorum_570",
					PaidByBic = "Lorum_317",
					PaidByIban = "Lorum_336",
					PurchaseId = "Lorum_328",
					SuccessUrl = "Lorum_277"
				},
				DueDate = DateTime.Now,
				ExpiresAt = DateTime.Now,
				PaymentId = "Lorum_753",
				Recurring = false,
				RecurringId = "Lorum_806",
				ShortPaymentId = "Lorum_972",
				Status = "Lorum_182",
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
			Assert.AreEqual(obj.Details.AuthenticationUrl, deserialized.Details.AuthenticationUrl);
			Assert.AreEqual(obj.Details.CallbackUrl, deserialized.Details.CallbackUrl);
			Assert.AreEqual(obj.Details.CancelledUrl, deserialized.Details.CancelledUrl);
			Assert.AreEqual(obj.Details.Description, deserialized.Details.Description);
			Assert.AreEqual(obj.Details.ExpiredUrl, deserialized.Details.ExpiredUrl);
			Assert.AreEqual(obj.Details.FailedUrl, deserialized.Details.FailedUrl);
			Assert.AreEqual(obj.Details.IssuerId, deserialized.Details.IssuerId);
			Assert.AreEqual(obj.Details.PaidByAscript, deserialized.Details.PaidByAscript);
			Assert.AreEqual(obj.Details.PaidByBic, deserialized.Details.PaidByBic);
			Assert.AreEqual(obj.Details.PaidByIban, deserialized.Details.PaidByIban);
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