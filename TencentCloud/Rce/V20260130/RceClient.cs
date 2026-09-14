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

namespace TencentCloud.Rce.V20260130
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rce.V20260130.Models;

   public class RceClient : AbstractClient{

       private const string endpoint = "rce.intl.tencentcloudapi.com";
       private const string version = "2026-01-30";
       private const string sdkVersion = "SDK_NET_3.0.1395";

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
        /// Device Risk assessment - Premium
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskPremiumProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskPremiumProResponse"/></returns>
        public Task<AssessDeviceRiskPremiumProResponse> AssessDeviceRiskPremiumPro(AssessDeviceRiskPremiumProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskPremiumProResponse>(req, "AssessDeviceRiskPremiumPro");
        }

        /// <summary>
        /// Device Risk assessment - Premium
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskPremiumProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskPremiumProResponse"/></returns>
        public AssessDeviceRiskPremiumProResponse AssessDeviceRiskPremiumProSync(AssessDeviceRiskPremiumProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskPremiumProResponse>(req, "AssessDeviceRiskPremiumPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Device Risk Assessment - Basic
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskProResponse"/></returns>
        public Task<AssessDeviceRiskProResponse> AssessDeviceRiskPro(AssessDeviceRiskProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskProResponse>(req, "AssessDeviceRiskPro");
        }

        /// <summary>
        /// Device Risk Assessment - Basic
        /// </summary>
        /// <param name="req"><see cref="AssessDeviceRiskProRequest"/></param>
        /// <returns><see cref="AssessDeviceRiskProResponse"/></returns>
        public AssessDeviceRiskProResponse AssessDeviceRiskProSync(AssessDeviceRiskProRequest req)
        {
            return InternalRequestAsync<AssessDeviceRiskProResponse>(req, "AssessDeviceRiskPro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Environment Risk Assessment
        /// </summary>
        /// <param name="req"><see cref="AssessEnvironmentRiskRequest"/></param>
        /// <returns><see cref="AssessEnvironmentRiskResponse"/></returns>
        public Task<AssessEnvironmentRiskResponse> AssessEnvironmentRisk(AssessEnvironmentRiskRequest req)
        {
            return InternalRequestAsync<AssessEnvironmentRiskResponse>(req, "AssessEnvironmentRisk");
        }

        /// <summary>
        /// Environment Risk Assessment
        /// </summary>
        /// <param name="req"><see cref="AssessEnvironmentRiskRequest"/></param>
        /// <returns><see cref="AssessEnvironmentRiskResponse"/></returns>
        public AssessEnvironmentRiskResponse AssessEnvironmentRiskSync(AssessEnvironmentRiskRequest req)
        {
            return InternalRequestAsync<AssessEnvironmentRiskResponse>(req, "AssessEnvironmentRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to obtain real-time risk information for events. It evaluates and returns risk decision results, risk scores, and risk tags based on device risk, environmental risk, account risk, behavioral risk, and historical reported event data for critical events in your business.
        /// </summary>
        /// <param name="req"><see cref="AssessRiskRequest"/></param>
        /// <returns><see cref="AssessRiskResponse"/></returns>
        public Task<AssessRiskResponse> AssessRisk(AssessRiskRequest req)
        {
            return InternalRequestAsync<AssessRiskResponse>(req, "AssessRisk");
        }

        /// <summary>
        /// Used to obtain real-time risk information for events. It evaluates and returns risk decision results, risk scores, and risk tags based on device risk, environmental risk, account risk, behavioral risk, and historical reported event data for critical events in your business.
        /// </summary>
        /// <param name="req"><see cref="AssessRiskRequest"/></param>
        /// <returns><see cref="AssessRiskResponse"/></returns>
        public AssessRiskResponse AssessRiskSync(AssessRiskRequest req)
        {
            return InternalRequestAsync<AssessRiskResponse>(req, "AssessRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Used to report events that do not require real-time decision-making in your business. Our engine will perform computations and apply machine learning to mine risk features from these events, which are then used to support real-time event risk assessment.
        /// </summary>
        /// <param name="req"><see cref="ReportEventRequest"/></param>
        /// <returns><see cref="ReportEventResponse"/></returns>
        public Task<ReportEventResponse> ReportEvent(ReportEventRequest req)
        {
            return InternalRequestAsync<ReportEventResponse>(req, "ReportEvent");
        }

        /// <summary>
        /// Used to report events that do not require real-time decision-making in your business. Our engine will perform computations and apply machine learning to mine risk features from these events, which are then used to support real-time event risk assessment.
        /// </summary>
        /// <param name="req"><see cref="ReportEventRequest"/></param>
        /// <returns><see cref="ReportEventResponse"/></returns>
        public ReportEventResponse ReportEventSync(ReportEventRequest req)
        {
            return InternalRequestAsync<ReportEventResponse>(req, "ReportEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
