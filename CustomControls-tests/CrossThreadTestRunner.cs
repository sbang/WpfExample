// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CrossThreadTestRunner.cs" company="Steria AS">
//   Copyright Steria 2013
// </copyright>
// <summary>
//   Defines the CrossThreadTestRunner type, used to create WPF controls in unit tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CustomControls
{
    using System;
    using System.Reflection;
    using System.Security.Permissions;
    using System.Threading;

    public class CrossThreadTestRunner
    {
        private Exception lastException;

        public void RunInMTA(ThreadStart userDelegate)
        {
            Run(userDelegate, ApartmentState.MTA);
        }

        public void RunInSTA(ThreadStart userDelegate)
        {
            Run(userDelegate, ApartmentState.STA);
        }

        [ReflectionPermission(SecurityAction.Demand)]
        private static void ThrowExceptionPreservingStack(Exception exception)
        {
            FieldInfo remoteStackTraceString = typeof(Exception).GetField(
              "_remoteStackTraceString",
              BindingFlags.Instance | BindingFlags.NonPublic);
            if (remoteStackTraceString != null)
            {
                remoteStackTraceString.SetValue(exception, exception.StackTrace + Environment.NewLine);
            }

            throw exception;
        }

        private void Run(ThreadStart userDelegate, ApartmentState apartmentState)
        {
            lastException = null;

            var thread = new Thread(
              delegate()
              {
                  try
                  {
                      userDelegate.Invoke();
                  }
                  catch (Exception e)
                  {
                      lastException = e;
                  }
              });
            thread.SetApartmentState(apartmentState);

            thread.Start();
            thread.Join();

            if (ExceptionWasThrown())
            {
                ThrowExceptionPreservingStack(lastException);
            }
        }

        private bool ExceptionWasThrown()
        {
            return lastException != null;
        }
    }
}