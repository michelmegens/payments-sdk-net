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
	public partial class CreditcardPaymentResponseTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void CreditcardPaymentResponse()
		{
			var obj = new CreditcardPaymentResponse
			{
				Amount = 61,
				ChargeId = "Lorum_419",
				CreatedAt = DateTime.Now,
				Currency = "Lorum_372",
				Details = new CreditcardDetailsResponse
				{
					AuthenticationUrl = "Lorum_699",
					CallbackUrl = "Lorum_145",
					CancelledUrl = "Lorum_0",
					ExpiredUrl = "Lorum_244",
					FailedUrl = "Lorum_522",
					Issuer = "Lorum_321",
					Issuers = new []
					{
						"Lorum_966",
						"Lorum_240"
					},
					MaskedPan = "Lorum_798",
					PurchaseId = "Lorum_783",
					ReasonForFailure = "Lorum_787",
					Recurring = false,
					SuccessUrl = "Lorum_320"
				},
				DueDate = DateTime.Now,
				ExpiresAt = DateTime.Now,
				PaymentId = "Lorum_465",
				Recurring = true,
				RecurringId = "Lorum_179",
				ShortPaymentId = "Lorum_455",
				Status = "Lorum_394",
				Test = false,
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
			Assert.AreEqual(obj.Details.ExpiredUrl, deserialized.Details.ExpiredUrl);
			Assert.AreEqual(obj.Details.FailedUrl, deserialized.Details.FailedUrl);
			Assert.AreEqual(obj.Details.Issuer, deserialized.Details.Issuer);
			Assert.AreEqual(obj.Details.Issuers.IsFixedSize, deserialized.Details.Issuers.IsFixedSize);
			Assert.AreEqual(obj.Details.Issuers.IsReadOnly, deserialized.Details.Issuers.IsReadOnly);
			Assert.AreEqual(obj.Details.Issuers.IsSynchronized, deserialized.Details.Issuers.IsSynchronized);
			Assert.AreEqual(obj.Details.Issuers.Length, deserialized.Details.Issuers.Length);
			Assert.AreEqual(obj.Details.Issuers.LongLength, deserialized.Details.Issuers.LongLength);
			Assert.AreEqual(obj.Details.Issuers.Rank, deserialized.Details.Issuers.Rank);
			Assert.AreEqual(obj.Details.MaskedPan, deserialized.Details.MaskedPan);
			Assert.AreEqual(obj.Details.PurchaseId, deserialized.Details.PurchaseId);
			Assert.AreEqual(obj.Details.ReasonForFailure, deserialized.Details.ReasonForFailure);
			Assert.AreEqual(obj.Details.Recurring, deserialized.Details.Recurring);
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