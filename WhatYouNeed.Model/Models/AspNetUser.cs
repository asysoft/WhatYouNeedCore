using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appli.Model.Models
{
    public partial class AspNetUser : Repository.Pattern.Ef6.Entity
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new List<AspNetUserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.Listings = new List<Listing>();
            this.Messages = new List<Message>();
            this.MessageParticipants = new List<MessageParticipant>();
            this.MessageReadStates = new List<MessageReadState>();
            this.OrdersProvider = new List<Order>();
            this.OrdersReceiver = new List<Order>();
            this.ListingReviewsUserFrom = new List<ListingReview>();
            this.ListingReviewsUserTo = new List<ListingReview>();
            this.AspNetRoles = new List<AspNetRole>();

            this.AspNetUserCategories = new List<UserCategory>();
            this.AspNetUserImgFiles = new List<UserImgFile>();

            this.UsersAddInfos = new HashSet<UsersAddInfo>();

            this.UserPrepaidCards = new HashSet<UserPrepaidCard>();

            // Valeur parr defaut en base
            UserType =0;
            IsAnnonceurValid = false;
        }

        public string Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public string RegisterIP { get; set; }
        public System.DateTime LastAccessDate {  get; set; }
        public string LastAccessIP { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public bool AcceptEmail { get; set; }
        public string Gender { get; set; }
        public int LeadSourceID { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public bool Disabled { get; set; }
        public double Rating { get; set; }

        // Permet de savoir le type de compte a a creation ( par defaut : normal, sinon Pro)
        [DefaultValue(0)]
        public int UserType { get; set; }

        public bool IsAnnonceurValid { get; set; }
        

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<MessageParticipant> MessageParticipants { get; set; }
        public virtual ICollection<MessageReadState> MessageReadStates { get; set; }
        public virtual ICollection<Order> OrdersProvider { get; set; }
        public virtual ICollection<Order> OrdersReceiver { get; set; }
        public virtual ICollection<ListingReview> ListingReviewsUserFrom { get; set; }
        public virtual ICollection<ListingReview> ListingReviewsUserTo { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }

        // pour les pro : relation avec les categ du pro
        public virtual ICollection<UserCategory> AspNetUserCategories { get; set; }
        public virtual ICollection<UserImgFile> AspNetUserImgFiles { get; set; }

        public virtual ICollection<UsersAddInfo> UsersAddInfos { get; set; }

        // pour creer Many to Many avec des champos customizable en plus dans la table de liaison 
        // On cr�e 2 One to Many et l entity table de liaison avec les champs
        // https://stackoverflow.com/questions/7050404/create-code-first-many-to-many-with-additional-fields-in-association-table
        public virtual ICollection<UserPrepaidCard> UserPrepaidCards { get; set; }


    }
}
