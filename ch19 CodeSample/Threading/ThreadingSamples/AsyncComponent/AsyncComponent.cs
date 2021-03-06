﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Wrox.ProCSharp.Threading
{
   public delegate void LongTaskCompletedEventHandler(object sender, LongTaskCompletedEventArgs e);

   public partial class AsyncComponent : Component
   {
      private Dictionary<object, AsyncOperation> userStateDictionary = new Dictionary<object, AsyncOperation>();
      private SendOrPostCallback onCompletedDelegate;

      public event LongTaskCompletedEventHandler LongTaskCompleted;


      public AsyncComponent()
      {
         InitializeComponent();
         InitializeDelegates();
      }

      private void InitializeDelegates()
      {
         onCompletedDelegate = LongTaskCompletion;
      }

      private void LongTaskCompletion(object operationState)
      {
         LongTaskCompletedEventArgs e = operationState as LongTaskCompletedEventArgs;

         OnLongTaskCompleted(e);
         
      }

      protected void OnLongTaskCompleted(LongTaskCompletedEventArgs e)
      {
         if (LongTaskCompleted != null)
         {
            LongTaskCompleted(this, e);
         }
      }


      public AsyncComponent(IContainer container)
      {
         container.Add(this);

         InitializeComponent();
      }

      public string LongTask(string input)
      {
         Console.WriteLine("LongTask started");
         Thread.Sleep(5000);
         Console.WriteLine("LongTask finished");
         return input.ToUpper();
      }

      public void LongTaskAsync(string input, object taskId)
      {
         AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(taskId);

         lock (userStateDictionary)
         {
            if (userStateDictionary.ContainsKey(taskId))
               throw new ArgumentException("taskId must be unique", "taskId");


            userStateDictionary[taskId] = asyncOp;
         }

         LongTaskWorkHandler someLongTaskDelegate = DoLongTask;
         someLongTaskDelegate.BeginInvoke(input, asyncOp, null, null);

      }

      private delegate void LongTaskWorkHandler(string input, AsyncOperation asyncOp);



      // running in a background thread
      private void DoLongTask(string input, AsyncOperation asyncOp)
      {
         Exception e = null;
         string output = null;
         try
         {
            output = LongTask(input);
         }
         catch (Exception ex)
         {
            e = ex;
         }

         this.CompletionMethod(output, e, false, asyncOp);
      }

      private void CompletionMethod(string output, Exception ex, bool cancelled, AsyncOperation asyncOp)
      {
         lock (userStateDictionary)
         {
            userStateDictionary.Remove(asyncOp.UserSuppliedState);
         }

         // results of the operation
         LongTaskCompletedEventArgs e = new LongTaskCompletedEventArgs(output, ex, cancelled, asyncOp.UserSuppliedState);

         asyncOp.PostOperationCompleted(onCompletedDelegate, e);

      }
   }

   public class LongTaskCompletedEventArgs : AsyncCompletedEventArgs
   {
      public LongTaskCompletedEventArgs(string output, Exception e, bool cancelled, object state)
         : base(e, cancelled, state)
      {
         this.output = output;
      }

      private string output;

      public string Output
      {
         get
         {
            RaiseExceptionIfNecessary();

            return output;
         }
      }
   }
}
