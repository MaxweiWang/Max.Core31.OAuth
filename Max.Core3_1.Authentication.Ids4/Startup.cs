using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Max.Core3_1.Authentication.Ids4.DataInit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Max.Core3_1.Authentication.Ids4
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();
            services.AddControllersWithViews();

            #region �ͻ���
            //services.AddIdentityServer()//��ô����
            //  .AddDeveloperSigningCredential()//Ĭ�ϵĿ�����֤��--��ʱ֤��--��������Ϊ�˱�֤token��ʧЧ��֤���ǲ����
            //  .AddInMemoryClients(ClientInitConfig.GetClients())//InMemory �ڴ�ģʽ
            //  .AddInMemoryApiResources(ClientInitConfig.GetApiResources());//�ܷ���ɶ��Դ
            #endregion

            #region ����ģʽ
            //services.AddIdentityServer()
            //    .AddDeveloperSigningCredential()//Ĭ�ϵĿ�����֤�� 
            //   .AddInMemoryApiResources(PasswordInitConfig.GetApiResources())//API������Ȩ��Դ
            //   .AddInMemoryClients(PasswordInitConfig.GetClients())  //�ͻ���
            //   .AddTestUsers(PasswordInitConfig.GetUsers());//����û�
            #endregion

            #region ����ģʽ
            //services.AddIdentityServer()
            //    .AddDeveloperSigningCredential()//Ĭ�ϵĿ�����֤�� 
            //   .AddInMemoryApiResources(ImplicitInitConfig.GetApiResources()) //API������Ȩ��Դ
            //   .AddInMemoryClients(ImplicitInitConfig.GetClients())//�ͻ���
            //   .AddTestUsers(ImplicitInitConfig.GetUsers()); //����û�
            #endregion

            #region Codeģʽ
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()//Ĭ�ϵĿ�����֤�� 
               .AddInMemoryApiResources(CodeInitConfig.GetApiResources()) //API������Ȩ��Դ
               .AddInMemoryClients(CodeInitConfig.GetClients())//�ͻ���
               .AddTestUsers(CodeInitConfig.GetUsers()); //����û�
            #endregion

            #region Hybridģʽ
            //services.AddIdentityServer()
            //    .AddDeveloperSigningCredential()//Ĭ�ϵĿ�����֤�� 
            //    .AddInMemoryIdentityResources(HybridInitConfig.GetIdentityResources())//�����Ϣ��Ȩ��Դ
            //   .AddInMemoryApiResources(HybridInitConfig.GetApiResources()) //API������Ȩ��Դ
            //   .AddInMemoryClients(HybridInitConfig.GetClients())//�ͻ���
            //   .AddTestUsers(HybridInitConfig.GetUsers()); //����û�
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            //����wwwrootĿ¼��̬�ļ�
            app.UseStaticFiles(
                new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot"))
                });

            #region ���IdentityServer�м��
            app.UseIdentityServer();//���ز�������
            #endregion

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
