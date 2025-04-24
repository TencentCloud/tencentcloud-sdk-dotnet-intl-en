/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dms.V20200819
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dms.V20200819.Models;

   public class DmsClient : AbstractClient{

       private const string endpoint = "dms.intl.tencentcloudapi.com";
       private const string version = "2020-08-19";
       private const string sdkVersion = "SDK_NET_3.0.1117";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to send regular emails.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public Task<SendEmailResponse> SendEmail(SendEmailRequest req)
        {
            return InternalRequestAsync<SendEmailResponse>(req, "SendEmail");
        }

        /// <summary>
        /// This API is used to send regular emails.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public SendEmailResponse SendEmailSync(SendEmailRequest req)
        {
            return InternalRequestAsync<SendEmailResponse>(req, "SendEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send template emails.
        /// </summary>
        /// <param name="req"><see cref="SendTemplatedEmailRequest"/></param>
        /// <returns><see cref="SendTemplatedEmailResponse"/></returns>
        public Task<SendTemplatedEmailResponse> SendTemplatedEmail(SendTemplatedEmailRequest req)
        {
            return InternalRequestAsync<SendTemplatedEmailResponse>(req, "SendTemplatedEmail");
        }

        /// <summary>
        /// This API is used to send template emails.
        /// </summary>
        /// <param name="req"><see cref="SendTemplatedEmailRequest"/></param>
        /// <returns><see cref="SendTemplatedEmailResponse"/></returns>
        public SendTemplatedEmailResponse SendTemplatedEmailSync(SendTemplatedEmailRequest req)
        {
            return InternalRequestAsync<SendTemplatedEmailResponse>(req, "SendTemplatedEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
