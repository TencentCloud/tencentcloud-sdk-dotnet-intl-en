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

namespace TencentCloud.Rce.V20201103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20201103.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.intl.tencentcloudapi.com";
       private const string version = "2020-11-03";
       private const string sdkVersion = "SDK_NET_3.0.1164";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RceClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RceClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to query risk assessment results.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskAssessmentRequest"/></param>
        /// <returns><see cref="DescribeRiskAssessmentResponse"/></returns>
        public Task<DescribeRiskAssessmentResponse> DescribeRiskAssessment(DescribeRiskAssessmentRequest req)
        {
            return InternalRequestAsync<DescribeRiskAssessmentResponse>(req, "DescribeRiskAssessment");
        }

        /// <summary>
        /// This API is used to query risk assessment results.
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskAssessmentRequest"/></param>
        /// <returns><see cref="DescribeRiskAssessmentResponse"/></returns>
        public DescribeRiskAssessmentResponse DescribeRiskAssessmentSync(DescribeRiskAssessmentRequest req)
        {
            return InternalRequestAsync<DescribeRiskAssessmentResponse>(req, "DescribeRiskAssessment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
