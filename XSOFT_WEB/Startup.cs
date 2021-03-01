﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Repositories.Contracts;
using Repositories.Implementations;
using Newtonsoft.Json.Serialization;

using Services.Contracts;
using Services;
using Services.Implementations;
using Models.Data;
using Microsoft.EntityFrameworkCore;

namespace XSOFT_WEB
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
            services.AddDbContext<XSoftContext>(options =>
       options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors(o => o.AddPolicy("MyAllowSpecificOrigins", builder =>
            {
                builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithOrigins("*");
            }));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc()
             .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "My API", Version = "v1" });
            });
            #region repo
       //     services.AddScoped<IArticleGeneriqueRepository, ArticleGeneriqueRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IFournisseurRepository, FournisseurRepository>();
            services.AddScoped<IFamilleTierRepository, FamilleTierRepository>();
            services.AddScoped<ICategorieTarifRepository, CategorieTarifRepository>();
            services.AddScoped<IDeviseRepository, DeviseRepository>();
            services.AddScoped<ICollaborateurRepository, CollaborateurRepository>();
            services.AddScoped<IModalitePaiementRepository, ModalitePaiementRepository>();
            services.AddScoped<IIncotermRepository, IncotermRepository>();
           services.AddScoped<IParametresRepository, ParametresRepository>();
            services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IEProtectionRepository, EProtectionRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IFamille0Repository, Famille0Repository>();
            services.AddScoped<IFamilleRepository, FamilleRepository>();
            services.AddScoped<ITaxeRepository,TaxeRepository>();
            services.AddScoped<IUniteRepository, UniteRepository>();
            services.AddScoped<IDimensionRepository, DimensionRepository>();
            services.AddScoped<IDetailDimensionRepository, DetailDimensionRepository>();

            #endregion

            #region services
            services.AddScoped<ICollaborateurService, CollaborateurServices>();
            services.AddScoped<IDeviseService, DeviseServices>();
            services.AddScoped<IFamilleTierService, FamilleTierServices>();
            services.AddScoped<ICategorieTarifService, CategorieTarifServices>();
            services.AddScoped<IModalitePaiementService, ModalitePaiementServices>();
            services.AddScoped<IIncotermService, IncotermServices>();
            
            services.AddScoped<IClientService,ClientServices>();
            services.AddScoped<IFournisseurService, FournisseurServices>();
            services.AddScoped<IContactService, ContactServices>();
            services.AddScoped<IUtilisateurService, UtilisateurServices>();
            services.AddScoped<IParametresService, ParametresServices>();
            services.AddScoped<IEProtectionService, EProtectionServices>();
            services.AddScoped<ITagService, TagServices>();
            services.AddScoped<IFamille0Service, Famille0Services>();
            services.AddScoped<IFamilleService, FamilleServices>();
            services.AddScoped<IUniteService, UniteServices>();
            services.AddScoped<ITaxeService, TaxeServices>();
            services.AddScoped<IDimensionService, DimensionServices>();
            services.AddScoped<IDetailDimensionService, DetailDimensionServices>();
            #endregion


            //services.AddCors(allowsites =>
            //{
            //    allowsites.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            //});


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("MyAllowSpecificOrigins");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
           
        }
    }
}
