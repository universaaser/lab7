using System;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using lab7.Models; // 确保引入了包含 SchoolContext 的命名空间

namespace lab7
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // 设置数据库初始化器
            Database.SetInitializer(new SchoolContextInitializer());
        }
    }

    // 数据库初始化器类
    public class SchoolContextInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            // 这里可以添加种子数据，例如：
            // context.Students.Add(new Student { /* 学生属性 */ });
            // context.SaveChanges();

            base.Seed(context);
        }
    }
}
