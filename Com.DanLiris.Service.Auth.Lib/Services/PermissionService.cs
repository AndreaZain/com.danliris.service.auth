﻿using Com.DanLiris.Service.Auth.Lib.Models;
using Com.DanLiris.Service.Auth.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Auth.Lib.Services
{
    public class PermissionService : BasicService<AuthDbContext, Permission>
    {
        public PermissionService(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        public override Tuple<List<Permission>, int, Dictionary<string, string>, List<string>> ReadData(int Page = 1, int Size = 25, string Order = "{}", List<string> Select = null, string Keyword = null)
        {
            throw new NotImplementedException();
        }

        public override void OnCreating(Permission model)
        {
            base.OnCreating(model);
            model._CreatedAgent = "Service";
            model._CreatedBy = this.Username;
        }
        public override void OnUpdating(int id, Permission model)
        {
            base.OnUpdating(id, model);
            model._LastModifiedAgent = "Service";
            model._LastModifiedBy = this.Username;
        }

        public override void OnDeleting(Permission model)
        {
            base.OnDeleting(model);
            model._LastModifiedAgent = "Service";
            model._LastModifiedBy = this.Username;
            model._DeletedAgent = "Service";
            model._DeletedBy = this.Username;
        }
    }
}
