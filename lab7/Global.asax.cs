using System;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using lab7.Models; // ȷ�������˰��� SchoolContext �������ռ�

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

            // �������ݿ��ʼ����
            Database.SetInitializer(new SchoolContextInitializer());
        }
    }

    // ���ݿ��ʼ������
    public class SchoolContextInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            // �����������������ݣ����磺
            // context.Students.Add(new Student { /* ѧ������ */ });
            // context.SaveChanges();

            base.Seed(context);
        }
    }
}
