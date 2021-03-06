﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bit.Core;
using Bit.Core.Enums;
using Bit.Core.Models.Data;
using Bit.Core.Models.Table;
using Bit.Core.Utilities;

namespace Bit.Admin.Models
{
    public class OrganizationEditModel : OrganizationViewModel
    {
        public OrganizationEditModel() { }

        public OrganizationEditModel(Organization org, IEnumerable<OrganizationUserUserDetails> orgUsers,
            GlobalSettings globalSettings)
            : base(org, orgUsers)
        {
            BraintreeMerchantId = globalSettings.Braintree.MerchantId;

            Name = org.Name;
            BusinessName = org.BusinessName;
            BusinessAddress1 = org.BusinessAddress1;
            BusinessAddress2 = org.BusinessAddress2;
            BusinessAddress3 = org.BusinessAddress3;
            BusinessCountry = org.BusinessCountry;
            BusinessTaxNumber = org.BusinessTaxNumber;
            BillingEmail = org.BillingEmail;
            PlanType = org.PlanType;
            Plan = org.Plan;
            Seats = org.Seats;
            MaxCollections = org.MaxCollections;
            UseGroups = org.UseGroups;
            UseDirectory = org.UseDirectory;
            UseEvents = org.UseEvents;
            UseTotp = org.UseTotp;
            SelfHost = org.SelfHost;
            UsersGetPremium = org.UsersGetPremium;
            MaxStorageGb = org.MaxStorageGb;
            Gateway = org.Gateway;
            GatewayCustomerId = org.GatewayCustomerId;
            GatewaySubscriptionId = org.GatewaySubscriptionId;
            Enabled = org.Enabled;
            LicenseKey = org.LicenseKey;
            ExpirationDate = org.ExpirationDate;
        }

        public string RandomLicenseKey => CoreHelpers.SecureRandomString(20);
        public string FourteenDayExpirationDate => DateTime.Now.AddDays(14).ToString("yyyy-MM-ddTHH:mm");
        public string BraintreeMerchantId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        [Display(Name = "Business Address 1")]
        public string BusinessAddress1 { get; set; }
        [Display(Name = "Business Address 2")]
        public string BusinessAddress2 { get; set; }
        [Display(Name = "Business Address 3")]
        public string BusinessAddress3 { get; set; }
        [Display(Name = "Business Country")]
        public string BusinessCountry { get; set; }
        [Display(Name = "Business Tax Number")]
        public string BusinessTaxNumber { get; set; }
        [Display(Name = "Billing Email")]
        public string BillingEmail { get; set; }
        [Required]
        [Display(Name = "Plan")]
        public PlanType? PlanType { get; set; }
        [Required]
        [Display(Name = "Plan Name")]
        public string Plan { get; set; }
        [Display(Name = "Seats")]
        public short? Seats { get; set; }
        [Display(Name = "Max. Collections")]
        public short? MaxCollections { get; set; }
        [Display(Name = "Groups")]
        public bool UseGroups { get; set; }
        [Display(Name = "Directory")]
        public bool UseDirectory { get; set; }
        [Display(Name = "Events")]
        public bool UseEvents { get; set; }
        [Display(Name = "TOTP")]
        public bool UseTotp { get; set; }
        [Display(Name = "Self Host")]
        public bool SelfHost { get; set; }
        [Display(Name = "Users Get Premium")]
        public bool UsersGetPremium { get; set; }
        [Display(Name = "Max. Storage GB")]
        public short? MaxStorageGb { get; set; }
        [Display(Name = "Gateway")]
        public GatewayType? Gateway { get; set; }
        [Display(Name = "Gateway Customer Id")]
        public string GatewayCustomerId { get; set; }
        [Display(Name = "Gateway Subscription Id")]
        public string GatewaySubscriptionId { get; set; }
        [Display(Name = "Enabled")]
        public bool Enabled { get; set; }
        [Display(Name = "License Key")]
        public string LicenseKey { get; set; }
        [Display(Name = "Expiration Date")]
        public DateTime? ExpirationDate { get; set; }

        public Organization ToOrganization(Organization existingOrganization)
        {
            existingOrganization.Name = Name;
            existingOrganization.BusinessName = BusinessName;
            existingOrganization.BusinessAddress1 = BusinessAddress1;
            existingOrganization.BusinessAddress2 = BusinessAddress2;
            existingOrganization.BusinessAddress3 = BusinessAddress3;
            existingOrganization.BusinessCountry = BusinessCountry;
            existingOrganization.BusinessTaxNumber = BusinessTaxNumber;
            existingOrganization.BillingEmail = BillingEmail;
            existingOrganization.PlanType = PlanType.Value;
            existingOrganization.Plan = Plan;
            existingOrganization.Seats = Seats;
            existingOrganization.MaxCollections = MaxCollections;
            existingOrganization.UseGroups = UseGroups;
            existingOrganization.UseDirectory = UseDirectory;
            existingOrganization.UseEvents = UseEvents;
            existingOrganization.UseTotp = UseTotp;
            existingOrganization.SelfHost = SelfHost;
            existingOrganization.UsersGetPremium = UsersGetPremium;
            existingOrganization.MaxStorageGb = MaxStorageGb;
            existingOrganization.Gateway = Gateway;
            existingOrganization.GatewayCustomerId = GatewayCustomerId;
            existingOrganization.GatewaySubscriptionId = GatewaySubscriptionId;
            existingOrganization.Enabled = Enabled;
            existingOrganization.LicenseKey = LicenseKey;
            existingOrganization.ExpirationDate = ExpirationDate;
            return existingOrganization;
        }
    }
}
