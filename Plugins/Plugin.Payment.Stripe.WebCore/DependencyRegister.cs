using Appli.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Practices.Unity;
//using Microsoft.Practices.Unity.Configuration;

using Repository.Pattern.Repositories;
using Plugin.Payment.Stripe.Data;
using Repository.Pattern.Ef6;
using Plugin.Payment.Services;
using Repository.Pattern.DataContext;
using Repository.Pattern.UnitOfWork;

using Unity.RegistrationByConvention;

using Unity.Mvc5;
using Unity.Injection;
using Unity;

namespace Plugin.Payment.Stripe
{
    public class DependencyRegister : IDependencyRegister
    {
        public void Register(IUnityContainer container)
        {
        //http://stackoverflow.com/questions/4059991/microsoft-unity-how-to-specify-a-certain-parameter-in-constructor

            // async : revoir tout Stripe! enum plus avec le Unity 5 mvc5
            //container.RegisterType<IDataContextAsync, StripeContext>("dataContextStripe",
            //    new PerRequestLifetimeManager());

            //container.RegisterType<IUnitOfWorkAsync, UnitOfWork>("unitOfWorkStripe",
            //    new PerRequestLifetimeManager(),
            //    new InjectionConstructor(
            //        new ResolvedParameter<Repository.Pattern.DataContext.IDataContextAsync>("dataContextStripe")
            //    ));

            //container.RegisterType<IRepositoryAsync<StripeConnect>, Repository<StripeConnect>>(
            //    new InjectionConstructor(
            //        new ResolvedParameter<IDataContextAsync>("dataContextStripe"),
            //        new ResolvedParameter<IUnitOfWorkAsync>("unitOfWorkStripe")
            //    ));

            //container.RegisterType<IRepositoryAsync<StripeTransaction>, Repository<StripeTransaction>>(
            //    new InjectionConstructor(
            //        new ResolvedParameter<IDataContextAsync>("dataContextStripe"),
            //        new ResolvedParameter<IUnitOfWorkAsync>("unitOfWorkStripe")
            //    ));

            container.RegisterType<IStripeConnectService, StripeConnectService>();
            container.RegisterType<IStripeTransactionService, StripeTransactionService>();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
