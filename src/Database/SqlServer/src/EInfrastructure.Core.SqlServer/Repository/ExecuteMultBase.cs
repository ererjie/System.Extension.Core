// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using EInfrastructure.Core.Config.Entities.Configuration;
using EInfrastructure.Core.Config.Entities.Ioc;

namespace EInfrastructure.Core.SqlServer.Repository
{
    /// <summary>
    /// 执行Sql语句
    /// </summary>
    public class ExecuteBase<TDbContext> : Common.ExecuteBase, IExecute<TDbContext>
        where TDbContext : IDbContext, IUnitOfWork
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="unitOfWork"></param>
        public ExecuteBase(IUnitOfWork<TDbContext> unitOfWork) : base(unitOfWork as IUnitOfWork)
        {
        }
    }
}
