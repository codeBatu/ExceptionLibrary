using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.ExceptionLibrary.Repository;
using Util.ExceptionLibrary.Service;

namespace Util.ExceptionLibrary
{
    public class DatabaseUtil
    {
        #region Exception Repository
        public static R SubcsribeRepository<R>( Func<R> func,string message)
        {
            try
            {
                return func();
            }
            catch (Exception exp)
            {
                throw new RepositoryException(message, exp.InnerException);
               
            }
        }
        public static async Task <R> SubcsribeRepositoryAsync<R>(Func<Task<R>> funcs, string message)
        {
            try
            {
                return await funcs();
            }
            catch (Exception exp)
            {
                throw new RepositoryException(message, exp.InnerException);

            }
        }
        public static void SubscribeRepository<R>(Action action, string message)
        {
            try
            {
                action();
            }
            catch (Exception exp)
            {

                throw new RepositoryException(message,exp.InnerException) ;
            }
        }
       
        public static async Task SubscribeRepositoryAsync(Func<Task<Action>> action, string message)
        {
            try
            {
               await action();
            }
            catch (Exception exp)
            {

                throw new RepositoryException(message, exp.InnerException);
            }
        }
        #endregion
        #region Exception Service
        public static R SubcsribeSerivce<R>(Func<R> func, string message)
        {
            try
            {
                return func();
            }
            catch (RepositoryException exp)
            {

                throw new DataServiceException(message, exp.InnerException);
            }
            catch (Exception exp)
            {
                throw new DataServiceException(message, exp.InnerException);
            }
        }
        public static async Task<R> SubcsribeSerivceAsync<R>(Func<Task<R>> funcs, string message)
        {
            try
            {
                return await funcs();
            }
            catch (RepositoryException exp)
            {

                throw new DataServiceException(message, exp.InnerException);
            }
            catch (Exception exp)
            {
                throw new DataServiceException(message, exp.InnerException);
            }
        }
        public static void SubscribeService(Action action, string message)
        {
            try
            {
                action();
            }
            catch (RepositoryException exp)
            {

                throw new DataServiceException(message, exp.InnerException);
            }
            catch(Exception exp)
            {
                throw new DataServiceException(message, exp.InnerException);
            }
        }
        public static async Task SubscribeServiceAsync(Func<Task<Action>> action, string message)
        {
            try
            {
               await action();
            }
            catch (RepositoryException exp)
            {

                throw new DataServiceException(message, exp.InnerException);
            }
            catch (Exception exp)
            {
                throw new DataServiceException(message, exp.InnerException);
            }
        }
        #endregion
    }
}
