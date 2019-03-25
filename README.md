# quartz-scheduler.net

Quartz is a richly featured, open source job scheduling library that can be 
integrated within virtually any .net application.

Create JobScheduler class.

```bash
// get a scheduler, start the schedular before triggers or anything else
IScheduler sched = await schedFact.GetScheduler();
sched.Start();

IJobDetail job = JobBuilder.Create<JobScheduler>().Build();

//Build a trigger that will fire daily at 10:42 am:
ITrigger trigger = TriggerBuilder.Create()
.WithIdentity("trigger1", "group1")
.StartNow()
.WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(11, 25))
.Build();

# call  Execute
async  System.Threading.Tasks.Task IJob.Execute(IJobExecutionContext context)
{
  var result = await DeleteAllFile(System.Web.Hosting.HostingEnvironment.MapPath("/PdfFiles/"));
}

# call JobScheduler in  Application_Start of  Global.asax.cs
JobScheduler.Start();
```
