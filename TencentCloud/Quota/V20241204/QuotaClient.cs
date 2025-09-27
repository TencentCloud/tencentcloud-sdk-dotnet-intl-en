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

namespace TencentCloud.Quota.V20241204
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Quota.V20241204.Models;

   public class QuotaClient : AbstractClient{

       private const string endpoint = "quota.intl.tencentcloudapi.com";
       private const string version = "2024-12-04";
       private const string sdkVersion = "SDK_NET_3.0.1218";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public QuotaClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public QuotaClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Add alarm rules
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public Task<CreateAlarmResponse> CreateAlarm(CreateAlarmRequest req)
        {
            return InternalRequestAsync<CreateAlarmResponse>(req, "CreateAlarm");
        }

        /// <summary>
        /// Add alarm rules
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public CreateAlarmResponse CreateAlarmSync(CreateAlarmRequest req)
        {
            return InternalRequestAsync<CreateAlarmResponse>(req, "CreateAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes alarm rules
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public Task<DeleteAlarmResponse> DeleteAlarm(DeleteAlarmRequest req)
        {
            return InternalRequestAsync<DeleteAlarmResponse>(req, "DeleteAlarm");
        }

        /// <summary>
        /// Deletes alarm rules
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public DeleteAlarmResponse DeleteAlarmSync(DeleteAlarmRequest req)
        {
            return InternalRequestAsync<DeleteAlarmResponse>(req, "DeleteAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the alarm rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public Task<DescribeAlarmsResponse> DescribeAlarms(DescribeAlarmsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmsResponse>(req, "DescribeAlarms");
        }

        /// <summary>
        /// This API is used to query the alarm rule list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public DescribeAlarmsResponse DescribeAlarmsSync(DescribeAlarmsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmsResponse>(req, "DescribeAlarms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable alarm rules.
        /// </summary>
        /// <param name="req"><see cref="EnableAlarmRequest"/></param>
        /// <returns><see cref="EnableAlarmResponse"/></returns>
        public Task<EnableAlarmResponse> EnableAlarm(EnableAlarmRequest req)
        {
            return InternalRequestAsync<EnableAlarmResponse>(req, "EnableAlarm");
        }

        /// <summary>
        /// This API is used to enable alarm rules.
        /// </summary>
        /// <param name="req"><see cref="EnableAlarmRequest"/></param>
        /// <returns><see cref="EnableAlarmResponse"/></returns>
        public EnableAlarmResponse EnableAlarmSync(EnableAlarmRequest req)
        {
            return InternalRequestAsync<EnableAlarmResponse>(req, "EnableAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modifies alarm rules
        /// </summary>
        /// <param name="req"><see cref="UpdateAlarmRequest"/></param>
        /// <returns><see cref="UpdateAlarmResponse"/></returns>
        public Task<UpdateAlarmResponse> UpdateAlarm(UpdateAlarmRequest req)
        {
            return InternalRequestAsync<UpdateAlarmResponse>(req, "UpdateAlarm");
        }

        /// <summary>
        /// Modifies alarm rules
        /// </summary>
        /// <param name="req"><see cref="UpdateAlarmRequest"/></param>
        /// <returns><see cref="UpdateAlarmResponse"/></returns>
        public UpdateAlarmResponse UpdateAlarmSync(UpdateAlarmRequest req)
        {
            return InternalRequestAsync<UpdateAlarmResponse>(req, "UpdateAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
