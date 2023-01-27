using Appli.Core.Plugins;
using Appli.Core.Services;
using Appli.Model.Models;
using Appli.Model.StoredProcedures;
using Appli.Service;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
//using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
//using Unity.Mvc5;

namespace WhatYouNeed.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container
        //.RegisterType<IDataContextAsync, AppliContext>(new PerRequestLifetimeManager())
        //.RegisterType<IUnitOfWorkAsync, UnitOfWork>(new PerRequestLifetimeManager())
        .RegisterType<IDataContextAsync, AppliContext>(new HierarchicalLifetimeManager())
    .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new HierarchicalLifetimeManager())


    .RegisterType<IRepositoryAsync<Setting>, Repository<Setting>>()
    .RegisterType<IRepositoryAsync<Category>, Repository<Category>>()
    .RegisterType<IRepositoryAsync<Listing>, Repository<Listing>>()
    .RegisterType<IRepositoryAsync<ListingPicture>, Repository<ListingPicture>>()
    .RegisterType<IRepositoryAsync<Picture>, Repository<Picture>>()
    .RegisterType<IRepositoryAsync<Order>, Repository<Order>>()
    //.RegisterType<IRepositoryAsync<StripeConnect>, Repository<StripeConnect>>()
    .RegisterType<IRepositoryAsync<MetaField>, Repository<MetaField>>()
    .RegisterType<IRepositoryAsync<MetaCategory>, Repository<MetaCategory>>()
    .RegisterType<IRepositoryAsync<ListingMeta>, Repository<ListingMeta>>()
    .RegisterType<IRepositoryAsync<ContentPage>, Repository<ContentPage>>()
    .RegisterType<IRepositoryAsync<SettingDictionary>, Repository<SettingDictionary>>()
    .RegisterType<IRepositoryAsync<ListingStat>, Repository<ListingStat>>()
    .RegisterType<IRepositoryAsync<ListingReview>, Repository<ListingReview>>()
    .RegisterType<IRepositoryAsync<EmailTemplate>, Repository<EmailTemplate>>()
    .RegisterType<IRepositoryAsync<CategoryStat>, Repository<CategoryStat>>()
    .RegisterType<IRepositoryAsync<AspNetUser>, Repository<AspNetUser>>()
    .RegisterType<IRepositoryAsync<AspNetRole>, Repository<AspNetRole>>()

    .RegisterType<IRepositoryAsync<ListingType>, Repository<ListingType>>()
    .RegisterType<IRepositoryAsync<CategoryListingType>, Repository<CategoryListingType>>()
    .RegisterType<IRepositoryAsync<Message>, Repository<Message>>()
    .RegisterType<IRepositoryAsync<MessageParticipant>, Repository<MessageParticipant>>()
    .RegisterType<IRepositoryAsync<MessageReadState>, Repository<MessageReadState>>()
    .RegisterType<IRepositoryAsync<MessageThread>, Repository<MessageThread>>()
    .RegisterType<IRepositoryAsync<LocationRef>, Repository<LocationRef>>()

    .RegisterType<ISettingService, SettingService>()
    .RegisterType<ICategoryService, CategoryService>()
    .RegisterType<ICategoryStatService, CategoryStatService>()
    .RegisterType<IListingService, ListingService>()
    .RegisterType<IListingPictureService, ListingPictureService>()
    .RegisterType<IPictureService, PictureService>()
    .RegisterType<IOrderService, OrderService>()
    .RegisterType<ICustomFieldService, CustomFieldService>()
    .RegisterType<ICustomFieldCategoryService, CustomFieldCategoryService>()
    .RegisterType<ICustomFieldListingService, CustomFieldListingService>()
    .RegisterType<IContentPageService, ContentPageService>()
    .RegisterType<ISettingDictionaryService, SettingDictionaryService>()
    .RegisterType<IListingStatService, ListingStatService>()
    .RegisterType<IEmailTemplateService, EmailTemplateService>()
    .RegisterType<IAspNetUserService, AspNetUserService>()
    .RegisterType<IAspNetRoleService, AspNetRoleService>()
    .RegisterType<IListingTypeService, ListingTypeService>()
    .RegisterType<ILocationRefService, LocationRefService>()
    .RegisterType<IListingReviewService, ListingReviewService>()
    .RegisterType<ICategoryListingTypeService, CategoryListingTypeService>()

    .RegisterType<IRepositoryAsync<UserCategory>, Repository<UserCategory>>()
    .RegisterType<IAspNetUserCategoriesService, AspNetUserCategoriesService>()

    .RegisterType<IRepositoryAsync<UserImgFile>, Repository<UserImgFile>>()
    .RegisterType<IAspNetUserImgFileService, AspNetUserImgFileService>()

    .RegisterType<IRepositoryAsync<PrepaidCard>, Repository<PrepaidCard>>()
    .RegisterType<IPrepaidCardService, PrepaidCardService>()

    .RegisterType<IRepositoryAsync<UsersAddInfo>, Repository<UsersAddInfo>>()
    .RegisterType<IUsersAddInfoService, UsersAddInfoService>()

    .RegisterType<IRepositoryAsync<UserPrepaidCard>, Repository<UserPrepaidCard>>()
    .RegisterType<IUserPrepaidCardService, UserPrepaidCardService>()

    //  PubLocationsService : Service<PubLocations>, IPubLocationsService
    .RegisterType<IRepositoryAsync<PubLocations>, Repository<PubLocations>>()
    .RegisterType<IPubLocationsService, PubLocationsService>()

    .RegisterType<IMessageService, MessageService>()
    .RegisterType<IMessageParticipantService, MessageParticipantService>()
    .RegisterType<IMessageReadStateService, MessageReadStateService>()
    .RegisterType<IMessageThreadService, MessageThreadService>()

    //    .RegisterType<IStoredProcedures, AppliContext>(new PerRequestLifetimeManager())
    .RegisterType<IStoredProcedures, AppliContext>(new HierarchicalLifetimeManager())

    .RegisterType<SqlDbService, SqlDbService>()
    .RegisterType<DataCacheService, DataCacheService>(new ContainerControlledLifetimeManager());

            container
                .RegisterType<IHookService, HookService>()
                .RegisterType<IPluginFinder, PluginFinder>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
        //     public static void RegisterComponents()
        //     {
        //var container = new UnityContainer();

        //         // register all your components with the container here
        //         // it is NOT necessary to register your controllers

        //         // e.g. container.RegisterType<ITestService, TestService>();

        //         DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        //     }
    }
}