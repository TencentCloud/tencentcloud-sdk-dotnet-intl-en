/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceCertificatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Tencent Cloud MQTT instance ID can be obtained from the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Support search parameter
        /// Client id: Client id, obtained based on actual business operations.
        /// CaSn: The SN serial number of the CA certificate belonging to it can be obtained by querying the cluster CA certificate list (https://www.tencentcloud.com/document/api/1778/116206?from_cn_redirect=1) or through business operations.
        /// DeviceCertificateSn: SN serial number of the device certificate. Can be obtained from [Query Device Certificate Detail](https://www.tencentcloud.com/document/api/1778/113748?from_cn_redirect=1).
        /// DeviceCertificateCn: The device certificate CN.
        /// OrganizationalUnit: Cert OU
        /// NotAfterEnd: Certificates with expiration time less than or equal to the specified time
        /// NotAfterStart: Cert with expiration time equal to or greater than the specified time
        /// Status: Device certificate status. ACTIVE (activated); INACTIVE (inactive); REVOKED (revoked); PENDING_ACTIVATION (to be activated).
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Pagination limit. Default 20. Maximum 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset, default 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting rule
        /// CREATE_TIME_DESC, descending order by creation time
        /// CREATE_TIME_ASC, sort by creation time in ascending order
        /// UPDATE_TIME_DESC, descending order by update time
        /// UPDATE_TIME_ASC, update time in ascending order
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
        }
    }
}

