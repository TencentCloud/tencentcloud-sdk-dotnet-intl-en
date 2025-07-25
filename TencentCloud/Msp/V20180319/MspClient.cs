/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Msp.V20180319
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Msp.V20180319.Models;

   public class MspClient : AbstractClient{

       private const string endpoint = "msp.intl.tencentcloudapi.com";
       private const string version = "2018-03-19";
       private const string sdkVersion = "SDK_NET_3.0.1164";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MspClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MspClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to cancel the registered migration tasks.
        /// </summary>
        /// <param name="req"><see cref="DeregisterMigrationTaskRequest"/></param>
        /// <returns><see cref="DeregisterMigrationTaskResponse"/></returns>
        public Task<DeregisterMigrationTaskResponse> DeregisterMigrationTask(DeregisterMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeregisterMigrationTaskResponse>(req, "DeregisterMigrationTask");
        }

        /// <summary>
        /// This API is used to cancel the registered migration tasks.
        /// </summary>
        /// <param name="req"><see cref="DeregisterMigrationTaskRequest"/></param>
        /// <returns><see cref="DeregisterMigrationTaskResponse"/></returns>
        public DeregisterMigrationTaskResponse DeregisterMigrationTaskSync(DeregisterMigrationTaskRequest req)
        {
            return InternalRequestAsync<DeregisterMigrationTaskResponse>(req, "DeregisterMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the specified migration task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTaskRequest"/></param>
        /// <returns><see cref="DescribeMigrationTaskResponse"/></returns>
        public Task<DescribeMigrationTaskResponse> DescribeMigrationTask(DescribeMigrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTaskResponse>(req, "DescribeMigrationTask");
        }

        /// <summary>
        /// This API is used to obtain the specified migration task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationTaskRequest"/></param>
        /// <returns><see cref="DescribeMigrationTaskResponse"/></returns>
        public DescribeMigrationTaskResponse DescribeMigrationTaskSync(DescribeMigrationTaskRequest req)
        {
            return InternalRequestAsync<DescribeMigrationTaskResponse>(req, "DescribeMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of migration project names.
        /// </summary>
        /// <param name="req"><see cref="ListMigrationProjectRequest"/></param>
        /// <returns><see cref="ListMigrationProjectResponse"/></returns>
        public Task<ListMigrationProjectResponse> ListMigrationProject(ListMigrationProjectRequest req)
        {
            return InternalRequestAsync<ListMigrationProjectResponse>(req, "ListMigrationProject");
        }

        /// <summary>
        /// This API is used to obtain the list of migration project names.
        /// </summary>
        /// <param name="req"><see cref="ListMigrationProjectRequest"/></param>
        /// <returns><see cref="ListMigrationProjectResponse"/></returns>
        public ListMigrationProjectResponse ListMigrationProjectSync(ListMigrationProjectRequest req)
        {
            return InternalRequestAsync<ListMigrationProjectResponse>(req, "ListMigrationProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain migration task list.
        /// </summary>
        /// <param name="req"><see cref="ListMigrationTaskRequest"/></param>
        /// <returns><see cref="ListMigrationTaskResponse"/></returns>
        public Task<ListMigrationTaskResponse> ListMigrationTask(ListMigrationTaskRequest req)
        {
            return InternalRequestAsync<ListMigrationTaskResponse>(req, "ListMigrationTask");
        }

        /// <summary>
        /// This API is used to obtain migration task list.
        /// </summary>
        /// <param name="req"><see cref="ListMigrationTaskRequest"/></param>
        /// <returns><see cref="ListMigrationTaskResponse"/></returns>
        public ListMigrationTaskResponse ListMigrationTaskSync(ListMigrationTaskRequest req)
        {
            return InternalRequestAsync<ListMigrationTaskResponse>(req, "ListMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the project of a migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationTaskBelongToProjectRequest"/></param>
        /// <returns><see cref="ModifyMigrationTaskBelongToProjectResponse"/></returns>
        public Task<ModifyMigrationTaskBelongToProjectResponse> ModifyMigrationTaskBelongToProject(ModifyMigrationTaskBelongToProjectRequest req)
        {
            return InternalRequestAsync<ModifyMigrationTaskBelongToProjectResponse>(req, "ModifyMigrationTaskBelongToProject");
        }

        /// <summary>
        /// This API is used to modify the project of a migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationTaskBelongToProjectRequest"/></param>
        /// <returns><see cref="ModifyMigrationTaskBelongToProjectResponse"/></returns>
        public ModifyMigrationTaskBelongToProjectResponse ModifyMigrationTaskBelongToProjectSync(ModifyMigrationTaskBelongToProjectRequest req)
        {
            return InternalRequestAsync<ModifyMigrationTaskBelongToProjectResponse>(req, "ModifyMigrationTaskBelongToProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the migration task status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyMigrationTaskStatusResponse"/></returns>
        public Task<ModifyMigrationTaskStatusResponse> ModifyMigrationTaskStatus(ModifyMigrationTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyMigrationTaskStatusResponse>(req, "ModifyMigrationTaskStatus");
        }

        /// <summary>
        /// This API is used to update the migration task status.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyMigrationTaskStatusResponse"/></returns>
        public ModifyMigrationTaskStatusResponse ModifyMigrationTaskStatusSync(ModifyMigrationTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyMigrationTaskStatusResponse>(req, "ModifyMigrationTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register a migration task.
        /// </summary>
        /// <param name="req"><see cref="RegisterMigrationTaskRequest"/></param>
        /// <returns><see cref="RegisterMigrationTaskResponse"/></returns>
        public Task<RegisterMigrationTaskResponse> RegisterMigrationTask(RegisterMigrationTaskRequest req)
        {
            return InternalRequestAsync<RegisterMigrationTaskResponse>(req, "RegisterMigrationTask");
        }

        /// <summary>
        /// This API is used to register a migration task.
        /// </summary>
        /// <param name="req"><see cref="RegisterMigrationTaskRequest"/></param>
        /// <returns><see cref="RegisterMigrationTaskResponse"/></returns>
        public RegisterMigrationTaskResponse RegisterMigrationTaskSync(RegisterMigrationTaskRequest req)
        {
            return InternalRequestAsync<RegisterMigrationTaskResponse>(req, "RegisterMigrationTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
