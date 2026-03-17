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

namespace TencentCloud.Tcsas.V20250106
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcsas.V20250106.Models;

   public class TcsasClient : AbstractClient{

       private const string endpoint = "tcsas.intl.tencentcloudapi.com";
       private const string version = "2025-01-06";
       private const string sdkVersion = "SDK_NET_3.0.1275";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcsasClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcsasClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to retrieve the detailed mini game monthly active user data.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNGMAUDataDetailRequest"/></param>
        /// <returns><see cref="DescribeMNGMAUDataDetailResponse"/></returns>
        public Task<DescribeMNGMAUDataDetailResponse> DescribeMNGMAUDataDetail(DescribeMNGMAUDataDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNGMAUDataDetailResponse>(req, "DescribeMNGMAUDataDetail");
        }

        /// <summary>
        /// This API is used to retrieve the detailed mini game monthly active user data.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNGMAUDataDetailRequest"/></param>
        /// <returns><see cref="DescribeMNGMAUDataDetailResponse"/></returns>
        public DescribeMNGMAUDataDetailResponse DescribeMNGMAUDataDetailSync(DescribeMNGMAUDataDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNGMAUDataDetailResponse>(req, "DescribeMNGMAUDataDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve mini game monthly active user data in a line chart format.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNGMAULineChartRequest"/></param>
        /// <returns><see cref="DescribeMNGMAULineChartResponse"/></returns>
        public Task<DescribeMNGMAULineChartResponse> DescribeMNGMAULineChart(DescribeMNGMAULineChartRequest req)
        {
            return InternalRequestAsync<DescribeMNGMAULineChartResponse>(req, "DescribeMNGMAULineChart");
        }

        /// <summary>
        /// This API is used to retrieve mini game monthly active user data in a line chart format.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNGMAULineChartRequest"/></param>
        /// <returns><see cref="DescribeMNGMAULineChartResponse"/></returns>
        public DescribeMNGMAULineChartResponse DescribeMNGMAULineChartSync(DescribeMNGMAULineChartRequest req)
        {
            return InternalRequestAsync<DescribeMNGMAULineChartResponse>(req, "DescribeMNGMAULineChart")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve MAU comparison data for a mini game between two months.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNGMAUMonthlyComparisonMetricCardRequest"/></param>
        /// <returns><see cref="DescribeMNGMAUMonthlyComparisonMetricCardResponse"/></returns>
        public Task<DescribeMNGMAUMonthlyComparisonMetricCardResponse> DescribeMNGMAUMonthlyComparisonMetricCard(DescribeMNGMAUMonthlyComparisonMetricCardRequest req)
        {
            return InternalRequestAsync<DescribeMNGMAUMonthlyComparisonMetricCardResponse>(req, "DescribeMNGMAUMonthlyComparisonMetricCard");
        }

        /// <summary>
        /// This API is used to retrieve MAU comparison data for a mini game between two months.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNGMAUMonthlyComparisonMetricCardRequest"/></param>
        /// <returns><see cref="DescribeMNGMAUMonthlyComparisonMetricCardResponse"/></returns>
        public DescribeMNGMAUMonthlyComparisonMetricCardResponse DescribeMNGMAUMonthlyComparisonMetricCardSync(DescribeMNGMAUMonthlyComparisonMetricCardRequest req)
        {
            return InternalRequestAsync<DescribeMNGMAUMonthlyComparisonMetricCardResponse>(req, "DescribeMNGMAUMonthlyComparisonMetricCard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the detailed mini program monthly active user data.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPMAUDataDetailRequest"/></param>
        /// <returns><see cref="DescribeMNPMAUDataDetailResponse"/></returns>
        public Task<DescribeMNPMAUDataDetailResponse> DescribeMNPMAUDataDetail(DescribeMNPMAUDataDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNPMAUDataDetailResponse>(req, "DescribeMNPMAUDataDetail");
        }

        /// <summary>
        /// This API is used to retrieve the detailed mini program monthly active user data.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPMAUDataDetailRequest"/></param>
        /// <returns><see cref="DescribeMNPMAUDataDetailResponse"/></returns>
        public DescribeMNPMAUDataDetailResponse DescribeMNPMAUDataDetailSync(DescribeMNPMAUDataDetailRequest req)
        {
            return InternalRequestAsync<DescribeMNPMAUDataDetailResponse>(req, "DescribeMNPMAUDataDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve mini program monthly active user data in a line chart format.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPMAULineChartRequest"/></param>
        /// <returns><see cref="DescribeMNPMAULineChartResponse"/></returns>
        public Task<DescribeMNPMAULineChartResponse> DescribeMNPMAULineChart(DescribeMNPMAULineChartRequest req)
        {
            return InternalRequestAsync<DescribeMNPMAULineChartResponse>(req, "DescribeMNPMAULineChart");
        }

        /// <summary>
        /// This API is used to retrieve mini program monthly active user data in a line chart format.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPMAULineChartRequest"/></param>
        /// <returns><see cref="DescribeMNPMAULineChartResponse"/></returns>
        public DescribeMNPMAULineChartResponse DescribeMNPMAULineChartSync(DescribeMNPMAULineChartRequest req)
        {
            return InternalRequestAsync<DescribeMNPMAULineChartResponse>(req, "DescribeMNPMAULineChart")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve MAU comparison data for a mini program between two months.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPMAUMetricCardRequest"/></param>
        /// <returns><see cref="DescribeMNPMAUMetricCardResponse"/></returns>
        public Task<DescribeMNPMAUMetricCardResponse> DescribeMNPMAUMetricCard(DescribeMNPMAUMetricCardRequest req)
        {
            return InternalRequestAsync<DescribeMNPMAUMetricCardResponse>(req, "DescribeMNPMAUMetricCard");
        }

        /// <summary>
        /// This API is used to retrieve MAU comparison data for a mini program between two months.
        /// </summary>
        /// <param name="req"><see cref="DescribeMNPMAUMetricCardRequest"/></param>
        /// <returns><see cref="DescribeMNPMAUMetricCardResponse"/></returns>
        public DescribeMNPMAUMetricCardResponse DescribeMNPMAUMetricCardSync(DescribeMNPMAUMetricCardRequest req)
        {
            return InternalRequestAsync<DescribeMNPMAUMetricCardResponse>(req, "DescribeMNPMAUMetricCard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
